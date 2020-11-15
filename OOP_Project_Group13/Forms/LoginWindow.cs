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

namespace OOP_Project_Group13
{
    public partial class LoginWindow : Form
    {
        MySqlConnection connection;
        public LoginWindow(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
        }

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
                        this.Hide();
                        adminWindow.Show();
                        break;

                    case "Faculty":
                        string classes = userTable.Rows[0]["className"].ToString();
                        string[] list = classes.Split(' ');
                        List<Class> listClasses = new List<Class>();
                        foreach(string classe in list)
                        {
                            Class c = new Class(classe);
                            listClasses.Add(c);
                        }
                        Faculty teacher = new Faculty(Convert.ToInt32(userTable.Rows[0]["userID"]));
                        FacultyHomePage facultyInfoWin = new FacultyHomePage(connection, teacher);
                        this.Hide();
                        facultyInfoWin.Show();
                        break;

                    case "Student":
                        Student selectedStudent = new Student(Convert.ToInt32(userTable.Rows[0]["studentID"].ToString()));
                        StudentInformationsWindow studentInfoWin = new StudentInformationsWindow(connection, selectedStudent);
                        this.Hide();
                        studentInfoWin.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error : check your user ID and your password");
                userID_TextBox.Clear();
                password_TextBox.Clear();
            }
        }

        private void password_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }
    }
}
