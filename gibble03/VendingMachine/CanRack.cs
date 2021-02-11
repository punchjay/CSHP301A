// Exercise 03.2
// Gibble, Jay ejg2
using System;
using System.Diagnostics;

namespace VendingMachine
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    public class CanRack
    {
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;
        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            FillTheCanRack();
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            Debug.WriteLine($"adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack");
            if (FlavorOfCanToBeAdded == "REGULAR") regular = regular++;
            else if (FlavorOfCanToBeAdded == "ORANGE") orange = orange++;
            else if (FlavorOfCanToBeAdded == "LEMON") lemon = lemon++;
            else Debug.WriteLine($"Error: attempt to add an unknown flavor {FlavorOfCanToBeAdded} to the rack");
        }

        public void AddACanOfEnum(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            Debug.WriteLine($"removing a can of {FlavorOfCanToBeRemoved} flavored soda from the rack");
            if (FlavorOfCanToBeRemoved == "REGULAR") regular = regular++;
            else if (FlavorOfCanToBeRemoved == "ORANGE") orange = orange++;
            else if (FlavorOfCanToBeRemoved == "LEMON") lemon = lemon++;
            else Debug.WriteLine($"Error: attempt to remove an unknown flavor {FlavorOfCanToBeRemoved} from the rack");
        }

        public void RemoveACanOfEnum(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
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

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Console.WriteLine($"Checking if can rack is empty of flavor {FlavorOfBinToCheck}");
            if (FlavorOfBinToCheck == "REGULAR") result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == EMPTYBIN;
            else Debug.WriteLine($"Error: attempt to check rack status of unknown flavor {FlavorOfBinToCheck}");
            return result;
        }
    }
}
