/*
Author: Cole Hemp
Program: TempConverter.cs
About: Takes User's input for temperature in Fahrenheit, converts it to Celsuis, and then Outputs it to Console.
*/

using System;

namespace TemperatureConverter
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            int tempInF = SetTempInF();
            int tempInC = ConvertFToC(tempInF);

            OutputConversion(tempInF, tempInC);

            Exit();
        }

        static int SetTempInF()
        {
            //reads user's input, and if invalid input is used, notifies user then closes.
            int temp = 0;

            Console.Write("Input a temperature in Fahrenheit: ");
            try
            {
                temp = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Input!");
                Console.ResetColor();
                Console.Write("\nPress Enter to close");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return temp;
        }

        static int ConvertFToC(int tempInF)
        {
            int tempInC;

            //Formula to convert Fahrenheit to Celsius: T(°C) = (T(°F) - 32) × 5/9
            tempInC = (tempInF-32)*5/9;

            return tempInC;
        }

        static void OutputConversion(int tempInF, int tempInC)
        {
            //Clears and outputs the header centered
            char degree = '\u00B0';

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0,20}", "Temperature");
            Console.ResetColor();
            Console.WriteLine("\nFahrenheit{0,16}", "Celsius");

            Console.Write("\n{0,5}{1}F", tempInF, degree);
            Console.WriteLine("{0,16}{1}C", tempInC, degree);
        }

        static void Exit()
        {
            //Gives a user the option to exit instead of program automatically closing after running OutputConversion
            Console.Write("\nPress Enter to Exit");
            Console.ReadKey();
        }
    }
}
