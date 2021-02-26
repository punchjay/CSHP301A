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

        [Obsolete("This constructor is obsolete.", false)]
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        [Obsolete("This property is obsolete.", false)]
        public int Price
        {
            get
            {
                return (int)(price * 100);
            }
            set
            {
                price = value / 100M;
            }
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
