using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using OOP_Project_Group13.Users;

namespace OOP_Project_Group13.Forms
{
    public partial class PaymentWindow : Form
    {
        MySqlConnection connection;
        string status;
        Student student;          

        public PaymentWindow(MySqlConnection _connection, Student _student, string _status)
        {
            InitializeComponent();
            connection = _connection;
            student = _student;
            status = _status;

        }

        private void PaymentWindow_Load(object sender, EventArgs e)
        {
            String query = "Select * from Users Where status = 'Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);


            student.PanelPayment(panelPayment);
            deptLabel.Text = Convert.ToDouble(dt.Rows[0]["fees"]) + "£";
        }

        

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Click(object sender, EventArgs e)
        {
            String query = "Select * from Users Where status = 'Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            string Total = textBox1.Text;
            double tot;
            bool valide = Double.TryParse(Total,out tot);

            if (valide == false || tot <= 0.00 || tot > Convert.ToDouble(dt.Rows[0]["fees"]))
            {
                MessageBox.Show("Unvalide amount selected \nPlease only use numbers (and a comma for decimals)");
            }

            else
            {
                double left = Convert.ToDouble(dt.Rows[0]["fees"]) - tot;
                string dialog = "";
                if (left == 0.00)
                {
                    dialog = "Your dept will be completely paid off.";
                }
                else
                {
                    dialog = "Your dept will be : " + left + "£.";
                }
                

                
                DialogResult PayeOrNo = MessageBox.Show(dialog, "Are you sure that you'd like to pay \nback the amount of " + tot +"£?", MessageBoxButtons.YesNo);
            }


        }    

    }
}
