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
        public Attendance attendances { get; set; }
        public TimeTable timetable { get; set; }
        public Class studentClass { get; set; }
        public int fees { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }
        public Student() { }
        public Student(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture, DateTime _birthday, string _address) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {
            birthday = _birthday;
            address = _address;
        }
        public Student(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture, DateTime _birthday, string _address,string _tutor, List<Grade> _gradesList, Attendance _attendances, TimeTable _timetable, Class _studentClass, int _fees ) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {
            gradesList = _gradesList;
            attendances = _attendances;
            tutor = _tutor;
            timetable = _timetable;
            studentClass = _studentClass;
            fees = _fees;
            birthday = _birthday;
            address = _address;
        }
        public Student(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture, DateTime _birthday, string _address,Class _studentClass) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {
            birthday = _birthday;
            address = _address;
            studentClass = _studentClass;
        }
        public Student(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture) { }
        public Student(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture, DateTime _birthday, string _address, Class _studentClass,  Attendance _attendances) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {
            studentClass = _studentClass;
            attendances = _attendances;
            birthday = _birthday;
            address = _address;
        }
    }
}