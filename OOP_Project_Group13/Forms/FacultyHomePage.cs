using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    public partial class FacultyHomePage : Form
    {
        public FacultyHomePage(MySqlConnection con, Faculty teacher)
        {
            InitializeComponent();
            TimeTable tt = new TimeTable(teacher, con, panelTT);
            tt.InitializeTimeTable();
            tt.GetTimetable();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}