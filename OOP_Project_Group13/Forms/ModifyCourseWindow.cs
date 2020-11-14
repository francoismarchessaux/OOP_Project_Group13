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
        Faculty teacher;
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
            subjectLbl.Text = $"Subject : {course.name}";
            teacherLbl.Text = course.teacher;
        }
    }
}
