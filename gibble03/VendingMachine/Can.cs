// Exercise 03.2
// Gibble, Jay ejg2
using System;
using System.Collections.Generic;
using System.Text;

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
