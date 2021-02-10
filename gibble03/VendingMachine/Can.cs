using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Can
    {
        public enum Flavor { REGULAR, ORANGE, LEMON }

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
