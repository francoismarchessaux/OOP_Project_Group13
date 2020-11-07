using MySqlConnector;
using System;
using System.Windows.Forms;

namespace OOP_Project_Group13.Forms
{
    public partial class FacultyInformationsWindows : Form
    {
        MySqlConnection connection;
        Faculty Teacher;
        public FacultyInformationsWindows(MySqlConnection _connection, Faculty _Teacher)
        {
            InitializeComponent();
            connection = _connection;
            Teacher = _Teacher;
        }

        private void FacultyInformationsWindows_Load(object sender, EventArgs e)
        {
            TeacherName.Text = Teacher.firstName + " " + Teacher.name;
            teacherID.Text = "ID : " + Teacher.ID.ToString();
            TeacherMail.Text = "Mail : " + Teacher.mail;
            if(Teacher.phone == "0000000000")
            {
                TeacherPhone.Text = "Phone : Not yet entered";
            }
            else
            {
                TeacherPhone.Text = "Phone : " + Teacher.phone;
            }
            teacherPicture.ImageLocation = Teacher.profilePicture;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}