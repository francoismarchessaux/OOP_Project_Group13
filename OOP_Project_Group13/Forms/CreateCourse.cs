using MySqlConnector;
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
        /// <summary>
        /// The Admin/Teacher enters the information of a new course
        /// The programm studies if it's possible to create this course (no other courses at the same time)
        /// If it's possible, the course is added to the Course database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("This teacher already has a course at this time (Course : " + teacherTable.Rows[0]["Subject"] + " with class " + teacherTable.Rows[0]["class"] + ")");
            }
            else
            {
                query = "SELECT * from Course WHERE Class = '" + groupName + "' AND Day = '" + day + "' AND Time = '" + time + "'";
                SDA = new MySqlDataAdapter(query, connection);
                DataTable groupTable = new DataTable();
                SDA.Fill(groupTable);
                if (groupTable.Rows.Count == 1)
                {
                    MessageBox.Show("This group already has a course at this time (Course : " + groupTable.Rows[0]["Subject"] + ")");
                }
                else
                {
                    connection.Open();
                    query = "INSERT INTO Course (Subject, Teacher, Day, Time, Class) VALUES ('" + subject + "', '" + teacher + "', '" + day + "','" + time + "','" + groupName + "')";
                    SDA = new MySqlDataAdapter(query, connection);
                    SDA.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Course created successfully !");
                    this.Close();
                }
            }
        }
        /// <summary>
        /// Adds the name, first name and ID of all teachers to the TeacherList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.Close();
        }


    }
}
