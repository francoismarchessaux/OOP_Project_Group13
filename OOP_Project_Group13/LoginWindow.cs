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

namespace OOP_Project_Group13
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\François\Desktop\OOP\OOP_Project_Group13\OOP_Project_Group13\Database1.mdf;Integrated Security=True");
            connection.Open();
            String query = "INSERT INTO [User] (userID, name, firstName, status, password, mail, phoneNumber) VALUES ('23202', 'MARCHESSAUX', 'Francois', 'Student', '12345', 'mail@gmail.com', '00')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
