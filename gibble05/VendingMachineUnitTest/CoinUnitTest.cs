// Exercise 5
// Gibble, Jay ejg2
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace CoinUnitTest
{
    [TestClass]

    public class CoinUnitTest
    {
        [TestMethod]
        public void CreateSlug()
        {
            Coin testSlug = new Coin();
            Assert.IsTrue(testSlug.ValueOf == 0);
        }

        public void CreateBadValueSlugViaString()
        {
            Coin testSlug = new Coin("222");
            Assert.IsTrue(testSlug.ValueOf == 0);
        }

        [TestMethod]
        public void CreateBadValueSlugViaDecimal()
        {
            Coin testSlug = new Coin(23M);
            Assert.IsTrue(testSlug.ValueOf == 0);
        }

        [TestMethod]
        public void CreateNickelViaDecimal()
        {
            Coin testNickel = new Coin(0.05M);
            Assert.IsTrue(testNickel.ValueOf == 0.05M);
        }

        [TestMethod]
        public void CreateDimeViaDenomination()
        {
            Coin testDime = new Coin(0.1M);
            Assert.IsTrue(testDime.ValueOf == 0.1M);
        }

    }
}
