// Exercise 05.1 - 05.3
// Gibble, Jay ejg2
using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice initialPrice = new PurchasePrice(0.35M);
            decimal sodaPrice = initialPrice.PriceDecimal;
            CanRack sodaRack = new CanRack();
            CoinBox changeBox = new CoinBox(new List<Coin> {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

            //List<Flavor> shallowCopy = FlavorOps.AllFlavors;
            ////shallowCopy.Clear();

            //foreach (Flavor f in FlavorOps.AllFlavors)
            //{
            //    Console.WriteLine(f);
            //}

            Console.WriteLine($"Welcome to the .NET C# Soda Vending Machine.");

            Console.WriteLine($"Contents of Coin Box:");

            Console.WriteLine($"{changeBox.HalfDollarCount}\tHalf Dollar(s)");
            Console.WriteLine($"{changeBox.QuarterCount}\tQuarter(s)");
            Console.WriteLine($"{changeBox.DimeCount}\tDime(s)");
            Console.WriteLine($"{changeBox.NickelCount}\tNickel(s)");
            Console.WriteLine($"{changeBox.SlugCount}\tSlug(s)");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Total value in coin box is {changeBox.ValueOf:c}");


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
                    
                    // 05.3
                    changeBox.Deposit(coinInserted);
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

