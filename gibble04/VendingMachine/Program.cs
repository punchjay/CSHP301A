﻿//// Exercise 04.1 - 4.2 
//// Gibble, Jay ejg2
using System;

namespace VendingMachine
{
    public class Program
    {
        static VendingMachine sodaVendingMach = new VendingMachine();
        static PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        static void processCommandLine(string[] args)
        {
            OrderProcessor sodaOrder = new OrderProcessor();
            sodaOrder.CreateOrder(args);
            sodaOrder.fulfillOrder(sodaVendingMach, sodaPrice);
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            sodaVendingMach.sodaPrice = sodaPrice;
            processCommandLine(args);
            sodaVendingMach.Vend();
        }

    }
}


