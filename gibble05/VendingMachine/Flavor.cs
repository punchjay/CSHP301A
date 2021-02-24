// Exercise 05.1
// Gibble, Jay ejg2
using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public enum Flavor { LEMON, ORANGE, REGULAR }

    static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        static FlavorOps()
        {
            foreach (Flavor flavorEnum in Enum.GetValues(typeof(Flavor)))
            {
                _allFlavors.Add(flavorEnum);
            }
        }

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            FlavorName = FlavorName.ToUpper();
            Flavor result = Flavor.REGULAR;

            if (Enum.IsDefined(typeof(Flavor), FlavorName))
            {
                result = (Flavor)Enum.Parse(typeof(Flavor), FlavorName);
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
            return result;
        }

        // property to return a List<Flavor> of all of the Flavors
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }

    }
}