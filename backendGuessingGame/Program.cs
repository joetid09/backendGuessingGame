using System;

namespace backendGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a secret number: ");
            string guess = Console.ReadLine();
            string secretNumber = ("43");

            if (guess == secretNumber)
            {
                Console.Write("Congratulations, you have guessed correctly!");
            }
            else
            {
                Console.Write("Uh Oh, that was incorrect.... try again?");
            }
        }
    }
}
