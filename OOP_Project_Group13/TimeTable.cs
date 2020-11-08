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

namespace OOP_Project_Group13
{
    public class TimeTable
    {
        User user;
        MySqlConnection connection;
        Panel timetable;
        bool admin;
        public TimeTable(User user, MySqlConnection connection, Panel timetable)
        {
            this.user = user;
            this.connection = connection;
            this.timetable = timetable;
        }
        public TimeTable(User user, MySqlConnection connection, Panel timetable, bool _admin)
        {
            this.user = user;
            this.connection = connection;
            this.timetable = timetable;
            admin = _admin;
        }
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
                    Button label = new Button();
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
                query = "SELECT * FROM Course WHERE Class='" + teacher.Classes[0].name + "' ";
                for (int i = 1; i < teacher.Classes.Count; i++)
                {
                    query+="OR Class='"+teacher.Classes[i].name+"' ";
                }
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
                    foreach (Control x in timetable.Controls)
                    {
                        if (x is Button)
                        {
                            string n = x.Name;
                            if (labelName == n)
                            {
                                x.Visible = true;
                                x.Text = name;
                            }
                        }
                    }
                }
            }

        }

        private void label_Click(object sender, System.EventArgs e)
        {
            if(admin == true)
            {
                ModifyCourseWindow modifyWin = new ModifyCourseWindow();
                //modifyWin.label1.Text = sender
                //modifyWin.Show();
            }
        }
    }
}
