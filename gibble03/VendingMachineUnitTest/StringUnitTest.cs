// Exercise 03.1
// Gibble, Jay ejg2
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using VendingMachine;

namespace StringUnitTest
{
    [TestClass]
    public class StringUnitTest
    {
        StringReader strReader;
        readonly StringWriter strWriter = new StringWriter();

        [TestMethod]
        public void StringTest01()
        {
            strReader = new StringReader("0.55");
            Console.SetOut(strWriter);
            Console.SetIn(strReader);

            Program.Main(null);

            string result = strWriter.ToString();

            Assert.IsTrue(result.Contains("Welcome to the .NET C# Soda Vending Machine."));
            Assert.IsTrue(result.Contains("Please insert $0.35 cents:"));
            Assert.IsTrue(result.Contains("You have inserted $0.55 cents"));
            Assert.IsTrue(result.Contains("Thanks! Here is your soda. Your change is $0.20 cents."));
        }

        [TestMethod]
        public void StringTest02()
        {
            strReader = new StringReader("0.10");
            Console.SetOut(strWriter);
            Console.SetIn(strReader);

            Program.Main(null);

            string result = strWriter.ToString();

            Assert.IsTrue(
                result.Contains("You have inserted $0.10 cents") &&
                result.Contains("Please enter $0.25 cents more to complete your transaction."));
        }

        [TestMethod]
        public void StringTest03()
        {
            strReader = new StringReader("101");
            Console.SetOut(strWriter);
            Console.SetIn(strReader);

            Program.Main(null);

            string result = strWriter.ToString();

            Assert.IsTrue(
                result.Contains("You have inserted $101.00 cents") &&
                result.Contains("Please enter less than a dollar to complete your transaction."));
        }
    }
}

