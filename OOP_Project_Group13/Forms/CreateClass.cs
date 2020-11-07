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

namespace OOP_Project_Group13.Forms
{
    public partial class CreateClass : Form
    {
        MySqlConnection connection;
        public CreateClass(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
        }

        private void ComboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {

        }

        private void CreateClassButton_Click(object sender, EventArgs e)
        {

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

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NameClass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
