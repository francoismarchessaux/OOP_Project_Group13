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
        bool status;
        public ManageClassWindow(Class _class, MySqlConnection _connection, bool _status)
        {
            InitializeComponent();
            group = _class;
            connection = _connection;
            status = _status;
        }

        /// <summary>
        /// Initialize the window with all the students in the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageClassWindow_Load(object sender, EventArgs e)
        {
            classNameLabel.Text = "Class Name : " + group.name;
            for (int i = 0; i < group.students.Count; i++)
                dataGridView1.Rows.Add(group.students[i].ID, group.students[i].name, group.students[i].firstName);
        }

        /// <summary>
        /// Open the create course window when the user click on the create course window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CreateCourse createCoursewin = new CreateCourse(connection, group.name);
            createCoursewin.Show();
        }

        /// <summary>
        /// Open the modify course window when the users click on the right button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyCourseBtn_Click(object sender, EventArgs e)
        {
            CreateCourse createCoursewin = new CreateCourse(connection, group.name);
            createCoursewin.Show();
        }

        /// <summary>
        /// Display the timetable of the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimetableBtn_Click(object sender, EventArgs e)
        {
            TimeTablePnl.Visible = true;
            dataGridView1.Visible = false;
            TimeTable classTimetable = new TimeTable(group.students[0], TimeTablePnl, "Admin");
            classTimetable.InitializeTimeTable();
            classTimetable.GetTimetable();
        }

        /// <summary>
        /// Display the list of students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            TimeTablePnl.Visible = false;
        }

        /// <summary>
        /// Open the create exam window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateExam_Click_1(object sender, EventArgs e)
        {
            CreateExam createExamwin = new CreateExam(connection, group);
            createExamwin.Show();
        }

        /// <summary>
        /// Open the submit grades window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            AddGrade2 SubmitGrade = new AddGrade2(connection, group);
            SubmitGrade.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Close the running window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Delete the class from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM class WHERE className = '" + group.name + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            connection.Open();
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Class deleted successfully !");
            Close();
        }

        /// <summary>
        /// Refresh the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            TimeTablePnl.Visible = false;
            Refresh();
            dataGridView1.Visible = true;
        }
    }
}
