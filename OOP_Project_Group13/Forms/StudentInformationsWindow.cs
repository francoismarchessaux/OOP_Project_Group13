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

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
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

        /// <summary>
        /// Loads the window with all of the information of the student on the data table 
        /// Not every information is accessible depending on which person is connected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentInformationsWindow_Load(object sender, EventArgs e)
        {
            if(status == "Admin")
            {
                profileBtn.Visible = false;
                RefreshBtn.Visible = false;
                backButton.Text = "Back";
                DeleteBtn.Visible = true;
                if (teacher != null)
                    DeleteBtn.Visible = false;

                student.GetGrades(generalPanel);
            }
            if (status == "Faculty")
            {
                profileBtn.Visible = false;
                AdressLabel.Visible = false;
                PhoneLabel.Visible = false;
                Fees.Visible = false;
                backButton.Text = "Back";
                DeleteBtn.Visible = false;
                student.GetGrades2(generalPanel, teacher);
            }
            if (status == "Student")
            {
                backButton.Text = "Log Out";
                DeleteBtn.Visible = false;
                student.GetGrades(generalPanel);
            }
            NameLabel.Text = student.name.ToUpper() + " " + student.firstName.ToLower();
            StudentIDLabel.Text = "ID : " + student.ID.ToString();
            if (student.birthday.Date.ToString("dd/MM/yyyy") == "01/01/1900")
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

        /// <summary>
        /// Generates the timetable of the student on the "general" panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            TimeTable tt = new TimeTable(student, generalPanel,status);
            tt.InitializeTimeTable();
            tt.GetTimetable();
            PaymentButton.Visible = false;       
        }
        
        /// <summary>
        /// Generates the list of grades of the student in every course on the"general" panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Generates the list of attendances of the student in every course on the "general" panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            generalPanel.Controls.Clear();
            student.attendances.GetAttendance(generalPanel);
            PaymentButton.Visible = false;
        }

        /// <summary>
        /// Generates the informations of the student concerning the payment of his tuition fees on the "general" panel
        /// A different message is shown if the student already paid all of his fees
        /// If the tuiton fees aren't fully paid and the person connected is the student himself, 
        /// the payment button is made visible 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Closes the active window and regenerates/open the Payment Window of the connected student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            PaymentWindow paymentWindow = new PaymentWindow(connection, student, status);
            paymentWindow.Show();
        }

        private void generalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Closes the active window and regenerates/open the Modify Profil Window for the connected student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profileBtn_Click(object sender, EventArgs e)
        {
            ModifyProfile mod = new ModifyProfile(connection, student.ID);
            mod.Show();
        }

        /// <summary>
        /// Closes the active window to get back eitherto the Administrator Main Window (if the admin is connected)
        /// To the login Window (if the student is connected) or the Faculty Information Window (if the teacher is connected)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Button used to "refresh" the window, in case the student modifies his profile
        /// The window needs to be updated with the new information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            String query = "Select * from Users Where userID ='" + student.ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            if (student.birthday.Date.ToString("dd/MM/yyyy") == "01/01/1900")
            {
                BirthDate.Text = "Birthday date : Not yet entered";
            }
            else
            {
                BirthDate.Text = "Birthday date : " + Convert.ToDateTime(dt.Rows[0]["birthday"]).ToString("dd/MM/yyyy");
            }
            if (student.address == "Address")
            {
                AdressLabel.Text = "Address : Not yet entered";
            }
            else
            {
                AdressLabel.Text = "Address : " + dt.Rows[0]["address"];
            }
            if (student.phone == "0000000000")
            {
                PhoneLabel.Text = "Phone number : Not yet entered";
            }
            else
            {
                PhoneLabel.Text = "Phone number : " + dt.Rows[0]["phone"];
            }
            StudentPicture.ImageLocation = dt.Rows[0]["profilePicture"].ToString();
        }

        /// <summary>
        /// Button only visible for an admin
        /// Offers the possibility to remove the student for the data table
        /// Therefore, this student will no longer exists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM users WHERE userID = '" + student.ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            connection.Open();
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User deleted successfully !");
            Close();
        }
    }
}
