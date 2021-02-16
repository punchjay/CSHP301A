// Exercise 04
// Gibble, Jay ejg2

namespace VendingMachine
{
    class Can
    {
        public readonly Flavor TheFlavor = Flavor.REGULAR;

        public Can()
        { 
        }

        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}
