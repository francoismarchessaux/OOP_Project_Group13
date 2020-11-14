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

        private void ComboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void AddStudent_Click(object sender, EventArgs e)
        {
            string NameGroup = NameClass.Text;
            string[] Tab = ComboStudent.Text.Split(' ');
            string Name = Tab[0];
            string Surname = Tab[1];
            string StudentsID = Tab[2];

            dataGridView1.Rows.Add(NameGroup,Tab[0], Tab[1], Tab[2]);
        }

        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            string NameGroup = NameClass.Text;
            string StudentsIDs = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                StudentsIDs = dataGridView1[3, i].Value + " " + StudentsIDs;
            }
            String query = "SELECT * from Class WHERE className = '" + NameGroup +  "' AND studentsIDs = '" + StudentsIDs + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            SDA = new MySqlDataAdapter(query, connection);
            DataTable groupTable = new DataTable();
            SDA.Fill(groupTable);
            connection.Open();
            query = "INSERT INTO Class (className, studentsIDs ) VALUES ('" + NameGroup + "' ,  '" + StudentsIDs + "')";
            SDA = new MySqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Class created successfully !");
            this.Hide();
        }
        
        private void CreateClass_Load(object sender, EventArgs e)
        {
            String query = "Select name, firstName, userID from Users Where status = 'Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                this.ComboStudent.Items.Add(userTable.Rows[i]["name"].ToString() + " " + userTable.Rows[i]["firstName"].ToString() + " " + userTable.Rows[i]["userID"].ToString());
            }            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdministratorMainWindow adminWindow = new AdministratorMainWindow(admin, connection);
            this.Hide();
            adminWindow.Show();

        }

        private void NameClass_TextChanged(object sender, EventArgs e)
        {
        }

       private void RemoveStudent_Click(object sender, EventArgs e)
       {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }

        }
    }
}
