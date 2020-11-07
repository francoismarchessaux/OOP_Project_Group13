﻿using MySqlConnector;
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
    public partial class CreateCourse : Form
    {
        MySqlConnection connection;
        string groupName;
        public CreateCourse(MySqlConnection _connection, string _groupName)
        {
            InitializeComponent();
            connection = _connection;
            groupName = _groupName;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string subject = SubjectList.Text;
            string teacher = TeacherList.Text;
            string day = DayList.Text;
            string time = TimeList.Text;
            String query = "SELECT * from Course WHERE Teacher = '" + teacher + "' AND Day = '" + day + "' AND Time = '" + time + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable teacherTable = new DataTable();
            SDA.Fill(teacherTable);
            if(teacherTable.Rows.Count == 1)
            {
                MessageBox.Show("This teacher already has a course at this time (Course : " + teacherTable.Rows[0]["Subject"] + ")");
            }
            else
            {
                //query = "SELECT * from Course WHERE Group = '" + groupName + "' AND Day = '" + day + "' AND Time = '" + time + "'";
                //SDA = new MySqlDataAdapter(query, connection);
                //DataTable groupTable = new DataTable();
                //SDA.Fill(groupTable);
                //if(groupTable.Rows.Count == 1)
                //{
                //    MessageBox.Show("This group already has a course at this time (Course : " + groupTable.Rows[0]["Subject"] + ")");
                //}
                //else 
                //{
                //    connection.Open();
                //    query = "INSERT INTO Course (Subject, Teacher, Day, Time, Group) VALUES ('" + subject + "', '" + teacher + "', '" + day + "','" + time + "','" + groupName + "')";
                //    SDA = new MySqlDataAdapter(query, connection);
                //    SDA.SelectCommand.ExecuteNonQuery();
                //    connection.Close();
                //    MessageBox.Show("Course created succesfully !");
                //    this.Hide();
                //}
            }
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {
            String query = "Select name, firstName, userID from Users Where status = 'Faculty'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable TeacherTable = new DataTable();
            SDA.Fill(TeacherTable);
            for (int i = 0; i < TeacherTable.Rows.Count; i++)
            {
                this.TeacherList.Items.Add(TeacherTable.Rows[i]["name"].ToString() + " " + TeacherTable.Rows[i]["firstName"].ToString() + " " + TeacherTable.Rows[i]["userID"].ToString());
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
