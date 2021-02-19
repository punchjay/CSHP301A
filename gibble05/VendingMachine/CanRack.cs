// Exercise 05
// Gibble, Jay ejg2
using System;
using System.Diagnostics;

namespace VendingMachine
{
    public class CanRack
    {

        //2.1 Create an array of integers representing the number of cans in the rack indexed by the flavors
        // The Enum.GetValues().Length value represents the number of flavors (i.e., values in the type flavors).
        private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;

        //2.4
        //private int regular = EMPTYBIN;
        //private int orange = EMPTYBIN;
        //private int lemon = EMPTYBIN;

        public CanRack()
        {
            FillTheCanRack();
        }

        public void FillTheCanRack()
        {
            //2.4
            foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
            {
                rack[flavorValue] = BINSIZE;
            }

            Debug.WriteLine("Filling the can rack");

            //regular = BINSIZE;
            //orange = BINSIZE;
            //lemon = BINSIZE;
        }

        //2.3 write out the contents of rack array. For example, one flavor per line with the flavor name and
        // the number of cans of soda of that flavor. In a real system, this function would probably be in a
        // separate class, and the CanRack would export this information as strings. We’re doing it this way
        // for the sake of the simplicity of the exercise.
        public void DisplayCanRack()
        {
            Console.WriteLine("Here are your soda flavor options:");
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), flavorName);
                int flavorIndex = (int)flavorEnumeral;
                Console.WriteLine($"{flavorName} - {rack[flavorIndex]}");
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
                //2.4
                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeAdded))
                {
                    Debug.WriteLine($"adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack");
                    flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeAdded);
                    int flavorIndex = (int)flavorEnumeral;
                    rack[flavorIndex]++;
                }
                else
                {
                    Debug.WriteLine($"Error: attempt to add an unknown flavor {FlavorOfCanToBeAdded} to the rack");
                }
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            //2.4
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"Empty rack of {FlavorOfCanToBeRemoved}, no can removed.");
            }
            else
            {
                Flavor flavorEnumeral;
                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeRemoved))
                {
                    flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeRemoved);
                    Debug.WriteLine($"removing a can of {FlavorOfCanToBeRemoved} flavored soda from the rack");
                    int flavorIndex = (int)flavorEnumeral;
                    rack[flavorIndex]--;
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
            //2.4
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeEmptied))
            {
                Debug.WriteLine($"Emptying can rack of flavor {FlavorOfBinToBeEmptied}");
                Flavor f = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToBeEmptied);
                rack[(int)f] = EMPTYBIN;
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
            //2.4
            Flavor flavorEnumeral;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                int flavorIndex = (int)flavorEnumeral;
                result = rack[flavorIndex] == BINSIZE;
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
            //2.4
            Flavor flavorEnumeral;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                int flavorIndex = (int)flavorEnumeral;
                result = rack[flavorIndex] == EMPTYBIN;
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
