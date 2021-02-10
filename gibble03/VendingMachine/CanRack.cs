// Exercise 03.1 
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

        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            FillTheCanRack();
        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            Debug.WriteLine($"adding a can of {FlavorOfCanToBeAdded} flavored soda to the rack");
            if (FlavorOfCanToBeAdded == "REGULAR") regular = regular + 1;
            else if (FlavorOfCanToBeAdded == "ORANGE") orange = orange + 1;
            else if (FlavorOfCanToBeAdded == "LEMON") lemon = lemon + 1;
            else Debug.WriteLine($"Error: attempt to add an unknown flavor {0} to the rack");
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            Debug.WriteLine($"removing a can of {FlavorOfCanToBeRemoved} flavored soda from the rack");
            if (FlavorOfCanToBeRemoved == "REGULAR") regular = regular - 1;
            else if (FlavorOfCanToBeRemoved == "ORANGE") orange = orange - 1;
            else if (FlavorOfCanToBeRemoved == "LEMON") lemon = lemon - 1;
            else Debug.WriteLine("Error: attempt to remove an unknown flavor {FlavorOfCanToBeRemoved} from the rack");

        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine($"Emptying can rack of flavor {FlavorOfBinToBeEmptied}");
            if (FlavorOfBinToBeEmptied == "REGULAR") regular = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "ORANGE") orange = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "LEMON") lemon = EMPTYBIN;
            else Debug.WriteLine($"Error: attempt to empty rack of unknown flavor {FlavorOfBinToBeEmptied}");
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == BINSIZE;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == BINSIZE;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == BINSIZE;
            else Debug.WriteLine("Error: attempt to check status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Console.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;
        }
    }
}
