﻿//Cole Hemp
//TestReceipt.cs
//Simple Console application that tests the Receipt Class

using System;

namespace ReceiptCreator
{
    class TestReceipt
    {
        static void Main(string[] args)
        {
            //Testing the Default Constructor
            Receipt testReceipt1 = new Receipt()
            {
                ReceiptNumber = 154278654,
                DateOfPurchase = DateTime.Today.ToString("dd/MM/yyyy"),
                ItemNumber = 56,
                ItemName = "Strawberries",
                ItemDescription = "A box of Strawberries",
                ItemPrice = 2.64,
                ItemQuantity = 3,
                CustomerNumberID = 2353,
                CustomerName = "Mark Rott",
                CustomerAddress = "9832 LakeView Drive, Lake Worth, Fl 33463",
                CustomerPhoneNumber = 6548527530
            };

            System.Console.WriteLine("Testing default constructor.\n");
            System.Console.WriteLine(testReceipt1);

            System.Console.WriteLine("\n\nPress Enter to run test with Constructor using purchase info");
            System.Console.ReadKey();
            System.Console.Clear();



            //Testing Constructor with Purchase Info
            Receipt testReceipt2 = new Receipt(1236547, DateTime.Today.ToString("dd/MM/yyyy"), 78, "BlueBerries", "A Box of Blueberries", 3.24, 8)
            {
                CustomerNumberID = 2353,
                CustomerName = "Mark Rott",
                CustomerAddress = "9832 LakeView Drive, Lake Worth, Fl 33463",
                CustomerPhoneNumber = 6548527530
            };

            System.Console.WriteLine("Testing constructor using purchase info.\n");
            System.Console.WriteLine(testReceipt2);

            System.Console.WriteLine("\n\nPress Enter to run test with Constructor using customer info");
            System.Console.ReadKey();
            System.Console.Clear();



            //Testing Constructor with Customer Info
            Receipt testReceipt3 = new Receipt(4851, "Tom Thorton", "7852 LakeShore Drive, Lake Worth, Fl 33463", 9871238426)
            {
                ReceiptNumber = 154278654,
                DateOfPurchase = DateTime.Today.ToString("dd/MM/yyyy"),
                ItemNumber = 56,
                ItemName = "Strawberries",
                ItemDescription = "A box of Strawberries",
                ItemPrice = 2.64,
                ItemQuantity = 3,
            };

            System.Console.WriteLine("Testing constructor using customer info.\n");
            System.Console.WriteLine(testReceipt3);

            System.Console.WriteLine("\n\nPress Enter to run test with Constructor using all info");
            System.Console.ReadKey();
            System.Console.Clear();



            //Testing Constructor with All Info
            Receipt testReceipt4 = new Receipt(789654123, DateTime.Today.ToString("dd/MM/yyyy"), 152, "Cranberries", "A box of Cranberries", 1.58, 10, 7895, "Rudy Rott", "9832 LakeView Drive, Lake Worth, Fl 33463", 6548527532);

            System.Console.WriteLine("Testing constructor using all info.\n");
            System.Console.WriteLine(testReceipt4);

            System.Console.WriteLine("\n\nPress Enter to close program");
            System.Console.ReadKey();
        }

    }
}
