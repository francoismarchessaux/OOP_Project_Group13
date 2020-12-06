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

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13.Forms
{
    public partial class ModifyCourseWindow : Form
    {
        MySqlConnection connection;
        Course course;
        public ModifyCourseWindow(MySqlConnection _connection, Course _course)
        {
            InitializeComponent();
            connection = _connection;
            course = _course;
        }
        /// <summary>
        /// Adds the name, first name and ID of all teachers to the TeacherList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyCourseWindow_Load(object sender, EventArgs e)
        {
            String query = "Select name, firstName, userID from Users Where status = 'Faculty'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable TeacherTable = new DataTable();
            SDA.Fill(TeacherTable);
            for (int i = 0; i < TeacherTable.Rows.Count; i++)
            {
                this.TeacherList.Items.Add(TeacherTable.Rows[i]["name"].ToString() + " " + TeacherTable.Rows[i]["firstName"].ToString() + " " + TeacherTable.Rows[i]["userID"].ToString());
            }
            TeacherList.SelectedItem = course.teacher;
            TimeList.SelectedItem = course.time;
            DayList.SelectedItem = course.day;
            subjectLbl.Text = $"Subject : {course.name}";
        }
        /// <summary>
        /// Close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Modifies the course selected by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            String query = "Select number from course Where Subject = '" + course.name + "' AND teacher = '" + course.teacher + "' AND Day = '" + course.day + "' AND Time = '" + course.time + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable courseInfo = new DataTable();
            SDA.Fill(courseInfo);
            string teacher = TeacherList.Text;
            string time = TimeList.Text;
            string day = DayList.Text;
            connection.Open();
            query = "UPDATE course SET teacher = '" + teacher + "', day = '" + day + "', time = '" + time + "' WHERE(number = '" + courseInfo.Rows[0]["number"] + "')";
            SDA = new MySqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course modified successfully !");
            this.Close();
        }
        /// <summary>
        /// Deletes the course selected by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM course WHERE Subject = '" + course.name + "' AND teacher = '" + course.teacher + "' AND Time = '" + course.time + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            connection.Open();
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course deleted successfully !");
            this.Close();
        }
    }
}
