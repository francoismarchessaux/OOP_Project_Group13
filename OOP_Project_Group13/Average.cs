using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    class Average
    {
        public Subject subject { get; set; }
        public List<Grade> grades { get; set; }
        public Average(Subject subject,List<Grade> grades)
        {
            this.subject = subject;
            this.grades = grades;
        }
        public double GetAverage()
        {
            int sum = 0;
            int divide = 0;
            foreach(Grade grade in grades)
            {
                sum += grade.Note*grade.Coeff;
                divide += grade.Coeff;
            }
            return sum / divide;
        }

    }
}
