using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class Faculty : User
    {
        public List<Class> Classes { get; set; }

        public Faculty() { }
        public Faculty(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture) { }
        public Faculty(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture, List<Class> _Classes) : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {
            Classes = _Classes;
        }
    }
}