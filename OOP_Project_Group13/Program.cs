using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MySqlConnection connection = new MySqlConnection(@"server=DESKTOP-04OJU8R;user id=Louis;persistsecurityinfo=True;database=oopproject;allowuservariables=True");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow(connection));
            Console.ReadLine();
        }
    }
}
