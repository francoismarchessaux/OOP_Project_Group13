using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public abstract class Subject
    {
        public string name { get; set; }
        public Subject(string name)
        {
            this.name = name;
        }
    }
}
