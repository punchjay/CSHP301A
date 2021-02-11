// Exercise 03.1 
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

        //public PurchasePrice(int initialPrice)
        //{
        //    Price = initialPrice;
        //}

        //public int Price
        //{
        //    get
        //    {
        //        return (int)(price * 100);
        //    }
        //    set
        //    {
        //        price = value / 100M;
        //    }
        //}

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
