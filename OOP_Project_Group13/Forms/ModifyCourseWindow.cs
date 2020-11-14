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
            subjectLbl.Text = $"Subject : {course.name}";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            String query = "Select number from course Where Subject = '" + course.name + "' AND teacher = '" + course.teacher + "' AND Time = '" + course.time + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable courseInfo = new DataTable();
            SDA.Fill(courseInfo);
            string teacher = TeacherList.Text;
            string time = TimeList.Text;
            string type = TypeList.Text;
            connection.Open();
            query = "UPDATE course SET teacher = '" + teacher + "', time = '" + time + "', type = '" + type + "' WHERE(number = '" + courseInfo.Rows[0]["number"] + "')";
            SDA = new MySqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course modified successfully !");
            this.Close();
        }

    }
}
