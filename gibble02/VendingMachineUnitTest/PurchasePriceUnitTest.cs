// Exercise 02.1 
// Gibble, Jay ejg2
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace PurchasePriceUnitTest 
{
    [TestClass]
    public class PurchasePriceUnitTest
    {
        PurchasePrice initialPrice;

        [TestMethod]
        public void PurchasePriceTest01()
        {
            initialPrice = new PurchasePrice();
            var sodaPrice = initialPrice.Price;
            Assert.IsTrue(sodaPrice == 0);
        }

        [TestMethod]
        public void PurchasePriceTest02()
        {
            initialPrice = new PurchasePrice(65);
            var sodaPrice = initialPrice.Price;
            Assert.IsTrue(sodaPrice == 65);
        }

        [TestMethod]
        public void PurchasePriceTest03()
        {
            initialPrice = new PurchasePrice(65);
            var sodaPrice = initialPrice.Price;
            Assert.IsFalse(sodaPrice == 75);
        }
    }
}
