using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13.Users
{
    public class Student
    {
        string name;

        string tutor;
        List<Grade> notes;
        List<Attendance> absences;
        TimeTable edt;
        string groups;
        int fees;
        public Student(List<Grade> notes, List<Attendance> absences, string tutor, TimeTable edt, string name, string groups, int fees)
        {
            this.notes = notes;
            this.absences = absences;
            this.tutor = tutor;
            this.edt = edt;
            this.name = name;
            this.groups = groups;
            this.fees = fees;
        }
        public List<Grade> Notes
        {
            get
            {
                return this.notes;
            }
        }
        public List<Attendance> Absences
        {
            get
            {
                return this.absences;
            }
        }
        public string Tutor
        {
            get
            {
                return this.tutor;
            }
            set
            {
                this.tutor = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Groups
        {
            get
            {
                return this.groups;
            }
            set
            {
                this.groups = value;
            }
        }
        public int Fees
        {
            get
            {
                return this.fees;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Fees must be 0 or higher");
                }
                else
                {
                    this.fees = value;
                }
            }
        }
        public void SeeGrades()
        {
            int i = 0;
            while (i < notes.Count)
            {
                Console.WriteLine(notes[i]);
                i++;
            }
        }
        public void SeeAttendance()
        {
            int i = 0;
            while (i < absences.Count)
            {
                Console.WriteLine(absences[i]);
                i++;
            }
        }
        public void SeeInformation()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Groups :" + groups);
            Console.WriteLine("Grades: ");
            SeeGrades();
            Console.WriteLine("You have " + absences.Count + " absences :");
            SeeAttendance();

        }
    }
}
