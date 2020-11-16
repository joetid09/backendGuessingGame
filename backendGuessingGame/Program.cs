using System;

namespace backendGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess a secret number: ");
                string guess = Console.ReadLine();
                string secretNumber = ("43");

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations, you have guessed correctly!");
                }
                else if (i < 3)
                {
                    Console.WriteLine("Uh Oh, that was incorrect.... try again?");
                }
                else if (i == 3)
                {
                    Console.WriteLine("I'm cutting you off, get outta HERE!");
                }
            }
        }
    }
}
