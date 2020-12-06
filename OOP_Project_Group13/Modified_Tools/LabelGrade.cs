using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
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
