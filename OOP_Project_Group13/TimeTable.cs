using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class TimeTable
    {
        List<Class> classes { get; set; }
        public TimeTable(List<Class>classes)
        {
            this.classes = classes;
        }
    }
}
