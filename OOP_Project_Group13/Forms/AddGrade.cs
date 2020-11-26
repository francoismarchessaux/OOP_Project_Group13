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

namespace OOP_Project_Group13
{
    public partial class AddGrade2 : Form
    {
        MySqlConnection connection;
        Class groupName;
        public AddGrade2(MySqlConnection _connection, Class _groupName)
        {
            InitializeComponent();
            connection = _connection;
            groupName = _groupName;
        }

        private void AddGrade_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'oopprojectDataSet.grade'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.gradeTableAdapter.Fill(this.oopprojectDataSet.grade);
            classNameLabel.Text = "Class Name : " + groupName.name;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Subject = SubjectList.Text;
            bool presence = false;
            String query = "SELECT AssesmentName from Grade WHERE Subject = '" + Subject + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable GradeTable = new DataTable();
            SDA.Fill(GradeTable);
            this.comboBox1.Items.Clear();
            for (int i = 0; i < GradeTable.Rows.Count; i++)
            {
                for (int j = 0; j < comboBox1.Items.Count; j++)
                {
                    if (comboBox1.Items[j].ToString() == GradeTable.Rows[i]["AssesmentName"].ToString())
                    {
                        presence = true;
                    }
                }
                if (presence == false)
                {
                    this.comboBox1.Items.Add(GradeTable.Rows[i]["AssesmentName"].ToString());
                }

            }
        }

        private void classNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT * from Grade WHERE Subject = '" + SubjectList + "' AND AssesmentName = '" + comboBox1.Text + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable GradeTable = new DataTable();
            SDA.Fill(GradeTable);
            for (int i = 0; i < GradeTable.Rows.Count; i++)
            {
                
                string Name = GradeTable.Rows[i]["Name"].ToString();
                string Surname = GradeTable.Rows[i]["Surname"].ToString();

                dataGridView1.Rows.Add(Name, Surname);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
