using MySqlConnector;
using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            String verify = "SELECT * FROM attendance WHERE StudentID='" + course.courseClass.students[0].ID + "' AND Subject ='" + course.name + "'";
            MySqlDataAdapter SDAVerify = new MySqlDataAdapter(verify, connection);
            DataTable dtVerify = new DataTable();
            SDAVerify.Fill(dtVerify);
            string lastDate = dtVerify.Rows[0]["LastChange"].ToString();
            if (_course.day != DateTime.Now.DayOfWeek.ToString()||lastDate==DateTime.Now.ToString("yyyy/MM/dd"))
            {
                buttonValidate.Enabled = false;
                buttonModify.Enabled = true;
                foreach (Control c in panelAttendance.Controls)
                {
                    if (c is PanelCourse)
                    {
                        PanelCourse p = (PanelCourse)c;
                        String studentInfo = "SELECT * FROM attendance WHERE StudentID='" + p.name.Text.Split(' ')[2] + "' AND Subject ='" + course.name + "'";
                        MySqlDataAdapter SDA = new MySqlDataAdapter(studentInfo, connection);
                        DataTable dt = new DataTable();
                        SDA.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            string[] attendance = dt.Rows[0]["Attendance"].ToString().Split(' ');
                            int lastAtt = Convert.ToInt32(attendance[attendance.Length - 1]);
                            if (lastAtt == 1)
                            {
                                p.check.Checked = true;
                                p.status.Text = "Late";
                                p.late.Checked = true;
                            }
                            if (lastAtt == 2)
                            {
                                p.check.Checked = true;
                                p.status.Text = "Present";
                            }
                        }
                    }
                }
            }
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
                check.Location = new Point(380, 10);
                check.Visible = true;
                check.AutoSize = true;
                Label lateLabel = new Label();
                lateLabel.Text = "Late :";
                lateLabel.AutoSize = true;
                lateLabel.Location = new Point(450, 10);
                CheckBox late = new CheckBox();
                late.Location = new Point(500, 5);
                int max = -70;
                foreach(Control c in panelAttendance.Controls)
                {
                    if (c is Panel && c.Location.Y > max)
                        max = c.Location.Y;
                }
                int y = max + 70;
                PanelCourse student = new PanelCourse(name,attendance,check,lateLabel,late);
                student.Height = 70;
                student.Width = 520;
                student.Name = ""+students[i].ID;
                panelAttendance.Controls.Add(student);
                student.Location = new Point(0, y);
            }
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            connection.Open();
            foreach(Control c in panelAttendance.Controls)
            {
                if(c is PanelCourse)
                {
                    PanelCourse p = (PanelCourse)c;
                    int att = 0;
                    if (p.check.Checked == true)
                    {
                        p.status.Text = "Présent";
                        att = 2;
                    }
                    if (p.late.Checked == true && p.check.Checked == true)
                    {
                        p.status.Text = "Late";
                        att = 1;
                    }
                    string info = p.name.Text;
                    string ID = info.Split(' ')[2];
                    string name = course.name;
                    String studentInfo = "SELECT * FROM attendance WHERE StudentID='" + ID + "' AND Subject ='" + name + "'";
                    MySqlDataAdapter SDA = new MySqlDataAdapter(studentInfo, connection);
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);
                    String query;
                    if (dt.Rows.Count == 0)
                    {
                        query = "INSERT INTO attendance (StudentID,Subject,Attendance,LastChange) VALUES ('" + ID + "','" + name + "','"+att+"','"+DateTime.Today.ToString("yyyy/MM/dd")+"')";
                    }
                    else
                    {
                        string idAttendance = dt.Rows[0][0].ToString();
                        string attendance = dt.Rows[0]["Attendance"].ToString() + " "+att;
                        query = "UPDATE attendance SET Attendance='" + attendance + "', LastChange='" + DateTime.Today.ToString("yyyy/MM/dd") + "' WHERE idAttendance='" + idAttendance + "'";
                    }
                    MySqlDataAdapter uptade = new MySqlDataAdapter(query, connection);
                    uptade.SelectCommand.ExecuteNonQuery();
                }
            }
            buttonValidate.Enabled = false;
            buttonModify.Enabled = true;
            connection.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            connection.Open();
            foreach (Control c in panelAttendance.Controls)
            {
                if (c is PanelCourse)
                {
                    PanelCourse p = (PanelCourse)c;
                    int att = 0;
                    if (p.check.Checked == true && p.late.Checked==false)
                    {
                        p.status.Text = "Présent";
                        att = 2;
                    }
                    else if (p.late.Checked == true && p.check.Checked==true)
                    {
                        p.status.Text = "Late";
                        att = 1;
                    }
                    else
                        p.status.Text = "Absent";
                    string info = p.name.Text;
                    string ID = info.Split(' ')[2];
                    string name = course.name;
                    String studentInfo = "SELECT * FROM attendance WHERE StudentID='" + ID + "' AND Subject ='" + name + "'";
                    MySqlDataAdapter SDA = new MySqlDataAdapter(studentInfo, connection);
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);
                    string idAttendance = dt.Rows[0][0].ToString();
                    string[] attendance = dt.Rows[0]["Attendance"].ToString().Split(' ');
                    attendance[attendance.Length - 1] = "" + att;
                    string newAttendance = "";
                    for (int i = 0; i < attendance.Length; i++)
                    {
                        if (i == 0)
                            newAttendance += attendance[0];
                        else
                            newAttendance += " " + attendance[i];
                    }
                    String query = "UPDATE attendance SET Attendance='" + newAttendance + "', LastChange='" + DateTime.Today.ToString("yyyy-MM-dd") + "' WHERE idAttendance='" + idAttendance + "'";
                    MySqlDataAdapter uptade = new MySqlDataAdapter(query, connection);
                    uptade.SelectCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
    }
}
