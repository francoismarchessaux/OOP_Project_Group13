﻿using OOP_Project_Group13.Forms;
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
    public partial class AdministratorMainWindow : Form
    {
        SqlConnection connection;
        public AdministratorMainWindow(string fullName, int ID, string link, SqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            AdminName_Label.Text = fullName;
            AdminID_Label.Text = ID.ToString();
            AdminPP_PictureBox.ImageLocation = link;
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentWindow studentCreationWindow = new CreateStudentWindow(connection, "Student");
            studentCreationWindow.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] studentInfo = this.StudentList.Text.Split(' ');
            String query = "Select * from [Users] Where userID = '" + studentInfo[2] + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable studentTable = new DataTable();
            SDA.Fill(studentTable);
            Student selectedStudent = new Student(studentTable.Rows[0]["name"].ToString(), studentTable.Rows[0]["firstName"].ToString(), studentTable.Rows[0]["status"].ToString(), studentTable.Rows[0]["password"].ToString(), Convert.ToInt32(studentTable.Rows[0]["userID"]), studentTable.Rows[0]["mail"].ToString(), studentTable.Rows[0]["phone"].ToString(), studentTable.Rows[0]["profilePicture"].ToString(), Convert.ToDateTime(studentTable.Rows[0]["birthday"]), studentTable.Rows[0]["address"].ToString());
            StudentInformationsWindow studentInfoWin = new StudentInformationsWindow(connection, selectedStudent);
            studentInfoWin.Show();
        }

        private void AdministratorMainWindow_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.database1DataSet.Users);
            String query = "Select name, firstName, userID from [Users] Where status = 'Student'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            for(int i = 0; i < userTable.Rows.Count; i++)
            {
                this.StudentList.Items.Add(userTable.Rows[i]["name"].ToString() + " " + userTable.Rows[i]["firstName"].ToString() + " " + userTable.Rows[i]["userID"].ToString());
            }
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            CreateCourse ccWin = new CreateCourse(connection);
            ccWin.Show();
        }

        private void TeacherList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CreateTeacherBtn_Click(object sender, EventArgs e)
        {
            CreateStudentWindow studentCreationWindow = new CreateStudentWindow(connection, "Faculty");
            studentCreationWindow.Show();
        }
    }
}
