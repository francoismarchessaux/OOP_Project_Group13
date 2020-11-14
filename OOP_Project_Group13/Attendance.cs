using MySqlConnector;
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
    public class Attendance
    {
        MySqlConnection connection = Program.GetConnection();
        List<AttendanceCourse> attendance { get; set; }
        public Attendance(List<AttendanceCourse> attendance)
        {
            this.attendance = attendance;
        }
        
        public void AddCourse (AttendanceCourse att,Panel generalPanel)
        {
            Label courseName = new Label();
            Label attendanceRate = new Label();
            Label attendanceNum = new Label();
            PanelCourse newPan = new PanelCourse(courseName,attendanceRate,attendanceNum) ;
            newPan.Height = 70;
            newPan.Width = 910;
            int x = 0;
            int y = 10;
            int max = -10;
            foreach (Control c in generalPanel.Controls)
            {
                if (c is Panel && c.Location.Y > max)
                    max = c.Location.Y + c.Height;
            }
            y = max + 10;
            generalPanel.Controls.Add(newPan);
            newPan.Location = new Point(x, y);
            Panel title = new Panel();
            title.Height = 30;
            title.Width = 930;
            title.BackColor = Color.LightSlateGray;
            courseName.Text = att.subject.name;
            courseName.AutoSize = true;
            courseName.Visible = true;
            title.Controls.Add(courseName);
            courseName.Location = new Point(10, 10);
            attendanceNum.Text = GetAttendance(att.subject.name)+"/"+att.attendance.Length*2;
            attendanceNum.AutoSize = true;
            attendanceNum.Visible = true;
            title.Controls.Add(attendanceNum);
            attendanceNum.Location = new Point(840, 10);
            double rate = GetAttendanceRate(att.subject.name);
            attendanceRate.Text = rate+"%";
            attendanceRate.AutoSize = true;
            attendanceRate.Visible = true;
            title.Controls.Add(attendanceRate);
            newPan.Controls.Add(title);
            title.Location = new Point(0, 0);
            attendanceRate.Location = new Point(870, 10);
            int count = 0;
            for (int i = 0; i < att.attendance.Length; i++)
            {
                Label course = new Label();
                course.Text = att.course[i];
                course.AutoSize = true;
                Label attNum = new Label();
                attNum.Text = att.attendance[i] + "/2";
                attNum.AutoSize = true;
                LabelGrade addAtt = new LabelGrade(course, attNum);
                count++;
                y = 30 * count;
                addAtt.name.Location = new Point(200, y);
                addAtt.grade.Location = new Point(870, y);
                addAtt.name.Visible = true;
                addAtt.grade.Visible = true;
                newPan.Height += 22;
                newPan.Controls.Add(addAtt.name);
                newPan.Controls.Add(addAtt.grade);
            }
        }
        public void GetGrades(string studentID,Panel panel)
        {
            String query = "SELECT * FROM attendance WHERE studentID='" + studentID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Subject subject = new Subject(row["Subject"].ToString());
                    string att = row["Attendance"].ToString();
                    string[] attendancesString = att.Split(' ');
                    int[] attendances = new int[attendancesString.Length];
                    for (int i = 0; i < attendancesString.Length; i++)
                        attendances[i] = Convert.ToInt32(attendancesString[i]);
                    string[] name = new string[attendances.Length];
                    for (int i = 0; i < attendances.Length; i++)
                    {
                        name[i] = subject.name + " " +i;
                    }
                    AttendanceCourse course = new AttendanceCourse(subject, attendances, name);
                    attendance.Add(course);
                }
                for (int i = 0; i < attendance.Count; i++)
                    AddCourse(attendance[i],panel);
            }
        }
        private int GetIndexOfCourse(string name)
        {
            int index =0;
            bool find = false;
            while (index < attendance.Count && find == false)
            {
                if (attendance[index].subject.name == name)
                    find = true;
                index++;
            }
            return index-1;
        }
        private double GetAttendanceRate(string name)
        {
            double rate = 0;
            int index = GetIndexOfCourse(name);
            for (int i = 0; i < attendance[index].attendance.Length; i++)
                rate += attendance[index].attendance[i];
            rate =Math.Round(rate*100/ (attendance[index].attendance.Length * 2),2);
            return rate;
        }
        private int GetAttendance(string name)
        {
            int sum = 0;
            int index = GetIndexOfCourse(name);
            for (int i = 0; i < attendance[index].attendance.Length; i++)
                sum += attendance[index].attendance[i];
            return sum;
        }
    }
}
