using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class Course
    {
        string name { get; set; }
        Faculty teacher { get; set; }
        Subject subject { get; set; }
        string type { get; set; }
        public Course(string name, Faculty teacher, string type, Subject subject)
        {
            this.name = name;
            this.teacher = teacher;
            this.type = type;
            this.subject = subject;
        }
    }
}
