using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Exercise_07._1_Vend_Lib;

namespace Ex_7._2_Vend_Service_WPF
{
    public class VendingMachineViewModel
    {
        public CanRack Rack { get; set; } = new CanRack();

        public CoinBox MainCoinBox { get; set; } = new CoinBox();
        public CoinBox InsertedCoinBox { get; set; } = new CoinBox();
        public PurchasePrice SodaPrice { get; set; } = new PurchasePrice(0.35M);
        public VendingMachineController VendController { get; set; }
        
        public VendingMachineViewModel()
        {
            VendController = new VendingMachineController(Rack, MainCoinBox, InsertedCoinBox, SodaPrice);
        }

    }
}
