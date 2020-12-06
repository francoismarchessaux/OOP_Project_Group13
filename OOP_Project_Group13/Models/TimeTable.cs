using MySqlConnector;
using OOP_Project_Group13.Forms;
using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13
{
    public class TimeTable
    {
        #region attributes
        User user;
        MySqlConnection connection = Program.GetConnection();
        Panel timetable;
        string status;
        #endregion

        #region constructors
        public TimeTable(User user, Panel timetable)
        {
            this.user = user;
            this.timetable = timetable;
        }
        public TimeTable(User user, Panel timetable, string _status)
        {
            this.user = user;
            this.timetable = timetable;
            status = _status;
        }
        #endregion

        #region methods

        /// <summary>
        /// Method that displays a empty timetable, with every course hidenn
        /// </summary>
        public void InitializeTimeTable()
        {
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int[] hour = { 8, 1, 4 };
            int y = 65;
            for (int j = 0; j < hour.Length; j++)
            {
                Label label = new Label();
                label.Name = "label" + hour[j];
                label.Text = hour[j] + ":00";
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Location = new Point(12, y);
                if (j == 0)
                    y += 100;
                else
                    y += 80;
                timetable.Controls.Add(label);
            }
            int x = -75;
            for (int i = 0; i < week.Length; i++)
            {
                Label l = new Label();
                l.Name = week[i];
                l.Text = week[i];
                l.Height = 20;
                l.Width = 87;
                l.TextAlign = ContentAlignment.MiddleCenter;
                x += 150;
                y = 23;
                l.Location = new Point(x, y);
                y = 65;
                timetable.Controls.Add(l);
                int[] tab = { 8, 1, 4 };
                for (int j = 0; j < 3; j++)
                {
                    ButtonClass label = new ButtonClass();
                    label.Name = "" + week[i][0] + week[i][1] + week[i][2] + tab[j];
                    label.Height = 55;
                    label.Width = 87;
                    label.Location = new Point(x, y);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Visible = false;
                    if (j == 0)
                        y += 100;
                    else
                        y += 80;
                    timetable.Controls.Add(label);
                    label.Click += new EventHandler(label_Click);
                }
            }
        }

        /// <summary>
        /// Method that shows the courses of a student in the previous empty timetable
        /// </summary>
        public void GetTimetable()
        {
            String query = "";
            if(user is Student)
            {
                Student student = (Student)user;
                query = "SELECT * FROM Course WHERE Class='" + student.studentClass.name + "'";
            }
            else
            {
                Faculty teacher = (Faculty)user;
                string teacherSelect = teacher.name + " " + teacher.firstName + " " + teacher.ID;
                query = "SELECT * FROM Course WHERE Teacher ='" + teacherSelect + "' ";
            }
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string day = dt.Rows[i]["Day"].ToString();
                    string hour = dt.Rows[i]["Time"].ToString();
                    string name = dt.Rows[i]["Subject"].ToString();
                    string labelName = "" + day[0] + day[1] + day[2] + hour[0];
                    Class _class = new Class(dt.Rows[i]["Class"].ToString());
                    Course course = new Course(name, dt.Rows[i]["Teacher"].ToString(), "normal", day, hour, _class);
                    foreach (Control x in timetable.Controls)
                    {
                        if (x is ButtonClass)
                        {
                            ButtonClass button = (ButtonClass)x;
                            string n = x.Name;
                            if (labelName == n)
                            {
                                x.Visible = true;
                                x.Text = name;
                                button.course = course;
                            }
                        }
                    }
                }
            }

        }

        /// <summary>
        /// Method that open a window based on who press the button of a course (ModifyCourse for the admin, Attendace for the Faculty, Incoming assesment for the Student) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, System.EventArgs e)
        {
            if(status == "Admin")
            {
                ButtonClass b = sender as ButtonClass ;
                Course c = b.course;
                ModifyCourseWindow modifyWin = new ModifyCourseWindow(connection, c);
                modifyWin.Show();
            }
            else if(status == "Teacher")
            {
                ButtonClass b = sender as ButtonClass;
                Course c = b.course;
                AttendanceForm attendance = new AttendanceForm(connection, c);
                attendance.Show();
            }
            else if (status == "Student")
            {
                ButtonClass b = sender as ButtonClass;
                Course c = b.course;
                String query =" SELECT * FROM grade WHERE studentID='"+user.ID+"' AND Subject ='"+c.name+"'";
                DataTable dt = new DataTable();
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
                SDA.Fill(dt);
                string assesment = "";
                for(int i =0; i < dt.Rows.Count; i++)
                {
                    DateTime date = Convert.ToDateTime(dt.Rows[i]["Date"].ToString());
                    assesment += date.ToString("yyyy-MM-dd")+": "+dt.Rows[i]["AssesmentName"].ToString()+"\n";
                }
                if (assesment == "")
                    assesment = "There is no assesment yet in this subject.";
                MessageBox.Show(assesment);
            }
        }
        #endregion
    }
}
