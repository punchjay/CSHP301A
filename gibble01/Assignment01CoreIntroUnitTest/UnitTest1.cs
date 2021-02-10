// Exercise 01 
// Gibble, Jay ejg2
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Assignment01CoreIntro;

namespace Assignment01CoreIntroUnitTest
{
    [TestClass]
    public class UnitTestVendingMachine
    {
        StringReader sr;
        StringWriter sw;

        [TestMethod]
        public void StringTestMethod01()
        {
            sr = new StringReader("55");
            sw = new StringWriter();
            Console.SetOut(sw);
            Console.SetIn(sr);

            Program.Main(null);

            string result = sw.ToString();

            Assert.IsTrue(result.Contains("Welcome to the .NET C# Soda Vending Machine."));
            Assert.IsTrue(result.Contains("Please insert 35 cents:"));
            Assert.IsTrue(result.Contains("You have inserted 55 cents"));
            Assert.IsTrue(result.Contains("Thanks! Here is your soda. Your change is 20 cents."));
        }

        [TestMethod]
        public void StringTestMethod02()
        {
            sr = new StringReader("10");
            sw = new StringWriter();
            Console.SetOut(sw);
            Console.SetIn(sr);

            Program.Main(null);

            string result = sw.ToString();

            Assert.IsTrue(
                result.Contains("You have inserted 10 cents") &&
                result.Contains("Please enter 25 cents more to complete your transaction."));
        }

        [TestMethod]
        public void StringTestMethod03()
        {
            sr = new StringReader("101");
            sw = new StringWriter();
            Console.SetOut(sw);
            Console.SetIn(sr);

            Program.Main(null);

            string result = sw.ToString();

            Assert.IsTrue(
                result.Contains("You have inserted 101 cents") &&
                result.Contains("Please enter less than a dollar to complete your transaction."));
        }
    }
}
