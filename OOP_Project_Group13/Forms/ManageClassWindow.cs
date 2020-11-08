using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Project_Group13.Users;
using System.Windows;

namespace OOP_Project_Group13.Forms
{
    public partial class ManageClassWindow : Form
    {
        MySqlConnection connection;
        Class group;
        TimeTable tbl;
        public ManageClassWindow(Class _class, MySqlConnection _connection)
        {
            InitializeComponent();
            group = _class;
            connection = _connection;
        }

        private void ManageClassWindow_Load(object sender, EventArgs e)
        {
            classNameLabel.Text = "Class Name : " + group.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCourse createCoursewin = new CreateCourse(connection, group.name);
            createCoursewin.Show();
        }

        private void ModifyCourseBtn_Click(object sender, EventArgs e)
        {
            CreateCourse createCoursewin = new CreateCourse(connection, group.name);
            createCoursewin.Show();
        }

        private void TimetableBtn_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM Users WHERE userID='" + group.students[0] + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable studentInfos = new DataTable();
            SDA.Fill(studentInfos);
            string name = studentInfos.Rows[0]["className"].ToString();
            Class _class = new Class(name);
            TimeTable classTimetable = new TimeTable(new Student(studentInfos.Rows[0]["name"].ToString(), studentInfos.Rows[0]["firstName"].ToString(), studentInfos.Rows[0]["status"].ToString(), studentInfos.Rows[0]["password"].ToString(), Convert.ToInt32(studentInfos.Rows[0]["userID"]), studentInfos.Rows[0]["mail"].ToString(), studentInfos.Rows[0]["phone"].ToString(), studentInfos.Rows[0]["profilePicture"].ToString(), Convert.ToDateTime(studentInfos.Rows[0]["birthday"]), studentInfos.Rows[0]["address"].ToString(), _class), connection, TimeTablePnl, true);
            classTimetable.InitializeTimeTable();
            classTimetable.GetTimetable();
        }
    }
}
