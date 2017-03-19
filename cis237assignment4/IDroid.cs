//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    interface IDroid : IComparable<Droid>
    {
        //Methods to be implemented.
        void CalculateTotalCost();

        //Properties
        decimal TotalCost { get; set; }
    }
}
