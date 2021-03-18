using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine;

namespace VendingMachineWPF
{
    class VendingMachineVM
    {
        public CanRack Rack { get; set; } = new CanRack();
        public CoinBox MainCoinBox { get; set; } = new CoinBox();
    }
}
