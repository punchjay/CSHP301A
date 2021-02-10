// Exercise 03.1 
// Gibble, Jay ejg2
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace CanRackUnitTest
{
    [TestClass]

    public class CanRackUnitTest
    {
        private CanRack rack;

        [TestInitialize]
        public void CreateRack()
        {
            rack = new CanRack();
        }

        [TestMethod]
        public void NewRackIsFull()
        {
            Assert.IsTrue(rack.IsFull("Regular"));
            Assert.IsTrue(rack.IsFull("Orange"));
            Assert.IsTrue(rack.IsFull("Lemon"));
        }

        [TestMethod]
        public void UseBadFlavor()
        {
            rack.RemoveACanOf("bad flavor");
        }

        [TestMethod]
        public void EmptyRackOfRegular()
        {
            int counter = 0;
            while (!rack.IsEmpty("Regular"))
            {
                counter++;
                rack.RemoveACanOf("Regular");
            }

            Assert.IsTrue(counter == 3);

            Debug.WriteLine($"Bin Regular emptied after {counter} cans removed.");
        }

    }
}
