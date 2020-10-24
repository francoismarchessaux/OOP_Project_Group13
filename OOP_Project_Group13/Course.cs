using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class Course : Subject
    {
        Faculty teacher { get; set; }
        string type { get; set; }
        public Course(string name, Faculty teacher, string type) : base(name)
        {
            this.teacher = teacher;
            this.type = type;
        }
    }
}
