// Exercise 02.1 
// Gibble, Jay ejg2
using System;

namespace VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice initialPrice = new PurchasePrice(35);
            var sodaPrice = initialPrice.Price;
            CanRack sodaRack;

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine.");
            Console.Write($"Please insert {sodaPrice} cents: ");

            int valueInserted = int.Parse(Console.ReadLine());
            var valueRemaining = sodaPrice - valueInserted;
            bool valueInsertedUnder = valueInserted < sodaPrice;
            bool valueInsertedHigh = valueInserted > 100;
            bool valueInsertedOver = valueInserted >= sodaPrice;

            Console.WriteLine($"You have inserted {valueInserted} cents.");

            if (valueInsertedUnder) Console.WriteLine($"Please enter {valueRemaining} cents more to complete your transaction.");
            else if (valueInsertedHigh) Console.WriteLine($"Please enter less than a dollar to complete your transaction.");
            else if  (valueInsertedOver)
            {
                sodaRack = new CanRack();
                sodaRack.RemoveACanOf("LEMON");
                Console.WriteLine($"Thanks! Here is your soda. Your change is {valueRemaining * -1} cents."); 
            }
        }
    }
}

