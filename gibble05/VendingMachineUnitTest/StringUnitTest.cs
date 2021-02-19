// Exercise 05
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
        [Ignore]
        public void StringTest01()
        {
            strReader = new StringReader("0.35M");
            Console.SetOut(strWriter);
            Console.SetIn(strReader);

            Program.Main(null);

            string result = strWriter.ToString();

            Assert.IsTrue(result.Contains("Welcome to the .NET C# Soda Vending Machine."));
            Assert.IsTrue(result.Contains("Please insert $0.35 worth of coins: "));
        }
    }
}

