using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    class PanelFees : Panel
    {
        public Label name { get; set; }
        public Label FeesPaid { get; set; }
        public Label FeesLeft { get; set; }
        
        public PanelFees(Label name, Label feesPaid, Label feesLeft)
        {
            this.name = name;
            this.FeesPaid = feesPaid;
            this.FeesLeft = feesLeft;          
        }        
    }
}
