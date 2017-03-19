//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the user interface.
            UserInterface ui = new UserInterface();

            //Instantiate the droid storage array.
            Droid[] DroidInventory = new Droid[100];

            //Used to clean code appearance.
            InputTestData(DroidInventory);

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
                        DroidCollection.TypeSort(DroidInventory);
                        choice = ui.MainMenu();
                        break;
                    case 4:
                        //Sort droids by total cost
                        DroidCollection.CostSort(DroidInventory);
                        choice = ui.MainMenu();
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

        //Method used to create the first 12 droids that will be used for testing.
        private static void InputTestData(Droid[] DroidInventory)
        {
            DroidCollection.Add("Agrinium","Protocol","Gold",12000000,DroidInventory);
            DroidCollection.Add("Inoxium","Janitorial","Orange",true,false,true,true,true,DroidInventory);
            DroidCollection.Add("Neuranium","Astromech","Red",true,true,false,true,100,DroidInventory);
            DroidCollection.Add("Lamanium","Utility","Silver",true,true,true,DroidInventory);
            DroidCollection.Add("Agrinium","Janitorial","Red",false,true,true,false,true,DroidInventory);
            DroidCollection.Add("Durasteel","Astromech","Blue",true,true,true,true,50,DroidInventory);
            DroidCollection.Add("Inoxinum","Protocol","Orange",1500000,DroidInventory);
            DroidCollection.Add("Neuranium","Protocol","Silver",6000000,DroidInventory);
            DroidCollection.Add("Agrinium","Utility","Gold",false,true,true,DroidInventory);
            DroidCollection.Add("Laminanium","Astromech","Red",false,true,true,true,5,DroidInventory);
            DroidCollection.Add("Durasteel","Utility","Orange",true,false,true,DroidInventory);
            DroidCollection.Add("Durasteel","Protocol","Blue",2000000,DroidInventory);
        }
    }
}
