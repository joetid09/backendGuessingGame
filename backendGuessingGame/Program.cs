using System;

namespace backendGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a secret number: ");
            string guess = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"You guessed: {guess}");
        }
    }
}
