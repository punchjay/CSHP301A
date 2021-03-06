// Exercise 06
// Gibble, Jay ejg2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VendingMachine
{
    public class VendMachineVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CanRack Rack { get; set; }
        public CoinBox MainCoinBox { get; set; }
        public CoinBox TempCoinBox { get; set; }
        private PurchasePrice sodaPrice;

        public VendMachineVM()
        {
            Rack = new CanRack();
            MainCoinBox = new CoinBox(new List<Coin> { new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME), new Coin(Coin.Denomination.NICKEL), 
            new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });
            TempCoinBox = new CoinBox();
            sodaPrice = new PurchasePrice(0.35M);
        }

        public void EjectCan(Flavor flavorToBeEjected) 
        { 
        
        }
    }
}
