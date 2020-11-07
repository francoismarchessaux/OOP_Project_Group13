using MySqlConnector;
using MySqlX.XDevAPI.Relational;
using OOP_Project_Group13.Forms;
using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    public partial class StudentInformationsWindow : Form
    {
        MySqlConnection connection;
        Student student;
        public StudentInformationsWindow(MySqlConnection _connection, Student _student)
        {
            InitializeComponent();
            connection = _connection;
            student = _student;
        }

        private void StudentInformationsWindow_Load(object sender, EventArgs e)
        {
            NameLabel.Text = student.name.ToUpper() + " " + student.firstName.ToLower();
            StudentIDLabel.Text = "ID : " + student.ID.ToString();
            if (student.birthday.Date.ToString("dd/MM/yyyy") == "01/01/2000")
            {
                BirthDate.Text = "Birthday date : Not yet entered";
            }
            else
            {
                BirthDate.Text = "Birthday date : " + student.birthday.Date.ToString("dd/MM/yyyy");
            }
            if (student.address == "Adress")
            {
                AdressLabel.Text = "Address : Not yet entered";
            }
            else
            {
                AdressLabel.Text = "Address : " + student.address;
            }
            MailLabel.Text = "Mail : " + student.mail;
            if (student.phone == "0000000000")
            {
                PhoneLabel.Text = "Phone number : Not yet entered";
            }
            else
            {
                PhoneLabel.Text = "Phone number : " + student.phone;
            }
            StudentPicture.ImageLocation = student.profilePicture;
            GetGrades(student.ID.ToString());
        }

        private void PlaceGrade(PanelCourse course, Grade grade, List<PanelCourse> listCourses)
        {
            Label gradeName = new Label();
            gradeName.Text = grade.NomCC;
            gradeName.AutoSize = true;
            Label note = new Label();
            note.Text = "" + grade.Note;
            note.AutoSize = true;
            LabelGrade addGrade = new LabelGrade(gradeName, note);
            course.grades.Add(addGrade);
            course.Controls.Add(addGrade.name);
            course.Controls.Add(addGrade.grade);
            int count = course.grades.Count;
            int y = 30 * count;
            addGrade.name.Location = new Point(200, y);
            addGrade.grade.Location = new Point(710, y);
            addGrade.name.Visible = true;
            addGrade.grade.Visible = true;
            course.Height += 20;
        }
        private PanelCourse AddCourse(Average avg, List<PanelCourse> listCourses)
        {
            Label courseName = new Label();
            Label averageLabel = new Label();
            Label average = new Label();
            List<LabelGrade> grades = new List<LabelGrade>();
            PanelCourse newPan = new PanelCourse(courseName, averageLabel, average, grades);
            newPan.Height = 70;
            newPan.Width = 752;
            int x = 0;
            int y = 10;
            int max = 0;
            foreach (Control c in generalPanel.Controls)
            {
                if (c is Panel && c.Location.Y>max)
                    max=c.Location.Y+c.Height;
            }
            y = max+10 ;
            generalPanel.Controls.Add(newPan);
            Panel title = new Panel();
            title.Height = 30;
            title.Width = 750;
            title.BackColor = Color.LightSlateGray;
            newPan.Location = new Point(x, y);
            courseName.Text = avg.subject.name;
            courseName.AutoSize = true;
            courseName.Visible = true;
            title.Controls.Add(courseName);
            courseName.Location = new Point(10, 10);
            averageLabel.Text = "Average : ";
            averageLabel.AutoSize = true;
            averageLabel.Visible = true;
            title.Controls.Add(averageLabel);
            averageLabel.Location = new Point(650, 10);
            double mean = avg.GetAverage();
            average.Text = ""+mean;
            average.AutoSize = true;
            average.Visible = true;
            title.Controls.Add(average);
            average.Location = new Point(710, 10);
            newPan.Controls.Add(title);
            listCourses.Add(newPan);
            return newPan;
        }
        private void GetGrades(string studentID)
        {
            String query = "SELECT * FROM grade WHERE studentID='" + studentID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            List<PanelCourse> listCourses = new List<PanelCourse>();
            List<Average> subjects = new List<Average>();
            foreach (DataRow row in dt.Rows)
            {
                if (subjects.Count == 0)
                {
                    Subject subject = new Subject(row["Subject"].ToString());
                    Grade grade = new Grade(Convert.ToInt32(row["studentGrade"].ToString()), row["AssesmentName"].ToString(), Convert.ToInt32(row["coefficient"].ToString()), subject);
                    List<Grade> grades = new List<Grade>();
                    grades.Add(grade);
                    Average avg = new Average(subject, grades);
                    subjects.Add(avg);
                }
                else
                {
                    bool subjExist = false;
                    Average avg = null;
                    for (int i = 0; i < subjects.Count; i++)
                    {
                        Subject subject = new Subject(row["Subject"].ToString());
                        if (subject.name.Equals(subjects[i].subject.name))
                        {
                            subjExist = true;
                            avg = subjects[i];
                        }
                    }
                    if (subjExist == true)
                    {
                        Grade grade = new Grade(Convert.ToInt32(row["studentGrade"].ToString()), row["AssesmentName"].ToString(), Convert.ToInt32(row["coefficient"].ToString()), avg.subject);
                        avg.grades.Add(grade);
                    }
                    else
                    {
                        Subject subject = new Subject(row["Subject"].ToString());
                        Grade grade = new Grade(Convert.ToInt32(row["studentGrade"].ToString()), row["AssesmentName"].ToString(), Convert.ToInt32(row["coefficient"].ToString()), subject);
                        List<Grade> grades = new List<Grade>();
                        grades.Add(grade);
                        avg = new Average(subject, grades);
                        subjects.Add(avg);
                    }

                }
            }
            for (int i = 0; i < subjects.Count; i++)
            {
                PanelCourse course = AddCourse(subjects[i], listCourses);
                for (int j = 0; j < subjects[i].grades.Count; j++)
                {
                    PlaceGrade(course, subjects[i].grades[j], listCourses);
                }
            }
        }

        private void PanelTimeTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            InitializeTimeTable();
            GetTimetable(student.ID.ToString());            
        }
        private void InitializeTimeTable()
        {
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int[] hour = { 8, 1, 4 };
            int y = 65;
            for (int j = 0; j < hour.Length; j++)
            {
                Label label = new Label();
                label.Name = "label"+hour[j];
                label.Text = hour[j] + ":00";
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Location = new Point(12, y);
                if (j == 0)
                    y += 100;
                else
                    y += 80;
                generalPanel.Controls.Add(label);
            }
            int x = -75;
            for (int i = 0; i < week.Length; i++)
            {
                Label l = new Label();
                l.Name = week[i];
                l.Text = week[i];
                l.Height = 20;
                l.Width = 87;
                l.TextAlign = ContentAlignment.MiddleCenter;
                x += 150;
                y = 23;
                l.Location = new Point(x, y);
                y = 65;
                generalPanel.Controls.Add(l);
                int[] tab = { 8,1,4 };
                for (int j = 0; j < 3; j++)
                {
                    Label label = new Label();
                    label.Name = "" + week[i][0] + week[i][1] + week[i][2] + tab[j];
                    label.Height = 55;
                    label.Width = 87;
                    label.BorderStyle= BorderStyle.FixedSingle;
                    label.Location = new Point(x,y);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Visible = false;
                    if (j == 0)
                        y += 100;
                    else
                        y += 80;
                    generalPanel.Controls.Add(label);
                }
            }
        }
        private void GetTimetable(string id)
        {
            String query = "SELECT * FROM Class WHERE studentID='" + id + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string info = dt.Rows[i]["Horaire"].ToString();
                    string[] horaire = info.Split(' ');
                    string nom = dt.Rows[i]["className"].ToString();
                    string labelName = "" + horaire[0][0] + horaire[0][1] + horaire[0][2] + horaire[1][0];
                    foreach (Control x in generalPanel.Controls)
                    {
                        if (x is Label)
                        {
                            string n = x.Name;
                            if (labelName == n)
                            {
                                x.Visible = true;
                                x.Text = nom;
                            }
                        }
                    }
                }
            }
        }
        private void buttonGrade_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            GetGrades(student.ID.ToString());
        }
    }
}
