// Exercise 01 
// Gibble, Jay ejg2
using System;

namespace Assignment01CoreIntro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine.");
            Console.Write("Please insert 35 cents: ");

            int valueInserted = int.Parse(Console.ReadLine());
            var valueRemaining = 35 - valueInserted;
            bool valueInsertedUnder = valueInserted < 35;
            bool valueInsertedHigh = valueInserted > 100;
            bool valueInsertedOver = valueInserted >= 35;

            Console.WriteLine($"You have inserted {valueInserted} cents.");

            if (valueInsertedUnder) Console.WriteLine($"Please enter {valueRemaining} cents more to complete your transaction.");
            else if (valueInsertedHigh) Console.WriteLine($"Please enter less than a dollar to complete your transaction.");
            else if (valueInsertedOver) Console.WriteLine($"Thanks! Here is your soda. Your change is {valueRemaining * -1} cents.");
        }
    }
}
