using System;

namespace backendGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            Console.WriteLine($" secret number: {secretNumber}");

            Console.WriteLine("What mode would you like to play? Easy, Medium, or Hard");
            string choiceInput = Console.ReadLine();
            string mode = choiceInput.ToLower();

            if (mode == "easy")
            {
                easy(secretNumber);
            }
            else if (mode == "medium")
            {
                medium(secretNumber);
            }
            else if (mode == "hard")
            {
                hard(secretNumber);
            }
            else if (mode == "cheats")
            {
                cheats(secretNumber);
            }
        }
        static void easy(int secretNumber)
        {
            for (int i = 1; i < 9; i++)
            {
                Console.Write("Guess a secret number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations, you have guessed correctly!");
                    break;
                }
                else if (i < 8)
                {
                    if (guess > secretNumber)
                    {
                        Console.WriteLine($"Your guess {guess} was too high. You have {8 - i} tries left,  try again?");
                    }
                    else
                    {
                        Console.WriteLine($"Your guess {guess} was too low. You have {8 - i} tries left,  try again?");
                    }

                }
                else
                {
                    Console.WriteLine($"8 guesses and still wrong?? I'm cutting you off, get outta HERE!");
                }
            }
        }
        static void medium(int secretNumber)
        {
            for (int i = 1; i < 7; i++)
            {
                Console.Write("Guess a secret number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations, you have guessed correctly!");
                    break;
                }
                else if (i < 6)
                {
                    if (guess > secretNumber)
                    {
                        Console.WriteLine($"Your guess {guess} was too high. You have {6 - i} tries left,  try again?");
                    }
                    else
                    {
                        Console.WriteLine($"Your guess {guess} was too low. You have {6 - i} tries left,  try again?");
                    }

                }
                else
                {
                    Console.WriteLine($"6 guesses and still wrong?? I'm cutting you off, get outta HERE!");
                }
            }
        }
        static void hard(int secretNumber)
        {
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
                    if (guess > secretNumber)
                    {
                        Console.WriteLine($"Your guess {guess} was too high. You have {4 - i} tries left,  try again?");
                    }
                    else
                    {
                        Console.WriteLine($"Your guess {guess} was too low. You have {4 - i} tries left,  try again?");
                    }

                }
                else
                {
                    Console.WriteLine($"4 guesses and still wrong?? I'm cutting you off, get outta HERE!");
                }
            }
        }
        static void cheats(int secretNumber)
        {
            for (int i = 1; i >= 0; i++)
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
                    if (guess > secretNumber)
                    {
                        Console.WriteLine($"Your guess {guess} was too high. You have {4 - i} tries left,  try again?");
                    }
                    else
                    {
                        Console.WriteLine($"Your guess {guess} was too low. You have {4 - i} tries left,  try again?");
                    }

                }
                else
                {
                    Console.WriteLine($"4 guesses and still wrong?? I'm cutting you off, get outta HERE!");
                }
            }
        }
    }
}
