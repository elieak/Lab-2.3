using System;

namespace GuessingGame
{
    public static class CheckUserInput
    {
        public static string InputCheck(int usrInput, int secretNumber, int count, int maxGuesses)
        {
            if (usrInput == secretNumber && count <= maxGuesses)
            {
                return ($"Congrats it took you " + count + "of " + maxGuesses + " tries to guess the secret number " +
                        secretNumber);
            }
            if (usrInput > secretNumber && count <= maxGuesses)
            {
                return ($"Number is too big, try again: ");
            }
            if (usrInput < secretNumber && count <= maxGuesses)
            {
                return ($"Number is too small, try again: ");
            }
            return ($"You Failed! The number was: " + secretNumber);
        }
    }

    class GuessingGame
    {
        static void Main()
        {
            Random rand = new Random();
            int secret = rand.Next(1, 101);
            const int MaxGuesses = 7;
            int userInput;
            bool isGuessed = false;

            Console.WriteLine("--- The computer has generated a secret number between 1 - 100, Try to guess it ---");

            Console.Write("Enter your guess: ");
            int.TryParse(Console.ReadLine(), out userInput);

            for (int count = 0; count <= MaxGuesses; ++count)
            {
                Console.Write(count + ": " + secret + " : " + CheckUserInput.InputCheck(userInput, secret, count, MaxGuesses));
            }
        }
    }
}
