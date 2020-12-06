using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
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
