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
    public partial class FacultyInformationsWindows : Form
    {
        SqlConnection connection;
        Faculty Teacher;
        public FacultyInformationsWindows(SqlConnection _connection, Faculty _Teacher)
        {
            InitializeComponent();
            connection = _connection;
            Teacher = _Teacher;
        }

        private void FacultyInformationsWindows_Load(object sender, EventArgs e)
        {

        }
    }
}
