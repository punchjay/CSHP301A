// Exercise 04
// Gibble, Jay ejg2
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
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
            Assert.IsTrue(canRack.IsFull(Flavor.LEMON));
            Assert.IsTrue(canRack.IsFull(Flavor.ORANGE));
            Assert.IsTrue(canRack.IsFull(Flavor.REGULAR));
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
            while (!canRack.IsEmpty(Flavor.LEMON))
            {
                counter++;
                canRack.RemoveACanOf(Flavor.LEMON);
            }

            Assert.IsTrue(counter == 3);

            Debug.WriteLine($"Bin Regular emptied after {counter} cans removed.");
        }

    }
}
