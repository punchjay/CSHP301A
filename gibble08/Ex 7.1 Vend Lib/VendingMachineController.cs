using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Exercise_07._1_Vend_Lib
{
    public class VendingMachineController : INotifyPropertyChanged
    {

        private string _instructions;

        private CanRack _rack;
        private CoinBox _mainCoinBox;
        private CoinBox _insertedCoinBox;
        private PurchasePrice _price;

        public VendingMachineController(CanRack Rack, CoinBox MainCoinBox, CoinBox InsertedCoinBox, PurchasePrice SodaPrice)
        {
            _rack = Rack;
            _insertedCoinBox = InsertedCoinBox;
            _mainCoinBox = MainCoinBox;
            seedCoinBox(_mainCoinBox, new List<Coin> {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });
            _price = SodaPrice;
            _instructions = $"Please Insert {_price.PriceDecimal:c} for a Soda";
            CustomerMessage = "Enjoy!";
            LockServiceDisplay("cs",true);
        }

        private string _passwordForServiceLock;

        private bool _isLockedForService;
        public bool IsLockedForService
        {
            get => _isLockedForService;
            private set
            {
                _isLockedForService = value;
                InvokePropertyChanged("IsLockedForService");
            }
        }

        public void LockServiceDisplay(string password, bool becomeLocked)
        {
            if (becomeLocked)
            {
                _passwordForServiceLock = password;
                IsLockedForService = true;
            }
            else
            {
                if (password == _passwordForServiceLock)
                {
                    IsLockedForService = false;
                }
            }
        }

        private void seedCoinBox(CoinBox targetCoinBox, List<Coin> seedCoinList)
        {
            foreach (Coin c in seedCoinList)
            {
                targetCoinBox.Deposit(c);
            }
        }

        public void EjectCan(Flavor flavorToBeEjected)
        {
            if (_insertedCoinBox.ValueOf >= _price.PriceDecimal && !_rack.IsEmpty(flavorToBeEjected))
            {
                decimal changeDue = _insertedCoinBox.ValueOf - _price.PriceDecimal;
                if (changeDue > 0M && _mainCoinBox.CanMakeChange)
                {
                    _mainCoinBox.Withdraw(changeDue);
                    CustomerMessage = $"Enjoy your {flavorToBeEjected} soda! Here is your {changeDue:c} in change.";
                }
                else
                {
                    CustomerMessage = "Enjoy your " + flavorToBeEjected + " soda!";
                }

                _insertedCoinBox.Transfer(_mainCoinBox);
                _rack.RemoveACanOf(flavorToBeEjected);
            }
            else if (_rack.IsEmpty(flavorToBeEjected))
            {
                CustomerMessage = $"Sorry, we are currently out of {flavorToBeEjected}. Please select another flavor.";                
            }
        }

        public void ReturnCoins()
        {
            decimal amount = _insertedCoinBox.ValueOf;
            _insertedCoinBox.Withdraw(amount);
            CustomerMessage = $"Here is your {amount:c} back";
        }

        private string _customerMessage;
        public string CustomerMessage
        {
            get { return _customerMessage; }
            set
            {
                _customerMessage = value;
                InvokePropertyChanged("CustomerMessage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Note that the number of "references" that Visual Studio reports
        // above a property does not include data binding references in the XAML file
        public string Instructions => _instructions;

       

    }
}
