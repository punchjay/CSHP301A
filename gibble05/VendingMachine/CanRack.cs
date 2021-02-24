// Exercise 05.2
// Gibble, Jay ejg2
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace VendingMachine
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number in an array indexed
    //  by the Flavor enumeration (e.g., rack[Flavor.ORANGE] == 1 means 
    //  that there is one can of orange soda in the rack).
    public class CanRack
    {
        //private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];
        private Dictionary<Flavor, int> rack = null;
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;

        public CanRack()
        {
            FillTheCanRack();
        }

        public void FillTheCanRack()
        {
            rack = new Dictionary<Flavor, int>();

            //foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
            //{
            //    rack[flavorValue] = BINSIZE;
            //}

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                rack[aFlavor] = BINSIZE;
            }

            Debug.WriteLine("Filling the can rack");
        }

        public void DisplayCanRack()
        {
            Console.WriteLine("Here are your soda flavor options:");

            //foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            //{
            //    Flavor flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), flavorName);
            //    int flavorIndex = (int)flavorEnumeral;
            //    Console.WriteLine($"{flavorName} - {rack[flavorIndex]}");
            //}

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                Console.WriteLine($"{aFlavor}\t{rack[aFlavor]}");
            }
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();

            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine($"Full rack of {FlavorOfCanToBeAdded}, no can added.");
            }
            else
            {
                Flavor flavorEnumeral;
                Debug.WriteLine($"adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack");

                //flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeAdded);
                //int flavorIndex = (int)flavorEnumeral;
                //rack[flavorIndex]++;

                flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeAdded);
                rack[flavorEnumeral]++;

            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();

            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"Empty rack of {FlavorOfCanToBeRemoved}, no can removed.");
            }
            else
            {
                Flavor flavorEnumeral;

                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeRemoved))
                {
                    Debug.WriteLine($"removing a can of {FlavorOfCanToBeRemoved} flavored soda from the rack");

                    //flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeRemoved);
                    //int flavorIndex = (int)flavorEnumeral;
                    //rack[flavorIndex]--;

                    flavorEnumeral = FlavorOps.ToFlavor(FlavorOfCanToBeRemoved);
                    rack[flavorEnumeral]--;
                }
                else
                {
                    Debug.WriteLine($"Error: attempt to remove an unknown flavor {FlavorOfCanToBeRemoved} from the rack");
                }
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();

            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeEmptied))
            {
                Debug.WriteLine($"Emptying can rack of flavor {FlavorOfBinToBeEmptied}");

                //Flavor f = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToBeEmptied);
                //rack[(int)f] = EMPTYBIN;

                Flavor flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToBeEmptied);
                rack[flavorEnumeral] = EMPTYBIN;
            }
            else
            {
                Debug.WriteLine($"Error: attempt to empty rack of unknown flavor {FlavorOfBinToBeEmptied}");
            }
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }

        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine($"Checking if can rack is full of flavor {FlavorOfBinToCheck}");

            Flavor flavorEnumeral;

            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                //flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                //int flavorIndex = (int)flavorEnumeral;
                //result = rack[flavorIndex] == BINSIZE;

                flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToCheck);
                result = rack[flavorEnumeral] == BINSIZE;
            }
            else
            {
                Debug.WriteLine($"Error: attempt to check status of unknown flavor {FlavorOfBinToCheck}");
            }
            return result;
        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString());
        }

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine($"Checking if can rack is empty of flavor {FlavorOfBinToCheck}");

            Flavor flavorEnumeral;

            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                //flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                //int flavorIndex = (int)flavorEnumeral;
                //result = rack[flavorIndex] == EMPTYBIN;

                flavorEnumeral = FlavorOps.ToFlavor(FlavorOfBinToCheck);
                result = rack[flavorEnumeral] == EMPTYBIN;
            }
            else
            {
                Debug.WriteLine($"Error: attempt to check rack status of unknown flavor {FlavorOfBinToCheck}");
            }
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOfBinToBeChecked.ToString());
        }
    }
}
