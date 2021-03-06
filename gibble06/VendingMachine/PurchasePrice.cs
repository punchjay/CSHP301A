// Exercise 06
// Gibble, Jay ejg2
using System;

namespace VendingMachine
{
    public class PurchasePrice
    {
        private decimal price;

        public PurchasePrice()
        {
            price = 0M;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }

        public decimal PriceDecimal
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
