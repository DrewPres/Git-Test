using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I have a number between 0 and 100....so guess it!");
            Random randNumGen = new Random();
            int start, end;
            Console.WriteLine("Starting number:");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Ending number:");
            end = int.Parse(Console.ReadLine());
            int randNum = randNumGen.Next(start, end);
            int userGuess = 0;
            bool correct = false;
            int guesses = 0;
            while (correct == false)
            {
                Console.WriteLine("Enter your number");
                int guess;
                guess = int.Parse(Console.ReadLine());
                if(guess == randNum)
                {
                    Console.WriteLine("You guessed correct!");
                    Console.WriteLine("Your guesses " + guesses + "!");
                    Console.ReadLine();
                    correct = true;
                }
                if(guess > randNum)
                {
                    Console.WriteLine("Your guess is too high!");
                    guesses = guesses + 1;
                }
                else
                {
                    Console.WriteLine("Your guess is too low!");
                    guesses = guesses + 1;
                }
            }

        }
    }
}
