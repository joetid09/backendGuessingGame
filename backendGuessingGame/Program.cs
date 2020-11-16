using System;

namespace backendGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            Console.WriteLine($" secret number: {secretNumber}");

            for (int i = 1; i < 5; i++)
            {
                Console.Write("Guess a secret number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations, you have guessed correctly!");
                    break;
                }
                else if (i < 4)
                {
                    Console.WriteLine($"Your guess {guess} was incorrect. You have {4 - i} tries left,  try again?");
                }
                else
                {
                    Console.WriteLine($"4 guesses and still wrong?? I'm cutting you off, get outta HERE!");
                }
            }
        }
    }
}
