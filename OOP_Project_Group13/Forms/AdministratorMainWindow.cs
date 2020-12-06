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

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13
{
    public partial class AdministratorMainWindow : Form
    {
        MySqlConnection connection;
        Administrator admin;
        public AdministratorMainWindow(Administrator _admin, MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            admin = _admin;
            AdminName_Label.Text = admin.firstName + " " + admin.name;
            AdminID_Label.Text = admin.ID.ToString();
            AdminPP_PictureBox.ImageLocation = admin.profilePicture;
        }
        /// <summary>
        /// Open the student creation window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            CreateUser studentCreationWindow = new CreateUser(connection, "Student", admin);
            studentCreationWindow.Show();
        }

        /// <summary>
        /// Method that opens the student informations window when the admin selects a student in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] studentInfo = this.StudentList.Text.Split(' ');
            Student selectedStudent = new Student(Convert.ToInt32(studentInfo[2]));
            StudentInformationsWindow studentInfoWin = new StudentInformationsWindow(connection, selectedStudent, "Admin");
            studentInfoWin.Show();
        }

        /// <summary>
        /// Method that fills all the combobox with the relevant items when the window loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministratorMainWindow_Load(object sender, EventArgs e)
        {
            String query = "Select name, firstName, userID from Users Where status = 'Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                this.StudentList.Items.Add(userTable.Rows[i]["name"].ToString() + " " + userTable.Rows[i]["firstName"].ToString() + " " + userTable.Rows[i]["userID"].ToString());
            }
            query = "Select name, firstName, userID from Users Where status = 'Faculty'";
            SDA = new MySqlDataAdapter(query, connection);
            DataTable TeacherTable = new DataTable();
            SDA.Fill(TeacherTable);
            for (int i = 0; i < TeacherTable.Rows.Count; i++)
            {
                this.TeacherList.Items.Add(TeacherTable.Rows[i]["name"].ToString() + " " + TeacherTable.Rows[i]["firstName"].ToString() + " " + TeacherTable.Rows[i]["userID"].ToString());
            }
            query = "Select className from class";
            SDA = new MySqlDataAdapter(query, connection);
            DataTable ClassTable = new DataTable();
            SDA.Fill(ClassTable);
            for (int i = 0; i < ClassTable.Rows.Count; i++)
            {
                this.ClassesList.Items.Add(ClassTable.Rows[i]["className"]);
            }
        }

        /// <summary>
        /// Open the faculty informations window when the admin selects a teacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] teacherInfo = this.TeacherList.Text.Split(' ');
            String query = "Select * from users Where userID = '" + teacherInfo[2] + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable teacherTable = new DataTable();
            SDA.Fill(teacherTable);
            Faculty selectedTeacher = new Faculty(Convert.ToInt32(teacherTable.Rows[0]["userID"]));
            FacultyInformationsWindows TeacherInfoWin = new FacultyInformationsWindows(connection, selectedTeacher, "Admin");
            TeacherInfoWin.Show();
        }

        /// <summary>
        /// Opens the create teacher window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTeacherBtn_Click(object sender, EventArgs e)
        {
            CreateUser teacherCreationWindow = new CreateUser(connection, "Faculty", admin);
            teacherCreationWindow.Show();
        }

        /// <summary>
        /// Open the class information windown when the admin selects the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classNameStr = ClassesList.Text;
            Class selectedClass = new Class(classNameStr);
            ManageClassWindow classMngWin = new ManageClassWindow(selectedClass, connection, true);
            classMngWin.Show();
        }

        /// <summary>
        /// Open the class creation window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            CreateClass ClassCreationWindow = new CreateClass(connection, admin);
            ClassCreationWindow.Show();
        }

        /// <summary>
        /// Refresh the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            StudentList.Text = "Select Student ...";
            TeacherList.Text = "Select Teacher ...";
            ClassesList.Text = "Select Class ...";
            StudentList.Items.Clear();
            TeacherList.Items.Clear();
            ClassesList.Items.Clear();
            String query = "Select name, firstName, userID from Users Where status = 'Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                this.StudentList.Items.Add(userTable.Rows[i]["name"].ToString() + " " + userTable.Rows[i]["firstName"].ToString() + " " + userTable.Rows[i]["userID"].ToString());
            }
            query = "Select name, firstName, userID from Users Where status = 'Faculty'";
            SDA = new MySqlDataAdapter(query, connection);
            DataTable TeacherTable = new DataTable();
            SDA.Fill(TeacherTable);
            for (int i = 0; i < TeacherTable.Rows.Count; i++)
            {
                this.TeacherList.Items.Add(TeacherTable.Rows[i]["name"].ToString() + " " + TeacherTable.Rows[i]["firstName"].ToString() + " " + TeacherTable.Rows[i]["userID"].ToString());
            }
            query = "Select className from class";
            SDA = new MySqlDataAdapter(query, connection);
            DataTable ClassTable = new DataTable();
            SDA.Fill(ClassTable);
            for (int i = 0; i < ClassTable.Rows.Count; i++)
            {
                this.ClassesList.Items.Add(ClassTable.Rows[i]["className"]);
            }
            query = "Select profilePicture from Users Where userID = '" + admin.ID + "'";
            SDA = new MySqlDataAdapter(query, connection);
            DataTable pp = new DataTable();
            SDA.Fill(pp);
            AdminPP_PictureBox.ImageLocation = pp.Rows[0]["profilePicture"].ToString();
        }

        /// <summary>
        /// Close the window and return to the login Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Open the modify profile window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            ModifyProfile modWin = new ModifyProfile(connection, admin.ID);
            modWin.Show();
        }
    }
}