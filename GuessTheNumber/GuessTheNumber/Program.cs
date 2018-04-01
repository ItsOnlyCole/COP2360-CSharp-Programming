using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           Random randomizer = new Random();
            int counter = 1;
            int magicNumber = randomizer.Next(1, 100);
            int userGuess = 0;

            Console.WriteLine("Welcome to Guess The Number!\nYou have 7 chances to guess the number between 1 and 100.\nIf you're too high or too low, we'll tell you.\n");
            for( ;counter < 8 && userGuess != magicNumber; counter++)
            //while(counter < 8 && userGuess != magicNumber)
            {
                Console.Write("Guess #" + counter + ": ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                if(userGuess > magicNumber)
                {
                    Console.WriteLine("\nToo high. " + (8 - counter) + " guesses left");
                }
                else if(userGuess < magicNumber)
                {
                    Console.WriteLine("\nToo low. " + (8 - counter) + " guesses left");
                }
                else
                {
                    //Do nothing if guess is correct.
                }
                //counter++;
            }

            if(userGuess == magicNumber)
            {
                Console.WriteLine("\n\nCongratulations!\nYou've guessed the right number!\n\nPress Enter to close the game.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sorry, but you didn't guess the right number.\nThe right number was "+magicNumber+".\n\nPress Enter to close the game.");
            }
        }
    }
}
