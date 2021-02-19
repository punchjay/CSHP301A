// Exercise 05
// Gibble, Jay ejg2
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using VendingMachine;

namespace CommandLineTest
{
    [TestClass]
    public class CommandLineTest
    {
        [TestMethod]
        public void ProcessOrderViaCommandLine()
        {
            StringReader sr = new StringReader(
                "Quarter" + Environment.NewLine +
                "Quarter" + Environment.NewLine + 
                "Lemon"   + Environment.NewLine +
                "y"       + Environment.NewLine);

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Console.SetIn(sr);

            Program.Main(new string[] { "Orange", "Quarter", "Quarter" });

            string result = sw.ToString();

            Debug.WriteLine(result);

            Assert.IsTrue(
                result.Contains("your can of ORANGE") &&
                result.Contains("$0.15") &&
                result.Contains("your can of LEMON"));
        }
    }
}
