using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13.Users
{
    public class Student : User
    {
        MySqlConnection con = Program.GetConnection();

        #region attributes
        public string tutor { get; set; }
        public List<Grade> gradesList { get; set; }
        public Attendance attendances { get; set; }
        public TimeTable timetable { get; set; }
        public Class studentClass { get; set; }
        public int fees { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }
        #endregion

        #region constructors
        public Student(int Id)
        {
            String query = "SELECT * FROM users WHERE userID='" + Id + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            string[] info = new string[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                info[i] = dt.Rows[0][i].ToString();
            ID = Convert.ToInt32(info[0]);
            name = info[1];
            firstName = info[2];
            status = info[3];
            password = info[4];
            mail = info[5];
            profilePicture = info[6];
            birthday = Convert.ToDateTime(info[7]);
            phone = info[8];
            address = info[9];
            attendances = new Attendance(this);
            studentClass = new Class(Id);
        }
        #endregion

        #region methods
        private void PlaceGrade(PanelCourse course, Grade grade)
        {
            Label gradeName = new Label();
            gradeName.Text = grade.NomCC;
            gradeName.AutoSize = true;
            Label note = new Label();
            note.Text = "" + grade.Note;
            note.AutoSize = true;
            LabelGrade addGrade = new LabelGrade(gradeName, note);
            course.grades.Add(addGrade);
            course.Controls.Add(addGrade.name);
            course.Controls.Add(addGrade.grade);
            int count = course.grades.Count;
            int y;
            if (count == 0)
                y = 40;
            else
                y = 30 * count;
            addGrade.name.Location = new Point(200, y);
            addGrade.grade.Location = new Point(900, y);
            addGrade.name.Visible = true;
            addGrade.grade.Visible = true;
            course.Height += 20;
        }
        private PanelCourse AddCourse(Panel generalPanel, Average avg, List<PanelCourse> listCourses)
        {
            Label courseName = new Label();
            Label averageLabel = new Label();
            Label average = new Label();
            List<LabelGrade> grades = new List<LabelGrade>();
            PanelCourse newPan = new PanelCourse(courseName, averageLabel, average, grades);
            newPan.Height = 70;
            newPan.Width = 930;
            int x = 0;
            int y;
            int max = 0;
            foreach (Control c in generalPanel.Controls)
            {
                if (c is Panel && c.Location.Y > max)
                    max = c.Location.Y + c.Height;
            }
            y = max + 10;
            generalPanel.Controls.Add(newPan);
            Panel title = new Panel();
            title.Height = 30;
            title.Width = 930;
            title.BackColor = Color.LightSlateGray;
            newPan.Location = new Point(x, y);
            courseName.Text = avg.subject.name;
            courseName.AutoSize = true;
            courseName.Visible = true;
            title.Controls.Add(courseName);
            courseName.Location = new Point(10, 10);
            averageLabel.Text = "Average : ";
            averageLabel.AutoSize = true;
            averageLabel.Visible = true;
            title.Controls.Add(averageLabel);
            averageLabel.Location = new Point(850, 10);
            double mean = avg.GetAverage();
            average.Text = "" + mean;
            average.AutoSize = true;
            average.Visible = true;
            title.Controls.Add(average);
            average.Location = new Point(900, 10);
            newPan.Controls.Add(title);
            listCourses.Add(newPan);
            return newPan;
        }
        public void GetGrades(Panel panel)
        {
            String query = "SELECT * FROM grade WHERE studentID='" + ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            List<PanelCourse> listCourses = new List<PanelCourse>();
            List<Average> subjects = new List<Average>();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (subjects.Count == 0)
                    {
                        Subject subject = new Subject(row["Subject"].ToString());
                        Grade grade = new Grade(Convert.ToInt32(row["studentGrade"].ToString()), row["AssesmentName"].ToString(), Convert.ToInt32(row["coefficient"].ToString()), subject);
                        List<Grade> grades = new List<Grade>();
                        grades.Add(grade);
                        Average avg = new Average(subject, grades);
                        subjects.Add(avg);
                    }
                    else
                    {
                        bool subjExist = false;
                        Average avg = null;
                        for (int i = 0; i < subjects.Count; i++)
                        {
                            Subject subject = new Subject(row["Subject"].ToString());
                            if (subject.name.Equals(subjects[i].subject.name))
                            {
                                subjExist = true;
                                avg = subjects[i];
                            }
                        }
                        if (subjExist == true)
                        {
                            Grade grade = new Grade(Convert.ToInt32(row["studentGrade"].ToString()), row["AssesmentName"].ToString(), Convert.ToInt32(row["coefficient"].ToString()), avg.subject);
                            avg.grades.Add(grade);
                        }
                        else
                        {
                            Subject subject = new Subject(row["Subject"].ToString());
                            Grade grade = new Grade(Convert.ToInt32(row["studentGrade"].ToString()), row["AssesmentName"].ToString(), Convert.ToInt32(row["coefficient"].ToString()), subject);
                            List<Grade> grades = new List<Grade>();
                            grades.Add(grade);
                            avg = new Average(subject, grades);
                            subjects.Add(avg);
                        }

                    }
                }
                for (int i = 0; i < subjects.Count; i++)
                {
                    PanelCourse course = AddCourse(panel, subjects[i], listCourses);
                    for (int j = 0; j < subjects[i].grades.Count; j++)
                    {
                        PlaceGrade(course, subjects[i].grades[j]);
                    }
                }
            }
        }
        public void FeesPanel(Panel panel, string _status)
        {
            String query = "SELECT * FROM users WHERE userID ='" + ID + "' AND status ='Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            Label Status = new Label();
            Label FeesPaid = new Label();
            Label FeesLeft = new Label();
            Label Txt = new Label();

            PanelFees newPan = new PanelFees(Status, FeesPaid, FeesLeft);
            newPan.Height = 200;
            newPan.Width = 930;
            newPan.Location = new Point(0, 30);

            Panel title = new Panel();
            title.Height = 30;
            title.Width = 930;
            title.BackColor = Color.LightSlateGray;            
            Txt.Text = "TUITION FEES ";            
            title.Controls.Add(Txt);
            panel.Controls.Add(title);
            Txt.Location = new Point(5, 11);

            if (Convert.ToDouble(dt.Rows[0]["fees"]) > 0.00 )
            {
                if (status == "admin")
                {
                    Status.Text = " The student " + dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["firstName"].ToString() + " has an outstanding balance of " + dt.Rows[0]["fees"].ToString() + "£.";
                }
                else
                {
                    Status.Text = dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["firstName"].ToString() + ", you have an outstanding balance of " + dt.Rows[0]["fees"].ToString() + "£.";
                }
                
                Status.AutoSize = true;
                Status.Visible = true;
            }

            else
            {
                if (status == "admin")
                {
                    Status.Text = " The student " + dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["firstName"].ToString() + " has already paid the tuition fees for the year.";
                }
                else
                {
                    Status.Text = dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["firstName"].ToString() + ", you have already paid the tuiton fees for the year.";
                }                
                Status.AutoSize = true;
                Status.Visible = true;
            }

            newPan.Controls.Add(Status);
            Status.Location = new Point(20, 10);

            FeesPaid.Text = "Fees already paid : " + dt.Rows[0]["feesPaid"].ToString() + "£.";
            FeesPaid.AutoSize = true;
            FeesPaid.Visible = true;
            newPan.Controls.Add(FeesPaid);
            FeesPaid.Location = new Point(40, 40);

            FeesLeft.Text = "Amount left to pay : " + dt.Rows[0]["fees"].ToString() + "£.";
            FeesLeft.AutoSize = true;
            FeesLeft.Visible = true;
            newPan.Controls.Add(FeesLeft);
            FeesLeft.Location = new Point(40, 70);

            panel.Controls.Add(newPan);
          
        }

        public void PanelPayment(Panel panel)
        {
            String query = "SELECT * FROM users WHERE userID ='" + ID + "' AND status ='Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            Label Name = new Label();
            Label Intro = new Label();

            Panel Payment = new Panel();
            Payment.Height = 30;
            Payment.Width = 930;
            Payment.BackColor = Color.LightSlateGray;

            Name.Text = dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["firstName"].ToString();
            Intro.Text = "Payment of the tuitions fees of : ";
            Intro.AutoSize = true;
            Intro.Visible = true;

            Payment.Controls.Add(Name); Payment.Controls.Add(Intro);
            Name.Location = new Point(180, 7);
            Intro.Location = new Point(5, 7);

            panel.Controls.Add(Payment);
        }
        #endregion
    }
}
