using MySqlConnector;
using OOP_Project_Group13.Users;
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
    public partial class AttendanceForm : Form
    {
        MySqlConnection connection;
        Course course;
        public AttendanceForm(MySqlConnection con,Course _course)
        {
            InitializeComponent();
            connection = con;
            course = _course;
            GetListStudents();
            labelName.Text = course.name + " " + course.courseClass.name;
        }
        public void GetListStudents()
        {
            List<Student> students = course.courseClass.students;
            for (int i = 0; i < students.Count; i++)
            {
                
                Label name = new Label();
                name.Text = students[i].name.ToUpper() + " " + students[i].firstName + " " + students[i].ID;
                name.Location = new Point(10, 10);
                name.AutoSize = true;
                Label attendance = new Label();
                attendance.Text = "Absent";
                attendance.AutoSize = true;
                attendance.Location = new Point(300, 10);
                CheckBox check = new CheckBox();
                check.Location = new Point(380, 5);
                check.Visible = true;
                int max = -70;
                foreach(Control c in panelAttendance.Controls)
                {
                    if (c is Panel && c.Location.Y > max)
                        max = c.Location.Y;
                }
                int y = max + 70;
                PanelCourse student = new PanelCourse(name,attendance,check);
                student.Height = 70;
                student.Width = 520;
                student.Name = ""+students[i].ID;
                panelAttendance.Controls.Add(student);
                student.Location = new Point(0, y);
            }
        }

        //private void buttonValidate_Click(object sender, EventArgs e)
        //{
        //    foreach (Control c in panelAttendance.Controls)
        //    {
        //        if (c is PanelCourse)
        //        {
        //            PanelCourse p = (PanelCourse)c;
        //            if (p.Controls.)
        //        }

        //    }
        //}
    }
}
