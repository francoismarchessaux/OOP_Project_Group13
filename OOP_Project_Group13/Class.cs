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
        public List<Student> students { get; set; }

        public Class(string _name)
        {
            name = _name;
        }
        public Class(string _name, List<Student> _students)
        {
            name = _name;
            students = _students;
        }
        public Class(string _name, List<Course> _courses, List<Student> _students)
        {
            name = _name;
            students = _students;
        }
    }
}
