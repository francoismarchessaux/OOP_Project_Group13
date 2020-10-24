using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13.Users
{
    public class Administrator : User
    {
        public Administrator(string _name, string _firstName, string _status, string _password, int _ID, string _mail, int _phone)
            : base(_name, _firstName, _status, _password, _ID, _mail, _phone) 
        { 
        
        }

        public Course CreateCourse()
        {
            Course cours1 = new Course();
            return cours1;
        }

        public Student CreateStudent(string _name, string _firstName, string _status, string _password, int _ID, string _mail, int _phone)
        {
            Student student1 = new Student();
            return student1;
        }

        public void RegisterStudent(Student student, Course course)
        {

        }

        public bool SetGrades(Student student)
        {
            bool gradesSubmitted = false;
            return gradesSubmitted;
        }
    }
}
