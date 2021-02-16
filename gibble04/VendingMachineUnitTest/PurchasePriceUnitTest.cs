// Exercise 04
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
        public void ConstructorParamNonTest01()
        {
            initialPrice = new PurchasePrice();
            Assert.IsTrue(initialPrice.PriceDecimal == 0);
        }

        [TestMethod]
        public void ConstructorParamTest02()
        {
            initialPrice = new PurchasePrice(.65M);
            Assert.IsTrue(initialPrice.PriceDecimal == 0.65M);
        }

        [TestMethod]
        public void ConstructorParamTest03()
        {
            initialPrice = new PurchasePrice(.65M);
            Assert.IsFalse(initialPrice.PriceDecimal == 0.75M);
        }
    }
}
