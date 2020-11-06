using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13.Users
{
    public class Administrator : User
    {
        public Administrator(string _name, string _firstName, string _status, string _password, int _ID, string _mail, string _phone, string _profilePicture)
            : base(_name, _firstName, _status, _password, _ID, _mail, _phone, _profilePicture)
        {

        }
    }
}