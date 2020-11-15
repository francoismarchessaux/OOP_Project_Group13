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
        public string name { get; set; }
        public List<Course> courses { get; set; }
        public List<string> students { get; set; }

        public Class(string _name)
        {
            name = _name;
        }
        public Class(string _name, string _students)
        {
            name = _name;
            string[] studentsIDsTab = _students.Split(' ');
            students = new List<string>();
            for(int i = 0; i < studentsIDsTab.Length; i++)
            {
                students.Add(studentsIDsTab[i]);
            }
        }
        public Class(string _name, List<Course> _courses, string _students)
        {
            name = _name;
            string[] studentsIDsTab = _students.Split(' ');
            for (int i = 0; i < studentsIDsTab.Length; i++)
            {
                students.Add(studentsIDsTab[i]);
            }
        }
    }
}
