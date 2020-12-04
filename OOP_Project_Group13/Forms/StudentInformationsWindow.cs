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
        string status;
        Faculty teacher;

        public StudentInformationsWindow(MySqlConnection _connection, Student _student, string _status, Faculty _teacher)
        {
            InitializeComponent();
            connection = _connection;
            student = _student;
            status = _status;
            teacher = _teacher;
        }
        public StudentInformationsWindow(MySqlConnection _connection, Student _student, string _status)
        {
            InitializeComponent();
            connection = _connection;
            student = _student;
            status = _status;
            
        }

        private void StudentInformationsWindow_Load(object sender, EventArgs e)
        {
            if(status == "Admin")
            {
                profileBtn.Visible = false;
            }
            if (status == "Faculty")
            {
                profileBtn.Visible = false;
                AdressLabel.Visible = false;
                PhoneLabel.Visible = false;
                Fees.Visible = false;
                student.GetGrades2(generalPanel, teacher);
            }
            else
            {
                backButton.Text = "Log Out";
                student.GetGrades(generalPanel);
            }
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
            if (student.address == "Address")
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

            PaymentButton.Visible = false;
        }

        private void PanelTimeTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            TimeTable tt = new TimeTable(student, generalPanel,status);
            tt.InitializeTimeTable();
            tt.GetTimetable();
            PaymentButton.Visible = false;       
        }
        
        private void buttonGrade_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            if (status == "Faculty")
            {
                student.GetGrades2(generalPanel, teacher);
            }
            else
            {
                student.GetGrades(generalPanel);
            }
            
            PaymentButton.Visible = false;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            student.attendances.GetAttendance(generalPanel);
            PaymentButton.Visible = false;
        }

        private void Fees_Click(object sender, EventArgs e)
        {
            String query = "Select * from Users Where userID ='" + student.ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            generalPanel.Controls.Clear();           
            student.FeesPanel(generalPanel, status);

            if (status == "Student" && Convert.ToDouble(dt.Rows[0]["fees"]) > 0.00)
            {
                PaymentButton.Visible = true;
            }
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            PaymentWindow paymentWindow = new PaymentWindow(connection, student, status);
            paymentWindow.Show();
        }

        private void generalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ModifyProfile mod = new ModifyProfile(connection, student.ID);
            mod.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
