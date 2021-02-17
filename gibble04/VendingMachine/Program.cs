// Exercise 04 
// Gibble, Jay ejg2
using System;

namespace VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice initialPrice = new PurchasePrice(0.35M);
            decimal sodaPrice = initialPrice.PriceDecimal;
            CanRack sodaRack = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine.");

            //2.6 - 2.7 this broke string tests
            Boolean timeToExit = false;
            do
            {
                sodaRack.DisplayCanRack();
                Console.Write("Please insert {0:c} worth of coins: ", sodaPrice);

                decimal totalValueInserted = 0M;
                while (totalValueInserted < sodaPrice)
                {
                    // get the coin inserted
                    string coinNameInserted = Console.ReadLine().ToUpper();
                    Coin coinInserted = new Coin(coinNameInserted);
                    Console.WriteLine("You have inserted a {0} worth {1:c}", coinInserted, coinInserted.ValueOf);

                    // running total of the value of the coins inserted
                    totalValueInserted += coinInserted.ValueOf;
                    Console.WriteLine("Total value inserted is {0:c}", totalValueInserted);
                }

                // select a flavor of soda
                Boolean canDispensed = false;
                while (!canDispensed)
                {
                    Console.Write("What flavor would you like? : ");
                    string flavorName = Console.ReadLine().ToUpper();

                    // oooh, this looks like trouble. Why?
                    Flavor flavor = (Flavor)Enum.Parse(typeof(Flavor), flavorName);

                    if (!sodaRack.IsEmpty(flavor))
                    {
                        sodaRack.RemoveACanOf(flavor);
                        Console.WriteLine("Thanks, here is your can of {0}.", flavor);
                        canDispensed = true;
                    }
                    else
                    {
                        Console.WriteLine("We are out of {0}", flavor);
                    }
                }

                Console.Write("Exit the vending machine? (y/n): ");
                string response = Console.ReadLine();
                timeToExit = response.Trim().ToUpper().StartsWith("Y");

            } while (!timeToExit);
        }
    }
}

