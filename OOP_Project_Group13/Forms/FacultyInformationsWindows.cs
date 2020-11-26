using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace OOP_Project_Group13.Forms
{
    public partial class FacultyInformationsWindows : Form
    {
        MySqlConnection connection;
        Faculty Teacher;
        string status;
        public FacultyInformationsWindows(MySqlConnection _connection, Faculty _Teacher, string _status)
        {
            InitializeComponent();
            connection = _connection;
            Teacher = _Teacher;
            status = _status;
            TimeTable tt = new TimeTable(Teacher, panelTT, status);
            tt.InitializeTimeTable();
            tt.GetTimetable();
        }

        private void FacultyInformationsWindows_Load(object sender, EventArgs e)
        {
            if(status == "Admin")
            {
                ModifyBtn.Hide();
            }
            panelTT.Enabled = false;
            panelTT.Hide();
            classesPanel.Enabled = false;
            TeacherName.Text = Teacher.firstName + " " + Teacher.name;
            teacherID.Text = "ID : " + Teacher.ID.ToString();
            TeacherMail.Text = "Mail : " + Teacher.mail;
            if(Teacher.phone == "0000000000")
            {
                TeacherPhone.Text = "Phone : Not yet entered";
            }
            else
            {
                TeacherPhone.Text = "Phone : " + Teacher.phone;
            }
            teacherPicture.ImageLocation = Teacher.profilePicture;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM users WHERE userID = '" + Teacher.ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            connection.Open();
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User deleted successfully !");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelTT.Enabled = false;
            panelTT.Hide();
            classesPanel.Enabled = true;
            classesPanel.Show();
            ShowClasses();
        }

        private void ShowClasses()
        {
            String query = "Select className from users Where userID = '" + Teacher.ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable classes = new DataTable();
            SDA.Fill(classes);
            if (classes.Rows.Count > 0)
            {
                string[] classesTab = classes.Rows[0]["className"].ToString().Split(' ');
                int y = 50;
                for (int i = 0; i < classesTab.Length; i++)
                {
                    string name = classesTab[i];
                    ButtonClass classButton = new ButtonClass(name);
                    classButton.Text = "Class " + name;
                    classButton.Location = new System.Drawing.Point(0, y);
                    classesPanel.Controls.Add(classButton);
                    y += 25;
                    classButton.Click += new EventHandler(classButton_Click);
                }
            }
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text ="M. " + Teacher.name + " has " + (classes.Rows.Count + 1) + " classes : ";
            lbl.Location = new System.Drawing.Point(0, 25);
            classesPanel.Controls.Add(lbl);
        }

        private void ttBtn_Click(object sender, EventArgs e)
        {
            panelTT.Enabled = true;
            panelTT.Show();
            classesPanel.Enabled = false;
            classesPanel.Hide();
        }

        private void AttendanceBtn_Click(object sender, EventArgs e)
        {
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            ButtonClass classBtn = sender as ButtonClass;
            Class group = new Class(classBtn.name);
            if(status == "Teacher")
            {
                ManageClassWindow manageClass = new ManageClassWindow(group, connection, false);
                manageClass.Show();
            }
            else
            {
                ManageClassWindow manageClass = new ManageClassWindow(group, connection, true);
                manageClass.Show();
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            ModifyProfile modWin = new ModifyProfile(connection, Teacher.ID);
            modWin.Show();
        }
    }
}