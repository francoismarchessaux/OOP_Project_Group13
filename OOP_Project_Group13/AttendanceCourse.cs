using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class AttendanceCourse
    {
        public Subject subject { get; set; }
        public int[] attendance { get; set; }
        public string[] course { get; set; }
        public AttendanceCourse(Subject subject,int[] attendance, string[] course)
        {
            this.subject = subject;
            this.attendance = attendance;
            this.course = course;
        }
    }
}
