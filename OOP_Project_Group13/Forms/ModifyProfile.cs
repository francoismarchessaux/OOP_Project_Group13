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

namespace OOP_Project_Group13.Forms
{
    public partial class ModifyProfile : Form
    {
        MySqlConnection connection;
        int ID;
        public ModifyProfile(MySqlConnection _connection, int _ID)
        {
            InitializeComponent();
            connection = _connection;
            ID = _ID;
        }

        private void ModifyProfile_Load(object sender, EventArgs e)
        {
            String query = "Select * from users Where userID = '" + ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable user = new DataTable();
            SDA.Fill(user);
            NameLabel.Text = "Name : " + user.Rows[0]["name"].ToString() + " " + user.Rows[0]["firstName"].ToString();
            IDLabel.Text = "ID : " + user.Rows[0]["userID"].ToString();
            MailLabel.Text = "Mail : " + user.Rows[0]["mail"].ToString();
            if (user.Rows[0]["birthday"].ToString() != "01/01/2000")
            {
                dateTimePicker1.Value = Convert.ToDateTime(user.Rows[0]["birthday"].ToString());
            }
            if (user.Rows[0]["address"].ToString() != "Address")
            {
                addressTxtBox.Text = user.Rows[0]["address"].ToString();
            }
            if(user.Rows[0]["profilePicture"].ToString() != "./Images/pp1.jpg")
            {
                ProfilePictureTxtBox.Text = user.Rows[0]["profilePicture"].ToString();
            }
            if (user.Rows[0]["phone"].ToString() != "0000000000")
            {
                PhoneTxtBox.Text = user.Rows[0]["phone"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "jpg";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.ShowDialog();
            ProfilePictureTxtBox.Text = ofd.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = $"UPDATE users SET profilePicture = '{ProfilePictureTxtBox.Text}', birthday = '{dateTimePicker1.Value.Date.ToString("yyyy/MM/dd")}', phone = '{PhoneTxtBox.Text}', address = '{addressTxtBox.Text}' WHERE(userID = '{ID}')";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            connection.Open();
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Profile updated successfully !");
            Close();
        }
    }
}
