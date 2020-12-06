using MySqlConnector;
using OOP_Project_Group13.Users;
using System;
using System.Data;
using System.Windows.Forms;

/*
23202 François Marchessaux
23410 Théotime Froget
22839 Louis Faverjon
23215 Victor Guy
23194 César Maurey
*/

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
            classesPanel.Hide();
            TimeTable tt = new TimeTable(Teacher, panelTT, status);
            tt.InitializeTimeTable();
            tt.GetTimetable();
        }

        /// <summary>
        /// Loads the window with all of the information of the teacher on the data table 
        /// Not every option is accessible depending on which person is connected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FacultyInformationsWindows_Load(object sender, EventArgs e)
        {
            if(status == "Admin")
            {
                ModifyBtn.Hide();
                LogOutBtn.Hide();
            }
            else
            {
                DeleteBtn.Hide();
            }
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
            if (Teacher.address == "Address")
            {
                labelAdress.Text = "Address : Not yet entered";
            }
            else
            {
                labelAdress.Text = "Address : " + Teacher.address;
            }
            teacherPicture.ImageLocation = Teacher.profilePicture;

            
            
            
            for (int i = 0; i < Teacher.Classes.Count; i++)
            {
                for (int j=0; j < Teacher.Classes[i].students.Count; j++)
                {
                   
                        this.comboBoxStudent.Items.Add(Teacher.Classes[i].students[j].name.ToString() + " " + Teacher.Classes[i].students[j].firstName.ToString() + " " + Teacher.Classes[i].students[j].ID.ToString());
                    
                }
                   
            }

            


        }

        /// <summary>
        /// Button only visible for the admin
        /// Offers the possibility to remove the teacher from the data table
        /// Therefore, this teacher no longer exists 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Button that calls the ShowClasses() function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            panelTT.Enabled = false;
            panelTT.Hide();
            classesPanel.Enabled = true;
            classesPanel.Show();
            ShowClasses();
        }

        /// <summary>
        /// Generates the list of classes of the teacher on the "general" panel
        /// A messag is shown if the teacher doesn't have a classe yet
        /// </summary>
        private void ShowClasses()
        {
            String query = "Select className from users Where userID = '" + Teacher.ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable classes = new DataTable();
            SDA.Fill(classes);
            if (classes.Rows.Count > 0)
            {
                string[] classesTab = classes.Rows[0]["className"].ToString().Split(' ');
                if(classesTab[0] != "")
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Location = new System.Drawing.Point(0, 25);
                    lbl.Text = "M. " + Teacher.name + " has " + (classesTab.Length) + " classes : ";
                    classesPanel.Controls.Add(lbl);
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
                }else
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Location = new System.Drawing.Point(0, 25);
                    lbl.Text = "M. " + Teacher.name + " has zero classes at the moment";
                    classesPanel.Controls.Add(lbl);
                }

            }
        }

        /// <summary>
        /// The timetable is shown when the window loads
        /// If the user decided to see the classes, which are displayed ont the same panel,
        /// then the timetable of the teacher will be generated again on the "general" panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Opens Manage Class Window and depending on the user (teacher/admin) the third parameter is either true or false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classButton_Click(object sender, EventArgs e)
        {
            panelTT.Hide();
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

        /// <summary>
        /// Open the Modify Profil Window for the connected teacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            ModifyProfile modWin = new ModifyProfile(connection, Teacher.ID);
            modWin.Show();
        }

        /// <summary>
        /// Closes the active window to get back to either the Administrator Main Window (if the admin is connected),
        /// the login Window (if the teacher is connected)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The combo-Box contains every student of the teacher
        /// After the teacher selects a student, it open the Student Information Window 
        /// If the teacher is the students's Tutor, it gets the same information of an admin on the student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] studentInfo = this.comboBoxStudent.Text.Split(' ');
            Student selectedStudent = new Student(Convert.ToInt32(studentInfo[2]));
           
            String query = "Select Tuteur from users Where userID = '" + studentInfo[2] + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable Tuteur = new DataTable();
            SDA.Fill(Tuteur);
            
            if (Teacher.ID.ToString() == Tuteur.Rows[0]["Tuteur"].ToString())
            {
                StudentInformationsWindow studentInfoWin = new StudentInformationsWindow(connection, selectedStudent, "Admin", Teacher);
                studentInfoWin.Show();
            }
            else
            {
                StudentInformationsWindow studentInfoWin2 = new StudentInformationsWindow(connection, selectedStudent, "Faculty", Teacher);
                studentInfoWin2.Show();
            }
        }
    }
}