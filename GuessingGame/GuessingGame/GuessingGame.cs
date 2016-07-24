using System;
using static System.Console;

namespace GuessingGame
{
    //When an invalid number is inputed, your logic always consider it a '0'.
    internal static class GuessingGame
    {
        private static void Main()
        {
            WriteLine("Welcome to Guess a Number Program (1-100) with in 7 attempts.");
            var rand = new Random();
            var secretNumber = rand.Next(1, 101);
            const int maxTries = 7;

            var isGuessed = false;

            for (var i = 1; i <= maxTries; i++)
            {
                //C# 6 feature (string interpolation) - nice.
                Write($"ATTEMPT {i} : Enter your number: ");
                int userInput;
                int.TryParse(ReadLine(), out userInput);
                if (userInput == secretNumber)
                {
                    WriteLine($"Congrats! You have guessed the number correctly in {i} tries");
                    isGuessed = true;
                    break;
                }
                if (userInput > secretNumber)
                {
                    WriteLine("Number too big");
                }
                if (userInput < secretNumber)
                {
                    WriteLine("Number too small");
                }
            }
            if (isGuessed == false)
            {
                WriteLine("Unfortunately you did not guess it correctly. The correct number is: " + secretNumber);
            }
        }
    }
}