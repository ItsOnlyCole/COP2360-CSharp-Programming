﻿//Cole Hemp
//MultiplicationTables.cs
//Allows the user to input a number range between 2 and 8 then generates a 25 row multiplication table for that range.

using System;

namespace MultiplicationTables
{
    class MultiplicationTables
    {
        static void Main(string[] args)
        {
            int[] baseValueRange = new int[2];

            Console.WriteLine("Welcome to the Multiplication Table! \nGenerate a multiplication table of 25 rows for a range from 2 to 8.\n");

            //Gets the starting and ending Values
            baseValueRange = InputBaseValueRange();

            //Outputs Multiplication table
            OutputMultiplicationTable(baseValueRange[0], baseValueRange[1], 25);

            Console.ReadKey();
        }

        static int[] InputBaseValueRange()
        {
            int[] baseValueRange = new int[2];
            bool check;

            for (int i = 0; i < 2; i++)
            {
                check = true;
                while (check == true)
                {
                    if (i == 0)
                    {
                        Console.Write("Input any starting value from 2 to 8: ");
                    }
                    else
                    {
                        Console.Write("Input any ending value from " + baseValueRange[0] + " to 8: ");
                    }

                    //Catches if input is not an int.
                    try
                    {
                        baseValueRange[i] = Convert.ToInt32(Console.ReadLine());

                        //Checks if input is between 2 and 8 (or between starting value and 8 if on second value)
                        if (i == 0)
                        {
                            if (baseValueRange[i] < 2 || baseValueRange[i] > 8)
                            {
                                Console.WriteLine(baseValueRange[0] + " is not in the range of 2 to 8!");
                            }
                            //If starting value is 8, sets ending value to 8 then returns baseValueRange[].
                            else if (baseValueRange[i] == 8)
                            {
                                Console.WriteLine("Ending Value automatically set to 8.");
                                baseValueRange[1] = 8;
                                return baseValueRange;
                            }
                            else
                            {
                                check = false;
                            }
                        }
                        else
                        {
                            if (baseValueRange[1] < baseValueRange[0] + 1 || baseValueRange[i] > 8)
                            {
                                Console.WriteLine(baseValueRange[1] + " is not in the range of " + baseValueRange[0] + " to 8!");
                            }
                            else
                            {
                                check = false;
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Input!");
                    }
                }
            }

            return baseValueRange;
        }

        static void OutputMultiplicationTable(int startingValue, int endingValue, int numberOfRows)
        {
            //Creates Header
            Console.Write("\nn");
            for (int i = startingValue; i < endingValue + 1; i++)
            {
                Console.Write("\t" + i);
            }
            //Adds extra line break between the header and actual table.
            Console.WriteLine("\n");

            //Runs for each row
            for (int i = 1; i < numberOfRows + 1; i++)
            {
                Console.Write(i);
                //Runs for each column starting with startingValue and ending with endingValue.
                for (int j = startingValue; j < endingValue + 1; j++)
                {
                    Console.Write("\t"+(i*j));
                }
                //Breaks the line and starts a new row
                Console.WriteLine();
            }
        }
    }
}
