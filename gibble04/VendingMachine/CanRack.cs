// Exercise 04
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

        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;

        public CanRack()
        {
            FillTheCanRack();
        }

        public void FillTheCanRack()
        {
            foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
            {
                rack[flavorValue] = BINSIZE;
            }

            Debug.WriteLine("Filling the can rack");

            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
            //Console.WriteLine(rack[(int)Flavor.LEMON]);
        }

        //2.3 write out the contents of rack array. For example, one flavor per line with the flavor name and
        // the number of cans of soda of that flavor. In a real system, this function would probably be in a
        // separate class, and the CanRack would export this information as strings. We’re doing it this way
        // for the sake of the simplicity of the exercise.
        public void DisplayCanRack() { 
        
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine($"Full rack of {FlavorOfCanToBeAdded}, no can added.");
            }
            else
            {
                FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
                Debug.WriteLine($"adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack");
                if (FlavorOfCanToBeAdded == "REGULAR") regular += 1;
                else if (FlavorOfCanToBeAdded == "ORANGE") orange += 1;
                else if (FlavorOfCanToBeAdded == "LEMON") lemon += 1;
                else Debug.WriteLine($"Error: attempt to add an unknown flavor {FlavorOfCanToBeAdded} to the rack");
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"Empty rack of {FlavorOfCanToBeRemoved}, no can removed.");
            }
            else
            {
                FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
                Debug.WriteLine($"removing a can of {FlavorOfCanToBeRemoved} flavored soda from the rack");
                if (FlavorOfCanToBeRemoved == "REGULAR") regular -= 1;
                else if (FlavorOfCanToBeRemoved == "ORANGE") orange -= 1;
                else if (FlavorOfCanToBeRemoved == "LEMON") lemon -= 1;
                else Debug.WriteLine($"Error: attempt to remove an unknown flavor {FlavorOfCanToBeRemoved} from the rack");
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine($"Emptying can rack of flavor {FlavorOfBinToBeEmptied}");
            if (FlavorOfBinToBeEmptied == "REGULAR") regular = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "ORANGE") orange = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "LEMON") lemon = EMPTYBIN;
            else Debug.WriteLine($"Error: attempt to empty rack of unknown flavor {FlavorOfBinToBeEmptied}");
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
            if (FlavorOfBinToCheck == "REGULAR") result = regular == BINSIZE;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == BINSIZE;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == BINSIZE;
            else Debug.WriteLine($"Error: attempt to check status of unknown flavor {FlavorOfBinToCheck}");
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
            if (FlavorOfBinToCheck == "REGULAR") result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == EMPTYBIN;
            else Debug.WriteLine($"Error: attempt to check rack status of unknown flavor {FlavorOfBinToCheck}");
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOfBinToBeChecked.ToString());
        }
    }
}
