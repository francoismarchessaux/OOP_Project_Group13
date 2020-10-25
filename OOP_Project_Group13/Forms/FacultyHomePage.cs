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
    public partial class FacultyHomePage : Form
    {
        public FacultyHomePage()
        {
            InitializeComponent();
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            ListClasses form = new ListClasses();
            form.Show();
        }
    }
}
