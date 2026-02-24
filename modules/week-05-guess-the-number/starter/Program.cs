<<<<<<< HEAD
using System.Collections.Concurrent;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using Microsoft.Win32.SafeHandles;

=======
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc
namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        // TODO 1: Complete the helper method named ReadIntInRange
        // Why: It avoids repeating the same input-validation code for max value and rounds.

        // TODO 2: Get a valid max value (10-100) using ReadIntInRange
        // Prompt: "Enter a max value (10-100): "
        // Hint: int.TryParse() and range check (value >= 10 && value <= 100)
        // Store result in an int named maxValue

        // TODO 3: Get a valid number of rounds (1-3) using ReadIntInRange
        // Prompt: "How many rounds? (1-3): "
        // Hint: int.TryParse() and range check (value >= 1 && value <= 3)
        // Store result in an int named rounds

        // TODO 4: Use a for loop to repeat the game for each round
        // Example: for (int round = 1; round <= rounds; round++)
        // NOTE: The round header, secret number, and guessing loop are inside this for loop.

        // TODO 5: Display the round header (inside the for loop)
        // Example: Console.WriteLine($"\nRound {round} of {rounds}");

        // TODO 6: Generate a secret number in the range 1..max (inclusive)
        // Hint: Random random = new Random(maxValue + round);
        // Hint: int secret = random.Next(1, maxValue + 1);
        // NOTE: This should be inside the for loop so each round has a new secret.

        // TODO 7: Initialize guess tracking variables (inside the for loop)
        // Hint: int guess = 0; int guessCount = 0;

        // TODO 8: Use a while loop to keep asking until the guess is correct
        // Hint: while (guess != secret) { ... }
        // NOTE: Everything related to a single guess goes inside this while loop.

        // TODO 9: Read a guess and validate that it is a number (inside the while loop)
        // Prompt: $"Guess a number (1-{maxValue}): "
        // Hint: int.TryParse() and continue the loop if invalid
        // Hint: if parsing fails, skip feedback and ask again

        // TODO 10: Update guessCount and provide feedback (inside the while loop)
        // Track guessCount and print: "Too low.", "Too high.", or
        // "Correct! You got it in X guesses."

        // TODO 11: Print a closing message after all rounds finish
        // Example: "Thanks for playing!"
<<<<<<< HEAD

        int maxValue = ReadIntInRange("Enter a max value (10-100): ", 10, 100);
        int rounds = ReadIntInRange("How many rounds? (1-3): ", 1, 3);

        Random random = new Random();
        for (int round = 1; round <= rounds; round ++)
        {
            Console.WriteLine($"Round {round} out of {rounds}");
            int secret = random.Next(1, maxValue + 1);

            int guess = 0;
            int guessCount = 0;
            while (guess != secret)
            {
                Console.WriteLine($"Guess a number (1-{maxValue}): ");
                guess = ReadInt();
                guessCount ++;
                if (guess > secret)
                {
                    Console.WriteLine("Too high!");
                } else if (guess < secret)
                {
                    Console.WriteLine("Too low!");
                }
            }
            Console.WriteLine($"Correct! You got it in {guessCount} guesses! \n");
        }

        Console.WriteLine("Thank you for playing!");
=======
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc
    }

    // private static int ReadIntInRange(string prompt, int min, int max)
    // {
    // Requirements:
    // - Use a do-while loop
    // - Use int.TryParse() for input
    // - Repeat until the value is in range
    // -- Hint: !isValid || value < min || value > max
    // }
<<<<<<< HEAD
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        bool isValid;
        int value;

        do
        {
            Console.WriteLine(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value);
            if (!isValid || value > max || value < min)
            {
                Console.WriteLine($"Enter a number from {min} to {max}.");
            }
        }
        while(!isValid || value > max || value < min);

        return value;
    }

    private static int ReadInt()
    {
        bool isValid;
        int value;

        do
        {
            isValid = int.TryParse(Console.ReadLine(), out value);
            if (!isValid)
            {
                Console.WriteLine("Enter a number: ");
            }
        }
        while(!isValid);

        return value;
    }
=======
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc
}
