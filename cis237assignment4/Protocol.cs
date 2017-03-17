//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid, IDroid
    {
        //Variables
        private int _numberOfLanguages;
        //Cost per language is kept low to minimize the otherwise exobritant
        //pricetag on a droid capable of over 6 million forms of communication
        private const decimal costPerLanguage = .000025m;
        

        //Constructors
        public Protocol(string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            _numberOfLanguages = NumberOfLanguages;
            base.CalculateTotalCost();
            CalculateTotalCost();
        }

        //Methods
        public override void CalculateTotalCost()
        {
            decimal languageCosts;
            //The first million languages are free
            if (_numberOfLanguages <= 1000000)
                languageCosts = 0;
            else
                languageCosts = (_numberOfLanguages - 1000000) * costPerLanguage;
            TotalCost += Math.Round(languageCosts, 2);
        }

        public override string ToString()
        {
            string returnString = "";
            returnString += TotalCost.ToString("C") + " ";
            returnString += base.ToString();
            returnString += " That can speak " + _numberOfLanguages + " language(s)";
            return returnString;
        }
    }
}
