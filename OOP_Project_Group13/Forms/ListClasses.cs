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
    public partial class ListClasses : Form
    {
        public ListClasses()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void ListClasses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenClassInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenClassInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenClassInfo();
        }
        private void OpenClassInfo()
        {
            ClassInfo form = new ClassInfo();
            form.Show();
        }
    }
}