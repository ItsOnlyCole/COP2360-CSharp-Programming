//Cole Hemp
//Tip Calculator
//Generates Recommended 15% and 20% tips based on inputed subtotal amount.

using System;


namespace TipCalculatingApplication
{
    class TipCalculator
    {
        static void Main(string[] args)
        {
            Double subtotal;
            Double fifteenPercentTip;
            Double fifteenPercentTipTotal;
            Double twentyPercentTip;
            Double twentyPercentTipTotal;

            System.Console.Write("Insert subtotal price: $");
            subtotal = Convert.ToDouble(System.Console.ReadLine());

            fifteenPercentTip = calculateFifteenPercentTip(subtotal);
            fifteenPercentTipTotal = subtotal + fifteenPercentTip;

            twentyPercentTip = calculateTwentyPercentTip(subtotal);
            twentyPercentTipTotal = subtotal + twentyPercentTip;

            System.Console.WriteLine("Subtotal:{0,8:C2}", subtotal);
            System.Console.WriteLine("\n15% Tip:{0,8:C2}     Total:{1,8:C2}", fifteenPercentTip, fifteenPercentTipTotal);
            System.Console.WriteLine("20% Tip:{0,8:C2}     Total:{1,8:C2}", twentyPercentTip, twentyPercentTipTotal);

            System.Console.Write("\nPress Any Key to Exit");
            System.Console.ReadKey();
        }

        static Double calculateFifteenPercentTip(Double subtotal)
        {
            Double tipAmount;

            tipAmount = subtotal * .15;

            return tipAmount;
        }

        static double calculateTwentyPercentTip(Double subtotal)
        {
            Double tipAmount;

            tipAmount = subtotal * .2;

            return tipAmount;
        }
    }
}
