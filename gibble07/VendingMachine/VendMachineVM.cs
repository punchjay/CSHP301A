// Exercise 07
// Gibble, Jay ejg2
using System.Collections.Generic;
using System.ComponentModel;

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
            _title = $"Please insert {sodaPrice.PriceDecimal:c} for your choice of Soda";
        }

        public void EjectCan(Flavor flavorToBeEjected)
        {
            if (TempCoinBox.ValueOf >= sodaPrice.PriceDecimal && !Rack.IsEmpty(flavorToBeEjected))
            {
                decimal changeDue = TempCoinBox.ValueOf - sodaPrice.PriceDecimal;
                if (changeDue > 0M && MainCoinBox.CanMakeChange)
                {
                    MainCoinBox.Withdraw(changeDue);
                    CustomerMessage = $"Here is your {flavorToBeEjected} Soda and your {changeDue:c}";
                }
                else
                {
                    CustomerMessage = $"Here is your {flavorToBeEjected} Soda";
                }
                //transfer money out of TempCoinBox
                TempCoinBox.Transfer(MainCoinBox);
                Rack.RemoveACanOf(flavorToBeEjected);
            }
            else if (Rack.IsEmpty(flavorToBeEjected))
            {
                CustomerMessage = $"Sorry, no more {flavorToBeEjected} in the Soda bin";
            }
        }

        //backing field
        private string _customerMessage;

        public string CustomerMessage
        {
            get { return _customerMessage; }
            set
            {
                _customerMessage = value;
                //updates view on property changed
                InvokePropertyChanged("CustomerMessage");
            }
        }

        private string _title;

        public string Title => _title;

    }
}
