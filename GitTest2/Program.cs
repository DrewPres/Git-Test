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
            int randNum = randNumGen.Next(0, 100);
            int userGuess = 0;
            bool correct = false;
            while(correct == false)
            {
                int guesses = 0;
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
                    guesses++;
                }
                else
                {
                    Console.WriteLine("Your guess is too low!");
                    guesses++;
                }
            }

        }
    }
}
