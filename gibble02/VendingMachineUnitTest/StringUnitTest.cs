// Exercise 02
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
        StringWriter strWriter;

        [TestMethod]
        public void StringTest01()
        {
            strReader = new StringReader("55");
            strWriter = new StringWriter();
            Console.SetOut(strWriter);
            Console.SetIn(strReader);

            Program.Main(null);

            string result = strWriter.ToString();

            Assert.IsTrue(result.Contains("Welcome to the .NET C# Soda Vending Machine."));
            Assert.IsTrue(result.Contains("Please insert 35 cents:"));
            Assert.IsTrue(result.Contains("You have inserted 55 cents"));
            Assert.IsTrue(result.Contains("Thanks! Here is your soda. Your change is 20 cents."));
        }

        [TestMethod]
        public void StringTest02()
        {
            strReader = new StringReader("10");
            strWriter = new StringWriter();
            Console.SetOut(strWriter);
            Console.SetIn(strReader);

            Program.Main(null);

            string result = strWriter.ToString();

            Assert.IsTrue(
                result.Contains("You have inserted 10 cents") &&
                result.Contains("Please enter 25 cents more to complete your transaction."));
        }

        [TestMethod]
        public void StringTest03()
        {
            strReader = new StringReader("101");
            strWriter = new StringWriter();
            Console.SetOut(strWriter);
            Console.SetIn(strReader);

            Program.Main(null);

            string result = strWriter.ToString();

            Assert.IsTrue(
                result.Contains("You have inserted 101 cents") &&
                result.Contains("Please enter less than a dollar to complete your transaction."));
        }
    }
}

