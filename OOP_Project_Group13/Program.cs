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
    //23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MySqlConnection connection = GetConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow(connection));
            Console.ReadLine();
        }

        /// <summary>
        /// Get the connection string for the Mysql Database
        /// </summary>
        /// <returns>the connection string</returns>
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(@"server=DESKTOP-04OJU8R;user id=Louis; Password = Louloulebg; persistsecurityinfo=True;database=oopproject");
            return connection;
        }
    }
}
