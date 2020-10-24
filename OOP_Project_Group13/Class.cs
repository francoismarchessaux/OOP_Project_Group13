using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class Class
    {
        Course course { get; set; }
        List<Student> students { get; set; }
        DateTime date { get; set; }
        public Class(Course course, List<Student> students, DateTime date)
        {
            this.course = course;
            this.students = students;
            this.date = date;
        }
    }
}
