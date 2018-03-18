//Cole Hemp
//COP2360
//3/18/18
//Program.cs
//A class dedicated to testing the functionality of StateAreaCodes.CS

using System;

namespace StateAreaCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string stateInitials = "FL";
            int[] areaCodes = new int[] { 305, 321, 352, 386, 407, 561, 727, 754, 772, 786, 813, 850, 863, 904, 941, 954 };
            int userInput;
            bool checkResults;

            StateAreaCodes testStateAreaCodes = new StateAreaCodes(stateInitials, areaCodes);

            Console.Write("Welcome to the Florida Area Code Check!\nInput an area code: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            checkResults = testStateAreaCodes.CheckForAreaCode(userInput);

            if (checkResults == true)
            {
                Console.WriteLine("\nCongrats! " + userInput + " is an area code in Florida.");
                Console.Write("All of Florida's area codes. \n" + testStateAreaCodes.ToString());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nSorry, " + userInput + " is not an area code in Florida.");
                Console.Write("All of Florida's area codes. \n" + testStateAreaCodes.ToString());
                Console.ReadKey();
            }
        }
    }
}
