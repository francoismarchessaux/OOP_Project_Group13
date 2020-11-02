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
        SqlConnection connection;
        Student student;
        public StudentInformationsWindow(SqlConnection _connection, Student _student)
        {
            InitializeComponent();
            connection = _connection;
            student = _student;
        }

        private void StudentInformationsWindow_Load(object sender, EventArgs e)
        {
            NameLabel.Text = student.name.ToUpper() + " " + student.firstName.ToLower();
            StudentIDLabel.Text = "ID : " + student.ID.ToString();
            BirthDate.Text = "Birthday date : " + student.birthday.Date.ToString("dd/MM/yyyy");
            AdressLabel.Text = "Address : " + student.address;
            MailLabel.Text = "Mail : " + student.mail;
            PhoneLabel.Text = "Phone number : " + student.phone;
            StudentPicture.ImageLocation = student.profilePicture;
            List<PanelCourse> listCourses = new List<PanelCourse>();
            PanelCourse algo = AddCourse("Algo",listCourses);
            PanelCourse maths = AddCourse("Maths", listCourses);
            PanelCourse physique = AddCourse("Maths", listCourses);
            LabelGrade cc1 = AddGrade("CC1");
            LabelGrade quizz1 = AddGrade("Quizz1");
            PlaceGrade(algo, cc1, listCourses);
            PlaceGrade(algo, quizz1,listCourses);
            LabelGrade cc1Maths = AddGrade("CC1");
            PlaceGrade(maths, cc1Maths, listCourses);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private PanelCourse AddCourse(string name,List<PanelCourse> listCourses)
        {
            Label courseName = new Label();
            Label averageLabel = new Label();
            Label average = new Label();
            List<LabelGrade> grades= new List<LabelGrade>();
            PanelCourse newPan = new PanelCourse(courseName,averageLabel,average,grades);
            newPan.Height = 70;
            newPan.Width = 752;
            int x = 0;
            int y = 0;
            int count = 0;
            foreach(Control c in generalPanel.Controls)
            {
                if (c is Panel)
                    count++;
            }
            y += count * 80;
            generalPanel.Controls.Add(newPan);
            newPan.Location = new Point(x, y);
            courseName.Text = name;
            courseName.AutoSize = true;
            courseName.Visible = true;
            newPan.Controls.Add(courseName);
            courseName.Location = new Point(10, 10);
            averageLabel.Text = "Average : ";
            averageLabel.AutoSize = true;
            averageLabel.Visible = true;
            newPan.Controls.Add(averageLabel);
            averageLabel.Location = new Point(650,10);
            average.Text = "00.00";
            average.AutoSize = true;
            average.Visible = true;
            newPan.Controls.Add(average);
            average.Location = new Point(710, 10);
            listCourses.Add(newPan);
            return newPan;
        }
        private LabelGrade AddGrade(string name)
        {
            Label gradeName = new Label();
            gradeName.Text = name;
            gradeName.AutoSize = true;
            Label grade = new Label();
            grade.Text = "00.00";
            grade.AutoSize = true;
            LabelGrade addGrade = new LabelGrade(gradeName,grade);
            return addGrade;
         }
        private void PlaceGrade(PanelCourse course ,LabelGrade grade,List<PanelCourse> listCourses)
        {
            course.grades.Add(grade);
            course.Controls.Add(grade.name);
            course.Controls.Add(grade.grade);
            int count = course.grades.Count;
            int y = 25*count;
            grade.name.Location = new Point(200, y);
            grade.grade.Location = new Point(710, y);
            grade.name.Visible = true;
            grade.grade.Visible = true;
            int index = 0;
            while (course != listCourses[index])
                index++;
            listCourses[index].Height += 20;
            for (int i = index+1; i < listCourses.Count; i++)
            {
                int pos = listCourses[i].Location.Y;
                listCourses[i].Location = new Point(0, pos + 20);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
