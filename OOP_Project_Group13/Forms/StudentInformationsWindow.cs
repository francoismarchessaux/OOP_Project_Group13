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
            String query = "SELECT * FROM grade WHERE studentID='" + student.ID.ToString() + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            List<PanelCourse> listCourses = new List<PanelCourse>();
            List<Average> subjects = new List<Average>();
            foreach(DataRow row in dt.Rows)
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
                    Average avg=null;
                    for (int i = 0; i < subjects.Count; i++)
                    {
                        Subject subject = new Subject(row["Subject"].ToString());
                        if (subject.name == subjects[i].subject.name)
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
                    PlaceGrade(course,subjects[i].grades[j],listCourses);
                }
            }
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
            int y = 50;
            int count = 0;
            foreach (Control c in generalPanel.Controls)
            {
                if (c is Panel)
                    count++;
            }
            y += count * 80;
            generalPanel.Controls.Add(newPan);
            newPan.Location = new Point(x, y);
            courseName.Text = avg.subject.name;
            courseName.AutoSize = true;
            courseName.Visible = true;
            newPan.Controls.Add(courseName);
            courseName.Location = new Point(10, 10);
            averageLabel.Text = "Average : ";
            averageLabel.AutoSize = true;
            averageLabel.Visible = true;
            newPan.Controls.Add(averageLabel);
            averageLabel.Location = new Point(650, 10);
            average.Text = ""+avg.GetAverage();
            average.AutoSize = true;
            average.Visible = true;
            newPan.Controls.Add(average);
            average.Location = new Point(710, 10);
            listCourses.Add(newPan);
            return newPan;
        }
    }
}
