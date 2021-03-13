using VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMachine
{
    [TestClass]
    public class TestVendingMachine
    {
        private VendMachineVM machine = new VendMachineVM();
        private Flavor testFlavor = Flavor.REGULAR;
        private int canCountBeforeAttempt;
        private int canCountAfterAttempt;
        private decimal insertedCoinsValueBeforeAttempt;
        private decimal insertedCoinsValueAfterAttempt;
        private decimal mainCoinsValueBeforeAttempt;
        private decimal mainCoinsValueAfterAttempt;
        private PurchasePrice sodaPrice = new PurchasePrice(.35M);

        [TestMethod]
        public void TestEjectCanWithoutPaying()
        {
            attemptToEjectCan();
            Assert.IsTrue(canCountBeforeAttempt == canCountAfterAttempt);
        }

        [TestMethod]
        public void TestEjectCanExactPayment()
        {
            machine.TempCoinBox.Deposit(Coin.QUARTERCOIN);
            machine.TempCoinBox.Deposit(Coin.DIMECOIN);
            attemptToEjectCan();
            Assert.IsTrue(canCountBeforeAttempt - 1 == canCountAfterAttempt);
            Assert.IsTrue(insertedCoinsValueAfterAttempt == 0M);
            Assert.IsTrue(mainCoinsValueBeforeAttempt + insertedCoinsValueBeforeAttempt == mainCoinsValueAfterAttempt);
        }

        private void attemptToEjectCan()
        {
            canCountBeforeAttempt = machine.Rack[testFlavor];
            insertedCoinsValueBeforeAttempt = machine.TempCoinBox.ValueOf;
            mainCoinsValueBeforeAttempt = machine.MainCoinBox.ValueOf;
            machine.EjectCan(testFlavor);
            canCountAfterAttempt = machine.Rack[testFlavor];
            insertedCoinsValueAfterAttempt = machine.TempCoinBox.ValueOf;
            mainCoinsValueAfterAttempt = machine.MainCoinBox.ValueOf;
        }

        [TestMethod]
        public void TestOverPayment()
        {
            machine.TempCoinBox.Deposit(Coin.HALFDOLLARCOIN);
            attemptToEjectCan();
            Assert.IsTrue(mainCoinsValueAfterAttempt == mainCoinsValueBeforeAttempt + sodaPrice.PriceDecimal,
                $"Main Coin Box Value: Expected={mainCoinsValueBeforeAttempt + sodaPrice.PriceDecimal:c} Actual={mainCoinsValueAfterAttempt:c}");
            Assert.IsTrue(canCountBeforeAttempt == canCountAfterAttempt + 1,
                $"Can Rack [{testFlavor}] Can Count: Expected={canCountBeforeAttempt - 1} Actual={canCountAfterAttempt}");
        }
    }
}
