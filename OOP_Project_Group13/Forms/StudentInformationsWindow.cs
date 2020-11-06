using MySqlConnector;
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
            BirthDate.Text = "Birthday date : " + student.birthday.Date.ToString("dd/MM/yyyy");
            AdressLabel.Text = "Address : " + student.address;
            MailLabel.Text = "Mail : " + student.mail;
            PhoneLabel.Text = "Phone number : " + student.phone;
            StudentPicture.ImageLocation = student.profilePicture;
            Label label1 = new Label();
            splitContainer1.Panel1.Controls.Add(label1);
            label1.Visible = true;
            label1.Text = "a";
            label1.Location = new Point(800,400);
            

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
