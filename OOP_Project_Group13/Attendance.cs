using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Group13
{
    public class Attendance
    {
        private string date;
        private string matiere;
        private int number;
        public Attendance(string date,string matiere)
        {
            this.date = date;
            this.matiere = matiere;
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Matiere
        {
            get
            {
                return this.matiere;
            }
            set
            {
                this.matiere = value;
            }
        }
        
    }
}
