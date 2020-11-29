using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13.Forms
{
    public partial class FirstConWin : Form
    {
        MySqlConnection connection;
        string id;
        string status;
        public FirstConWin(string _id, MySqlConnection _connection, string _status)
        {
            InitializeComponent();
            id = _id;
            connection = _connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pswrd1.Text != null && pswrd2.Text != null)
            {
                if (Regex.IsMatch(pswrd1.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).*$") && pswrd1.Text.Length >= 8)
                {
                    if(pswrd1.Text == pswrd2.Text)
                    {
                        String query = $"UPDATE users SET password = '{pswrd1.Text}', firstConnection = 'false' WHERE(userID = '{id}')";
                        MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
                        connection.Open();
                        SDA.SelectCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Password modified successfully !");
                        if(status == "Student")
                        {
                            LoginWindow.RunStudent(id);
                        }
                        else if(status == "Teacher")
                        {
                            LoginWindow.RunTeacher(id);
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Passwords must match");
                    }
                }
                else
                {
                    MessageBox.Show("Password must match the following : \n - Must contain at least 1 uppercase \n - Must contain at least 1 lowercase \n - Must contain at least 1 digit \n - Must contain at least 1 special character \n - Must be at least 8 characters long");
                }
            }
            else
            {
                MessageBox.Show("Please enter a new password");
            }
        }
    }
}
