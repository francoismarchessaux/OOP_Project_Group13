
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

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13
{
    public partial class CreateExam : Form
    {
        MySqlConnection connection;
        Class groupName;
        public CreateExam(MySqlConnection _connection, Class _groupName)
        {
            InitializeComponent();
            connection = _connection;
            groupName = _groupName;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Displays the name of the group when the page loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateExam_Load(object sender, EventArgs e)
        {
            classNameLabel.Text = "Class Name : " + groupName.name;
        }
        /// <summary>
        /// Allows the Admin/Teacher to create a new exam
        /// All the information that the teacher will enter in the textbox will be stored in the Grade database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateExam_Click(object sender, EventArgs e)
        {
            string subject = SubjectList.Text;
            string title = textBoxTitle.Text;
            string coeff = textBoxCoeff.Text;
            string Class = groupName.name;
            DateTime date = dateTimePicker1.Value;
            String query = "SELECT * from Grade WHERE Subject = '" + subject + "' AND AssesmentName = '" + title + "' AND Date = '" + date.ToString("yyyy/MM/dd") +"' AND coefficient = '" + coeff   +" ' AND Class = '" + Class + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable ExamTable = new DataTable();
            SDA.Fill(ExamTable);
            for (int i=0; i < groupName.students.Count; i++)
            {
                int StudentID = groupName.students[i].ID;
                connection.Open();
                query = "INSERT INTO Grade (Subject, AssesmentName, Date, StudentID, coefficient,Class) VALUES ('" + subject + "', '" + title + "', '" + date.ToString("yyyy/MM/dd") + "','" + StudentID +"', '" + coeff + "', '"+  Class +  "')";
                SDA = new MySqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            MessageBox.Show("Exam created successfully !");
        }

        private void SubjectList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCoeff_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
