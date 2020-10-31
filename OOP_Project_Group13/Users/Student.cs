using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13.Users
{
    public class Student : User
    {
        public string tutor { get; set; }
        public List<Grade> gradesList { get; set; }
        public List<Attendance> attendances { get; set; }
        public TimeTable timetable { get; set; }
        public List<Class> studentClasses { get; set; }
        public int fees { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }

        public Student() { }
        public Student(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture, DateTime _birthday, string _address) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {
            birthday = _birthday;
            address = _address;
        }
        public Student(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture, string _tutor, List<Grade> _gradesList, List<Attendance> _attendances, TimeTable _timetable, List<Class> _studentClasses, int _fees, DateTime _birthday, string _address) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {
            gradesList = _gradesList;
            attendances = _attendances;
            tutor = _tutor;
            timetable = _timetable;
            studentClasses = _studentClasses;
            fees = _fees;
            birthday = _birthday;
            address = _address;
        }

    }
}
