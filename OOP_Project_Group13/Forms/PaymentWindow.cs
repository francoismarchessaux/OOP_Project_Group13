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

        /// <summary>
        /// Loads the panel in which the name of the student is written and adapts the "dept" label depending on the student's fees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentWindow_Load(object sender, EventArgs e)
        {
            String query = "Select * from Users Where userID ='" + student.ID + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);


            student.PanelPayment(panelPayment);
            deptLabel.Text = Convert.ToDouble(dt.Rows[0]["fees"]) + "£";
        }

        
        /// <summary>
        /// Closes the active window to get back to the Student Information Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button the user clicks after writing the amount to pay,
        /// This funtion will analyse if the amount is correct, 
        /// Will show how much the user will have to pay after this payment,
        /// Asks the user for a payment confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Payment_Click(object sender, EventArgs e)
        {
            String query = "Select * from Users Where userID ='" + student.ID + "'";
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
                

                
                DialogResult PayeOrNo = MessageBox.Show(dialog, "Are you sure that you'd like to pay back the amount of " + tot +"£?", MessageBoxButtons.YesNoCancel);

                if (PayeOrNo == DialogResult.Yes)
                {
                    double FeesLeft = Convert.ToDouble(dt.Rows[0]["fees"]) - tot;
                    double PaidFees = Convert.ToDouble(dt.Rows[0]["feesPaid"]) + tot;
                    
                    query = "UPDATE users SET fees ='" + Convert.ToString(FeesLeft) + "', feesPaid ='" + Convert.ToString(PaidFees) + "' WHERE userID ='" + student.ID + "'";
                    SDA = new MySqlDataAdapter(query, connection);
                    connection.Open();
                    SDA.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Payment successfull ! \nThank you.");
                    Close();

                }
                if (PayeOrNo == DialogResult.No)
                {
                    textBox1.Clear();
                }
                if (PayeOrNo == DialogResult.Cancel)
                {
                    Close();
                }
            }


        }    

    }
}
