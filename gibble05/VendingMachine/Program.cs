// Exercise 05.1
// Gibble, Jay ejg2
using System;
//using System.Collections.Generic;

namespace VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice initialPrice = new PurchasePrice(0.35M);
            decimal sodaPrice = initialPrice.PriceDecimal;
            CanRack sodaRack = new CanRack();

            //List<Flavor> shallowCopy = FlavorOps.AllFlavors;
            ////shallowCopy.Clear();

            //foreach (Flavor f in FlavorOps.AllFlavors)
            //{
            //    Console.WriteLine(f);
            //}

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine.");

            bool timeToExit;
            do
            {
                sodaRack.DisplayCanRack();
                Console.Write($"Please insert {sodaPrice:c} worth of coins: ");

                decimal totalValueInserted = 0M;
                while (totalValueInserted < sodaPrice)
                {
                    string coinNameInserted = Console.ReadLine().ToUpper();
                    Coin coinInserted = new Coin(coinNameInserted);
                    Console.WriteLine($"You have inserted a {coinInserted} worth {coinInserted.ValueOf:c}");

                    totalValueInserted += coinInserted.ValueOf;
                    Console.WriteLine($"Total value inserted is {totalValueInserted:c}");
                }

                bool canDispensed = false;
                while (!canDispensed)
                {
                    Console.Write("What flavor would you like? : ");
                    string flavorName = Console.ReadLine().ToUpper();

                    // 05.1
                    Flavor flavor = FlavorOps.ToFlavor(flavorName);

                    if (!sodaRack.IsEmpty(flavor))
                    {
                        sodaRack.RemoveACanOf(flavor);
                        Console.WriteLine($"Thanks, here is your can of {flavor}.");
                        canDispensed = true;
                    }
                    else
                    {
                        Console.WriteLine($"We are out of {flavor}");
                    }
                }

                Console.Write("Exit the vending machine? (Y/N): ");
                string response = Console.ReadLine();
                timeToExit = response.Trim().ToUpper().StartsWith("Y");

            } while (!timeToExit);
        }
    }
}

