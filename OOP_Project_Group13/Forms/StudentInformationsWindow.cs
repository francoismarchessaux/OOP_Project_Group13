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
            AddCourse("Algo");
            AddCourse("Maths");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddCourse(string name)
        {
            Panel newPan = new Panel();
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
            Label courseName = new Label();
            courseName.Text = name;
            courseName.AutoSize = true;
            courseName.Visible = true;
            newPan.Controls.Add(courseName);
            courseName.Location = new Point(10, 10);
            Label averageLabel = new Label();
            averageLabel.Text = "Average : ";
            averageLabel.AutoSize = true;
            averageLabel.Visible = true;
            newPan.Controls.Add(averageLabel);
            averageLabel.Location = new Point(650,10);
            Label average = new Label();
            average.Text = "00.00";
            average.AutoSize = true;
            average.Visible = true;
            newPan.Controls.Add(average);
            average.Location = new Point(710, 10);

        }
    }
}
