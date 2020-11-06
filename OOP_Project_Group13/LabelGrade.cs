using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    class LabelGrade : Label
    {
        public Label name { get; set; }
        public Label grade { get; set; }
        public LabelGrade(Label name, Label grade)
        {
            this.name = name;
            this.grade = grade;
        }
    }
}
