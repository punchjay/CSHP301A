// Exercise 02.1 
// Gibble, Jay ejg2
namespace VendingMachine
{
    public class PurchasePrice
    {
        private int price;

        public PurchasePrice() { }

        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
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
