using System;
using OOP_Project_Group13.Users;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using OOP_Project_Group13.Forms;

namespace OOP_Project_Group13
{
    public partial class LoginWindow : Form
    {
        static MySqlConnection connection;
        public LoginWindow(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
        }
        /// <summary>
        /// Verifies that the password and the ID  number are correct 
        /// Sends the user to his environment according to his status : Admin/Faculty/Student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String query = "Select * from users Where userID = ' " + userID_TextBox.Text + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            if (userTable.Rows.Count != 0 && userTable.Rows[0]["password"].Equals(password_TextBox.Text))
            {
                string userStatus = userTable.Rows[0]["status"].ToString();
                switch (userStatus)
                {
                    case "Admin":
                        Administrator admin = new Administrator(Convert.ToInt32(userTable.Rows[0]["userID"]));
                        AdministratorMainWindow adminWindow = new AdministratorMainWindow(admin, connection);
                        adminWindow.Show();
                        break;

                    case "Faculty":
                        if(userTable.Rows[0]["firstConnection"].ToString() == "true")
                        {
                            FirstConWin win = new FirstConWin(userID_TextBox.Text, connection, "Teacher");
                            win.Show();
                        }
                        else
                        {
                            RunTeacher(userID_TextBox.Text);
                        }
                        break;

                    case "Student":
                        if (userTable.Rows[0]["firstConnection"].ToString() == "true")
                        {
                            FirstConWin win = new FirstConWin(userID_TextBox.Text, connection, "Student");
                            win.Show();
                        }
                        else
                        {
                            RunStudent(userID_TextBox.Text);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error : check your user ID and your password");
                userID_TextBox.Clear();
                password_TextBox.Clear();
            }
            userID_TextBox.Clear();
            password_TextBox.Clear();
        }
        /// <summary>
        /// Allows the user to validate his choice by pressing the enter key directly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }
        /// <summary>
        /// Open the Faculty Information window (Teacher's environment)
        /// </summary>
        /// <param name="id"></param>
        public static void RunTeacher(string id)
        {
            String query = "Select * from users Where userID = ' " + id + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            string classes = userTable.Rows[0]["className"].ToString();
            string[] list = classes.Split(' ');
            List<Class> listClasses = new List<Class>();
            foreach (string classe in list)
            {
                Class c = new Class(classe);
                listClasses.Add(c);
            }
            Faculty teacher = new Faculty(Convert.ToInt32(userTable.Rows[0]["userID"]));
            FacultyInformationsWindows facWin = new FacultyInformationsWindows(connection, teacher, "Teacher");
            facWin.Show();
        }
        /// <summary>
        /// Open the Student Information window (Student's environment)
        /// </summary>
        /// <param name="id"></param>
        public static void RunStudent(string id)
        {
            String query = "Select * from users Where userID = ' " + id + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            Student selectedStudent = new Student(Convert.ToInt32(userTable.Rows[0]["userID"].ToString()));
            StudentInformationsWindow studentInfoWin = new StudentInformationsWindow(connection, selectedStudent, "Student");
            studentInfoWin.Show();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
