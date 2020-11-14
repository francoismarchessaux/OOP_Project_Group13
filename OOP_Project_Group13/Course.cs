using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class Course
    {
        public string name { get; set; }
        public string teacher { get; set; }
        public string type { get; set; }
        public Course(string name, string teacher, string type)
        {
            this.name = name;
            this.teacher = teacher;
            this.type = type;
        }
    }
}
