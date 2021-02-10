// Exercise 02.1 
// Gibble, Jay ejg2
namespace VendingMachine
{
    public class PurchasePrice
    {
        private int price;

        public PurchasePrice()
        {
            price = 0;
        }

        public PurchasePrice(int initialPrice)
        {
            price = initialPrice;
        }

        public int Price
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
