using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    class PanelCourse : Panel
    {
        public Label name { get; set; }
        public Label averageLabel { get; set; }
        public Label average { get; set; }
        public List<LabelGrade> grades { get; set; }
        public PanelCourse(Label name, Label averageLabel, Label average, List<LabelGrade> grades)
        {
            this.name = name;
            this.averageLabel = averageLabel;
            this.average = average;
            this.grades = grades;
        }
        
    }
}
