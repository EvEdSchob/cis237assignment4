//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public abstract class Droid : IDroid
    {
        //Variables
        private string _material;
        private string _model;
        private string _color;
        private decimal _modelCost;
        private decimal _baseCost;
        private decimal _totalCost;


        //Properties
        string Material
        {
            get { return _material; }
            set { _material = value; }
        }

        string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        decimal BaseCost
        {
            get { return _baseCost; }
            set { _baseCost = value; }
        }

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        //Constructors
        public Droid(string Material, string Model, string Color)
        {
            _material = Material;
            _model = Model;
            _color = Color;
            CalculateTotalCost();
        }

        //Methods
        private decimal CalculateBaseCost()
        {
            switch(Model)
            {
                case "Protocol":
                    _baseCost += 1500;
                    break;
                case "Utility":
                    _baseCost += 2000;
                    break;
                case "Janitorial":
                    _baseCost += 1575;
                    break;
                case "Astromech":
                    _baseCost += 1750;
                    break;
            }
            switch(Material)
            {

                case "Durasteel":
                    _baseCost += 100;
                    break;
                case "Agrinium":
                    _baseCost += 150;
                    break;
                case "Inoxium":
                    _baseCost += 175;
                    break;
                case "Laminanium":
                    _baseCost += 200;
                    break;
                case "Neuranium":
                    _baseCost += 300;
                    break;
            }
            return _baseCost;
        }

        public virtual void CalculateTotalCost()
        {
            _totalCost = CalculateBaseCost();
        }

        public override string ToString()
        {
            string returnString = "";
            returnString += _color + " " + _model + " droid: Made of " + MaterialDescription() + _material + ". ";
            return returnString;
        }

        private string MaterialDescription()
        {
            //"Druasteel" Impact resistant
            //"Agrinium" Durable and lightweight
            //"Inoxium" Corrosion resistant
            //"Laminanium" Self-repairing
            //"Neuranium" Radiation resistant
            switch (Material)
            {
                case "Durasteel":
                    return "impact resistant ";
                case "Agrinium":
                    return "durable and lightweight ";
                case "Inoxium":
                    return "corrosion resistant ";
                case "Laminanium":
                    return "self-repairing ";
                case "Neuranium":
                    return "radiation resistant";
                default:
                    return "";
            }
        }
    }
}
