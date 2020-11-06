using MySql.Data.MySqlClient;
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
    public partial class CreateStudentWindow : Form
    {
        MySqlConnection connection;

        public CreateStudentWindow(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "INSERT INTO [Users] (userID, name, firstName, mail) VALUES ('" + Convert.ToInt32(StudentID_TxtBox.Text) + "', '" + LastName_TxtBox.Text.ToUpper() + "', '" + FirstName_TxtBox.Text.ToLower() + "', '" + FirstName_TxtBox.Text.ToLower() + ". + " + LastName_TxtBox.Text.ToLower() + "@college.ie)";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student created succesfully !");
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
