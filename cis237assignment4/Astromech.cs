//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility, IDroid
    {
        //Variables
        private bool _fireExtinguisher;
        private int _numberOfShips;
        private const decimal costPerShip = 10;
        
        //Constructors
        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberOfShips) 
            : base (Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            _fireExtinguisher = FireExtinguisher;
            _numberOfShips = NumberOfShips;
            base.CalculateTotalCost();
            CalculateTotalCost();
        }

        //Public Methods
        public override void CalculateTotalCost()
        {
            if (_fireExtinguisher)
                TotalCost += 300;
            //It is assumed that an astromech droid is capable of maintaining
            //at least one ship therefore the first ship is free.
            TotalCost += (_numberOfShips - 1) * costPerShip;
        }

        public override string ToString()
        {
            string returnString = "";
            returnString += base.ToString() + ",";
            if (_fireExtinguisher)
            {
                returnString += " Has a fire extinguisher,";
            }
            returnString += " Is capable of handling " + _numberOfShips + " ship(s).";
            return returnString;
        }
    }
}
