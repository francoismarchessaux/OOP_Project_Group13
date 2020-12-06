using MySqlConnector;
using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using static System.ComponentModel.ISupportInitialize;
using System.Globalization;

namespace OOP_Project_Group13.Forms
{
    public partial class CreateClass : Form
    {
        MySqlConnection connection;
        Administrator admin;


        public CreateClass(MySqlConnection _connection, Administrator _admin)
        {
            InitializeComponent();
            connection = _connection;
            admin = _admin;
        }

        /// <summary>
        /// Loads the combo-box with the surname, first name and ID of the students who still have no class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateClass_Load(object sender, EventArgs e)
        {
            String query = "Select * from Users Where status = 'Student'and className is NULL";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                this.ComboStudent.Items.Add(userTable.Rows[i]["name"].ToString() + " " + userTable.Rows[i]["firstName"].ToString() + " " + userTable.Rows[i]["userID"].ToString());
            }
        }

        private void ComboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        /// <summary>
        /// Tests if a student is selected in the combo box, this function is called when the button add is pushed
        /// The informations of the student will then be collected and inserted into the DataGridView
        /// This student will then be removed from the combo-Box in order to avoid adding him twice in the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (ComboStudent.Text != "")
            {
                string NameGroup = NameClass.Text;
                string[] Tab = ComboStudent.Text.Split(' ');
                string Name = Tab[0];
                string Surname = Tab[1];
                string StudentsID = Tab[2];

                dataGridView1.Rows.Add(NameGroup, Tab[2], Tab[0], Tab[1]);
                int index = ComboStudent.SelectedIndex;
                ComboStudent.Items.RemoveAt(index);
                ComboStudent.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("No student selected.");
            }


                
        }        

        /// <summary>
        /// When all the wanted students are selected, the button "Create Class" calls this function
        /// The name of the class (entered by the Admin) and the Id of every student in the DataGridView are taken 
        /// And inserted into the Data Table "Class" 
        /// A new class is now created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            string NameGroup = NameClass.Text;
            string StudentsIDs = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if(i == dataGridView1.RowCount - 1)
                {
                    StudentsIDs += dataGridView1[1, i].Value;
                }
                else
                {
                    StudentsIDs += dataGridView1[1, i].Value + " ";
                }
            }            
            connection.Open();
            string query = "INSERT INTO Class (className, studentsIDs ) VALUES ('" + NameGroup + "' ,  '" + StudentsIDs + "')";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Class created successfully !");
            this.Close();
        }

        /// <summary>
        /// This funtion is called when the button "Clear" is pushed and will clear every element in the DataGridView
        /// In order tp reset the formation of the class without having to remove each student manually
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        /// <summary>
        /// Closes the active window to get back to the Administrator Main Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameClass_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// If a student is no longer wanted in the class created, the admin will select this student in the DataGridView
        /// Then by clicking on "Remove", this student will be removed from the DataGridView and will be restored into the Combo-Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                string Name = dataGridView1.SelectedRows[0].Cells["NameOfStudent"].Value.ToString();
                string Surname = dataGridView1.SelectedRows[0].Cells["SurnameOfStudent"].Value.ToString();
                ComboStudent.Items.Add(Name +" "+ Surname + " "+ ID);

                dataGridView1.Rows.Remove(this.dataGridView1.SelectedRows[0]);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
