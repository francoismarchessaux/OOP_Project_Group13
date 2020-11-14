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
            int y = 0;
            if (count == 0)
                y = 40;
            else
                y = 30 * count;
            addGrade.name.Location = new Point(200, y);
            addGrade.grade.Location = new Point(900, y);
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
            newPan.Width = 930;
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
            title.Width = 930;
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
            averageLabel.Location = new Point(850, 10);
            double mean = avg.GetAverage();
            average.Text = ""+mean;
            average.AutoSize = true;
            average.Visible = true;
            title.Controls.Add(average);
            average.Location = new Point(900, 10);
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
            if (dt.Rows.Count != 0)
            {
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
        }

        private void PanelTimeTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            TimeTable tt = new TimeTable(student, connection, generalPanel);
            tt.InitializeTimeTable();
            tt.GetTimetable();            
        }
        
        private void buttonGrade_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            GetGrades(student.ID.ToString());
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            student.attendances.GetGrades(student.ID.ToString(),generalPanel);
        }
    }
}
