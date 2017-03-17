//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        //Adds a new droid to the array
        public void AddItem(Droid[] DroidInventory)
        {
            Console.WriteLine("Adding a new droid. Please enter information.");
            Console.WriteLine();
            switch (typeSelect())
            {
                //Protocol
                case 1:
                    Console.WriteLine("Protocol Droid");
                    Console.WriteLine();
                    DroidCollection.Add(materialSelect(), "Protocol", colorSelect(), numberOfLanguages(), DroidInventory);
                    break;
                //Janitorial
                case 2:
                    Console.WriteLine("Utility Droid");
                    Console.WriteLine();
                    DroidCollection.Add(materialSelect(), "Utility", colorSelect(), toolbox(), computerConnection(), arm(), DroidInventory);
                    break;
                //Janitorial
                case 3:
                    Console.WriteLine("Janitorial Droid");
                    Console.WriteLine();
                    DroidCollection.Add(materialSelect(), "Janitorial", colorSelect(), toolbox(), computerConnection(), arm(), trashCompactor(), vacuum(), DroidInventory);
                    break;
                //Astromech
                case 4:
                    Console.WriteLine("Astromech Droid");
                    Console.WriteLine();
                    DroidCollection.Add(materialSelect(), "Astromech", colorSelect(), toolbox(), computerConnection(), arm(), fireExtinguisher(), numberOfShips(), DroidInventory);
                    break;
            }
        }

        //Accept string input and output to screen
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        //Display menu then calls MenuSelect to accept numeric input.
        public int MainMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print droid list");
            Console.WriteLine("2. Add a new droid");
            Console.WriteLine("3. Sort by droid type");
            Console.WriteLine("4. Sort by total cost");
            Console.WriteLine("5. Exit" + Environment.NewLine);
            Console.Write("Make a selection: ");
            return MenuSelect(5);
        }

        //Select the type of droid to be input
        private int typeSelect()
        {
            Console.WriteLine("What type of droid would you like to add?");
            Console.WriteLine("1. Protocol");
            Console.WriteLine("2. Utility");
            Console.WriteLine("3. Janitorial");
            Console.WriteLine("4. Astromech");
            Console.Write("Make A Selection: ");
            return MenuSelect(4);
        }

        //Select the material of a given droid
        private string materialSelect()
        {
            //"Druasteel" Impact resistant
            //"Agrinium" Durable and lightweight
            //"Inoxium" Corrosion resistant
            //"Laminanium" Self-repairing
            //"Neuranium" Radiation resistant
            Console.WriteLine("Please select the material of this droid.");
            Console.WriteLine("1. Durasteel");
            Console.WriteLine("2. Agrinium");
            Console.WriteLine("3. Inoxium");
            Console.WriteLine("4. Laminanium");
            Console.WriteLine("5. Neuranium");
            Console.Write("Make A Selection: ");
            switch (MenuSelect(5))
            {
                case 1:
                    return "Durasteel";
                case 2:
                    return "Agrinium";
                case 3:
                    return "Inoxium";
                case 4:
                    return "Laminanium";
                case 5:
                    return "Neuranium";
                default:
                    return null;
            }
        }

        //Select the color of a given droid
        private string colorSelect()
        {
            Console.WriteLine("Please select the color of this droid.");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Orange");
            Console.WriteLine("4. Gold");
            Console.WriteLine("5. Silver");
            Console.Write("Make A Selection: ");
            switch (MenuSelect(5))
            {
                case 1:
                    return "Red";
                case 2:
                    return "Blue";
                case 3:
                    return "Orange";
                case 4:
                    return "Gold";
                case 5:
                    return "Silver";
            }
            return null;
        }

        //Method used to cut down the number of repeated lines of code
        //that would have been written for every menu input
        private int MenuSelect(int NumberOfOptions)
        {
            int selection = intInput();
            while (selection < 1 || selection > NumberOfOptions)
            {
                Console.WriteLine("Invalid input, please select enter a number between 1 and {0}", NumberOfOptions);
                Console.WriteLine();
                Console.Write("Make A Selection: ");
                selection = MenuSelect(NumberOfOptions);
            }
            return selection;
        }


        //Methods with boolean input
        private bool verifyDroid()
        {
            Console.WriteLine("Is the information for this droid correct? (y/n)");
            return boolInput();
        }

        //Boolean Methods for Utility droids
        private bool toolbox()
        {
            Console.WriteLine("Does this droid have a toolbox? (y/n)");
            return boolInput();
        }

        private bool computerConnection()
        {
            Console.WriteLine("Does this droid have a computer connection? (y/n)");
            return boolInput();
        }

        private bool arm()
        {
            Console.WriteLine("Is this droid equipped with an arm? (y/n)");
            return boolInput();
        }

        //Boolean Methods for Janitorial droids
        private bool trashCompactor()
        {
            Console.WriteLine("Is this droid equipped with a trash compactor? (y/n)");
            return boolInput();
        }

        private bool vacuum()
        {
            Console.WriteLine("Does this droid have a vacuum? (y/n)");
            return boolInput();
        }

        //Boolean Method for Astromech droids
        private bool fireExtinguisher()
        {
            Console.WriteLine("Does this droid have a fire extinguisher? (y/n)");
            return boolInput();
        }

        //Boolean input method
        private bool boolInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.WriteLine();
            if (cki.KeyChar == 'y')
                return true;
            else
                return false;
        }


        //Integer input methods
        private int numberOfLanguages()
        {
            //Prompts the user for the number of spoken languages of a
            //given protocol droid.
            Console.WriteLine("How many languages can this droid speak?");
            //x is a single use storage variable to store the value 
            //returned from intInput for validation and return.
            int x = intInput();
            if(x < 1)
            {
                Console.WriteLine("Protocol droids must be able to speak at least one language.");
                x = intInput();
                
            }
            return x;
        }

        private int numberOfShips()
        {
            //Prompts the user for the number of ships
            //a given astromech droid is capable of maintaining
            Console.WriteLine("How many ships is this droid capable of maintaining?");
            //x is a single use storage variable to store the value 
            //returned from intInput for validation and return.
            int x = intInput();
            if (x < 1)
            {
                Console.WriteLine("Atromech droids must be able to tend to at least one ship.");
                x = intInput();

            }
            return x;
        }

        //Method handles input of integer values
        //Method is called for menu inputs as well as
        //for the integer values in Protol and Utility
        private int intInput()
        {
            string input = Console.ReadLine();

            Console.WriteLine();

            //Parse user input, throw error for invalid input
            //Error is more verbose if input is not numeric
            int inputValid = 0;
            try
            {
                inputValid = Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
            }
            return inputValid;
        }
    }
}
