//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    static class DroidCollection
    {
        //Protocol contstructor
        public static void Add(string Material, string Model, string Color, int NumberOfLanguages, Droid[] DroidInventory)
        {
            IDroid NewProtocol = new Protocol(Material, Model, Color, NumberOfLanguages);
            AddDroid(NewProtocol, DroidInventory);
        }

        //Utility constructor
        public static void Add(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, Droid[] DroidInventory)
        {
            IDroid NewUtility = new Utility(Material, Model, Color, ToolBox, ComputerConnection, Arm);
            AddDroid(NewUtility, DroidInventory);
        }

        //Janitorial constructor
        public static void Add(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum, Droid[] DroidInventory)
        {
            IDroid NewJanitorial = new Janitorial(Material, Model, Color, ToolBox, ComputerConnection, Arm, TrashCompactor, Vacuum);
            AddDroid(NewJanitorial, DroidInventory);
        }

        //Astromech constructor
        public static void Add(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberOfShips, Droid[] DroidInventory)
        {
            IDroid NewAstromech = new Astromech(Material, Model, Color, ToolBox, ComputerConnection, Arm, FireExtinguisher, NumberOfShips);
            AddDroid(NewAstromech, DroidInventory);
        }


        //Adds  NewDroid to the end of the droidInventory array
        private static void AddDroid(IDroid NewDroid, IDroid[] DroidInventory)
        {
            int x = 0;
            while (DroidInventory[x] != null)
            {
                x++;
            }
            DroidInventory[x] = NewDroid;
        }


        //Creates an output string of all items in the array
        //and returns it to the method called it
        public static string GetPrintString(Droid[] DroidInventory)
        {
            string outputString = "";

            foreach (Droid droid in DroidInventory)
            {
                if (droid != null)
                {
                    //Concantonate to outputString
                    outputString += droid.ToString() +
                        Environment.NewLine;
                }
            }
            return outputString;
        }
    }
}
