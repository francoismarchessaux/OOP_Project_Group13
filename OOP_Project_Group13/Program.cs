using MySqlConnector;
using OOP_Project_Group13.Forms;
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
            MySqlConnection connection = new MySqlConnection(@"server=DESKTOP-04OJU8R;user id=Louis; Password = Louloulebg; persistsecurityinfo=True;database=oopproject");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow(connection));
            Console.ReadLine();
        }
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(@"server=DESKTOP-04OJU8R;user id=Louis; Password = Louloulebg; persistsecurityinfo=True;database=oopproject");
            return connection;
        }
    }
}
