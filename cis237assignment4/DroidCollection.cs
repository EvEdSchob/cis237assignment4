﻿//Evan Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
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

        public static void TypeSort(Droid[] DroidInventory)
        {
            int x = 0; //Index for various counters
            int LastItem = 0; //Stores index of final item in the array
            //Create DroidStack instances for each type of droid
            DroidStack<Protocol> ProtocolStack = new DroidStack<Protocol>();
            DroidStack<Utility> UtilityStack = new DroidStack<Utility>();
            DroidStack<Janitorial> JanitorialStack = new DroidStack<Janitorial>();
            DroidStack<Astromech> AstromechStack = new DroidStack<Astromech>();

            //Create DroidQueue instance
            DroidQueue<Droid> DroidsQueue = new DroidQueue<Droid>();

            while (DroidInventory[x] != null)
            {
                LastItem = x++;
            }

            //For loop sorts Droids out to the appropriate queue.
            for(int i = 0; i <= LastItem; i++)
            {
                switch(DroidInventory[i].Model)
                {
                    case "Protocol":
                        ProtocolStack.Push((Protocol)DroidInventory[i]);
                        break;
                    case "Utility":
                        UtilityStack.Push((Utility)DroidInventory[i]);
                        break;
                    case "Janitorial":
                        JanitorialStack.Push((Janitorial)DroidInventory[i]);
                        break;
                    case "Astromech":
                        AstromechStack.Push((Astromech)DroidInventory[i]);
                        break;
                }
            }
            //Pops Protocol droids off of the stack and places them in the queue
            while(!ProtocolStack.IsEmpty)
            {
                DroidsQueue.Queue(ProtocolStack.Pop());
            }
            //Pops Utility droids off of the stack and places them in the queue
            while (!UtilityStack.IsEmpty)
            {
                DroidsQueue.Queue(UtilityStack.Pop());
            }
            //Pops Janitorial droids off of the stack and places them in the queue
            while (!JanitorialStack.IsEmpty)
            {
                DroidsQueue.Queue(JanitorialStack.Pop());
            }
            //Pops Astromech droids off of the stack and places them in the queue
            while (!AstromechStack.IsEmpty)
            {
                DroidsQueue.Queue(AstromechStack.Pop());
            }
            //Dequeues Droids and places them back in the DroidInventory array
            x = 0; //Reset index
            while(!DroidsQueue.IsEmpty)
            {
                DroidInventory[x] = DroidsQueue.Dequeue();
                x++;
            }
        }

        public static void CostSort()
        {

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
