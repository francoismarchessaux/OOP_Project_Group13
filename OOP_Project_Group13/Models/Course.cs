using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13
{
    public class Course
    {
        public string name { get; set; }
        public string teacher { get; set; }
        public string type { get; set; }
        public string time { get; set; }
        public string day { get; set; }
        public Class courseClass { get; set; }
        public Course(string _name, string _teacher, string _type, string _day, string _time, Class _class)
        {
            courseClass = _class;
            name = _name;
            teacher = _teacher;
            type = _type;
            day = _day;
            time = _time;
        }
    }
}
