// Exercise 03.2 
// Gibble, Jay ejg2
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace CanRackUnitTest
{
    [TestClass]

    public class CanRackUnitTest
    {
        private CanRack canRack;

        [TestInitialize]
        public void CreateRack()
        {
            canRack = new CanRack();
        }

        [TestMethod]
        public void NewRackIsFull()
        {
            Assert.IsTrue(canRack.IsFullEnum(Flavor.LEMON));
            Assert.IsTrue(canRack.IsFullEnum(Flavor.ORANGE));
            Assert.IsTrue(canRack.IsFullEnum(Flavor.REGULAR));
        }

        [TestMethod]
        public void UseBadFlavor()
        {
            canRack.RemoveACanOf("bad flavor");
        }

        [TestMethod]
        public void EmptyRackOfRegular()
        {
            int counter = 0;
            while (!canRack.IsEmptyEnum(Flavor.LEMON))
            {
                counter++;
                canRack.RemoveACanOfEnum(Flavor.LEMON);
            }

            Assert.IsTrue(counter == 3);

            Debug.WriteLine($"Bin Regular emptied after {counter} cans removed.");
        }

    }
}
