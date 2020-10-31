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
    public partial class FacultyHomePage : Form
    {
        public FacultyHomePage(SqlConnection con)
        {
            InitializeComponent();
            String query = "SELECT * FROM Class WHERE StudentId='20201'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string info = dt.Rows[i]["Horaire"].ToString();
                    string[] horaire = info.Split(' ');
                    string nom = dt.Rows[i]["Classe"].ToString();
                    string labelName = ""+horaire[0][0] + horaire[0][1] + horaire[0][2] + horaire[1][0];
                    Type t = Type.GetType(labelName);
                    Label l = Activator.CreateInstance(t) as Label;
                    l.Visible = true;
                    l.Text = nom;
                }
            }
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            ListClasses form = new ListClasses();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}