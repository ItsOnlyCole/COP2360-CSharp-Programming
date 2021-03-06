﻿//Cole Hemp
//Receipt.cs
//Used to generate receipts with accompaning data members of 
//Customer - numberID, name, address, and phoneNumber
//receiptNumber, dateOfPurchase, itemNumber, description, itemPrice, and quantity

using System;

namespace ReceiptCreator
{
    class Receipt
    {
        //Auto-Implemented Properties
        //Item and Receipt Properties
        public int ReceiptNumber { get; set; }
        public string DateOfPurchase { get; set; }
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; } = 1;

        //Customer Info Properties
        public int CustomerNumberID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public long CustomerPhoneNumber { get; set; }



        //Constructors
        //Default Constructor
        public Receipt()
        {
        }
        //Constructor using purchase info
        public Receipt(int receiptNumber, string dateOfPurchase, int itemNumber, string itemName, string itemDescription, double itemPrice, int itemQuantity)
        {
            this.ReceiptNumber = receiptNumber;
            this.DateOfPurchase = dateOfPurchase;
            this.ItemNumber = itemNumber;
            this.ItemName = itemName;
            this.ItemDescription = itemDescription;
            this.ItemPrice = itemPrice;
            this.ItemQuantity = itemQuantity;
        }
        //Constructor using customer info
        public Receipt(int customerNumberID, string customerName, string customerAddress, long customerPhoneNumber)
        {
            this.CustomerNumberID = customerNumberID;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.CustomerPhoneNumber = customerPhoneNumber;
        }
        //Constructor using all info
        public Receipt(int receiptNumber, string dateOfPurchase, int itemNumber, string itemName, string itemDescription, double itemPrice, int itemQuantity, int customerNumberID, string customerName, string customerAddress, long customerPhoneNumber)
        {
            this.ReceiptNumber = receiptNumber;
            this.DateOfPurchase = dateOfPurchase;
            this.ItemNumber = itemNumber;
            this.ItemName = itemName;
            this.ItemDescription = itemDescription;
            this.ItemPrice = itemPrice;
            this.ItemQuantity = itemQuantity;
            this.CustomerNumberID = customerNumberID;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.CustomerPhoneNumber = customerPhoneNumber;
        }




        //Methods
        //Generates total prices based on item price multiplied by the quantity
        public double calculateTotalPrice(double price, int quantity)
        {
            double totalPrice = price * quantity;
            return totalPrice;
        }

        //Converts data members to a string to be outputted
        public override string ToString()
        {
            return "Order Summary\n" +
                "Receipt Number: " + ReceiptNumber + "\n" +
                "Date of Purchase: " + DateOfPurchase + "\n" +
                "Item Number: " + ItemNumber + "\n" +
                "Item Name: " + ItemName + "\n" +
                "Item Description: " + ItemDescription + "\n" +
                string.Format("Item Price: {0:C2}\n", ItemPrice) +
                "Quantity: " + ItemQuantity + "\n" +
                string.Format("Total Cost: {0:C2}\n", calculateTotalPrice(ItemPrice, ItemQuantity)) +

                "\nCustomer Info\n" +
                "ID: " + CustomerNumberID + "\n" +
                "Name: " + CustomerName + "\n" +
                "Address: " + CustomerAddress + "\n" +
                string.Format("Phone Number: {0:(###) ###-####}", CustomerPhoneNumber);
        }
    }
}
