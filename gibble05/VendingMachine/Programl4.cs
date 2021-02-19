//// Exercise 04.1 - 4.2 
//// Gibble, Jay ejg2
//using System;

//namespace VendingMachine
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            PurchasePrice initialPrice = new PurchasePrice(0.35M);
//            decimal sodaPrice = initialPrice.PriceDecimal;
//            CanRack sodaRack = new CanRack();

//            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine.");

//            // 2.6 - 2.7 
//            // TODO: this broke string tests in StringUnitTest.cs, marked as [IGNORE], loop back to fix
//            bool timeToExit;
//            do
//            {
//                sodaRack.DisplayCanRack();
//                Console.Write($"Please insert {sodaPrice:c} worth of coins: ");

//                decimal totalValueInserted = 0M;
//                while (totalValueInserted < sodaPrice)
//                {
//                    string coinNameInserted = Console.ReadLine().ToUpper();
//                    Coin coinInserted = new Coin(coinNameInserted);
//                    Console.WriteLine($"You have inserted a {coinInserted} worth {coinInserted.ValueOf:c}");

//                    totalValueInserted += coinInserted.ValueOf;
//                    Console.WriteLine($"Total value inserted is {totalValueInserted:c}");
//                }

//                bool canDispensed = false;
//                while (!canDispensed)
//                {
//                    Console.Write("What flavor would you like? : ");
//                    string flavorName = Console.ReadLine().ToUpper();

//                    Flavor flavor = (Flavor)Enum.Parse(typeof(Flavor), flavorName);

//                    if (!sodaRack.IsEmpty(flavor))
//                    {
//                        sodaRack.RemoveACanOf(flavor);
//                        Console.WriteLine($"Thanks, here is your can of {flavor}.");
//                        canDispensed = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine($"We are out of {flavor}");
//                    }
//                }

//                Console.Write("Exit the vending machine? (Y/N): ");
//                string response = Console.ReadLine();
//                timeToExit = response.Trim().ToUpper().StartsWith("Y");

//            } while (!timeToExit);
//        }
//    }
//}

