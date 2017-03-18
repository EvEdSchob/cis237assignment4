//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the user interface.
            UserInterface ui = new UserInterface();

            //Instantiate the droid storage array.
            Droid[] DroidInventory = new Droid[100];

            //Output Program Header
            ui.Output("************************************************************" + Environment.NewLine +
            "******                 Jawa Droid Sales               ******" + Environment.NewLine +
            "*******           Droid Inventory Management         *******" + Environment.NewLine +
            "************************************************************" + Environment.NewLine);

            int choice = ui.MainMenu();

            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        //Output the full list of available droids.
                        ui.Output(DroidCollection.GetPrintString(DroidInventory));
                        choice = ui.MainMenu();
                        break;
                    case 2:
                        //Add item to DroidInventory
                        ui.AddItem(DroidInventory);
                        choice = ui.MainMenu();
                        break;
                    case 3:
                        //Sort droids by type
                        choice = ui.MainMenu();
                        ui.Output(DroidCollection.GetPrintString(DroidInventory));
                        break;
                    case 4:
                        //Sort droids by total cost
                        choice = ui.MainMenu();
                        ui.Output(DroidCollection.GetPrintString(DroidInventory));
                        break;
                    default:
                        //Output the error if there is a numerical input that is not 1-3
                        ui.Output("Error: Please enter valid numeric entry (1-3)");
                        choice = ui.MainMenu();
                        break;
                }
            }
            //If UI input = 3 display farewell and close the program
            ui.Output("Goodbye!");
        }
    }
}
