//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitorial : Utility, IDroid
    {
        //Variables
        private bool _trashCompactor;
        private bool _vacuum;

        //Constructors
        public Janitorial(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum) 
                            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)

        {
            _trashCompactor = TrashCompactor;
            _vacuum = Vacuum;
            base.CalculateTotalCost();
            CalculateTotalCost();
        }

        //Public Methods
        public override void CalculateTotalCost()
        {
            if (_trashCompactor)
                TotalCost += 250;
            if (_vacuum)
                TotalCost += 50;
        }

        public override string ToString()
        {
            string returnString = "";
            returnString += base.ToString() + ",";
            if(_trashCompactor)
            {
                returnString += " Has a trash compactor,";
            }
            if(_vacuum)
            {
                returnString += " Is equipped with a vacuum";
            }
            return returnString;
        }

    }
}
