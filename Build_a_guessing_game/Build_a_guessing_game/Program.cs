using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_a_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess="";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses=false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();

                    guessCount++;

                    if (guess != secretWord && guessCount == guessLimit - 1)
                    {
                        Console.WriteLine("Your guessing is not right. Next try will be your final guess");
                    }
                    else if(guess != secretWord && guessCount < guessLimit)
                    {
                        Console.WriteLine("Your guessing is not right. Please try again");
                    }                    
                }
                else
                {
                    Console.WriteLine("The answer is still not right. You are out of guesses");
                    outOfGuesses = true;
                }                
            }

            if (!outOfGuesses)
            {
                Console.Write("You Win!");
            }
            else
            {
                Console.Write("You Lose!");
            }

            Console.ReadLine();

        }
    }
}
