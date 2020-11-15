using MySqlConnector;
using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class Class
    {
        MySqlConnection connection = Program.GetConnection();
        public string name { get; set; }
        public List<Student> students { get; set; }

        public Class(string className)
        {
            name = className;
            String query = "Select * from class Where className = '" +name + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable classTable = new DataTable();
            SDA.Fill(classTable);
            string[] tab = classTable.Rows[0]["studentsIDs"].ToString().Split(' ');
            for (int i = 0; i < tab.Length; i++)
            {
                int id = Convert.ToInt32(tab[i]);
                Student student = new Student(id);
                students.Add(student);
            }
        }
    }
}
