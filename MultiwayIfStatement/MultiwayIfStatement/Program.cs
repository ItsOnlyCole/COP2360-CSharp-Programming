using System;

namespace MultiwayIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Enter your age: ");
            age=Convert.ToInt32(System.Console.ReadLine());

            if (age>24)
            {
                Console.WriteLine("\nYou are an adult. Do what ever you want.");
            }
            else if (age>17)
            {
                Console.WriteLine("\nYou can vote, but you can't rent a car.");
            }
            else if (age>15)
            {
                Console.WriteLine("\nYou can drive, but you can't vote.");
            }
            else
            {
                Console.WriteLine("\nYou're a kid, you can't drive or do anything really. Come back in a couple of years.");
            }

            Console.Write("\nPress Enter to close.");
            Console.ReadKey();

        }
    }
}

