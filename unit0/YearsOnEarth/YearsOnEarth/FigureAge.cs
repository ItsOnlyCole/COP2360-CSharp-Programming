using System;
using static System.Console;

namespace YearsOnEarth
{
    class FigureAge
    {
        static void Main(string[] args)
        {
            int year, age;
            string name;
            string inputStringValue;

            Write(" What is your first name? ");
            name = ReadLine();
            WriteLine();

            Write(" In what year were you born? ");
            inputStringValue = ReadLine();
            year = int.Parse(inputStringValue);
            WriteLine();

            age = 2018 - year;

            WriteLine(" At the end of 2018, {0} will be {1} years young.", name, age);

            ReadKey();
        }
    }
}
