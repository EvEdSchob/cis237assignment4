//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid, IDroid
    {
        //Variables
        private bool _toolBox;
        private bool _computerConnection;
        private bool _arm;

        //Constructors
        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm) : base(Material, Model, Color)
        {
            _toolBox = ToolBox;
            _computerConnection = ComputerConnection;
            _arm = Arm;
            base.CalculateTotalCost();
            CalculateTotalCost();
        }

        //Public Methods
        public override void CalculateTotalCost()
        {
            if (_toolBox)
                TotalCost += 20;
            if (_computerConnection)
                TotalCost += 30;
            if (_arm)
                TotalCost += 25;
        }

        public override string ToString()
        {
            string returnString = "";
            returnString += TotalCost.ToString("C") + " ";
            returnString += base.ToString();
            if(_toolBox)
            {
                returnString += " Includes a toolbox,";
            }
            if(_computerConnection)
            {
                returnString += " Has a computer connection,";
            }
            if(_arm)
            {
                returnString += " Is equipped with an arm";
            }
            return returnString;
        }
    }
}
