namespace CalculatorLite;
using System;
using System.Diagnostics;
using System.Xml;
using static System.Console;
/**************************************************************
* Course: DEV 110
* Term: Winter 2026
*
* Programmer: <Noah Leee>
* Assignment: <Calculator Lite>
*
* Description:
* <Function as a calculator to do basic arithmetic>
*
**************************************************************/
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string name;
        bool useDecimals = false;
        string decPrecision;
        string attempt; //this is necessary to check in case the attempted value is a string instead of an int or double
        double num1 = 0;
        double num2 = 0;
        int calculations = 0;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();

        Console.WriteLine($"Hello {name}!" +
        "\nUse decimal precision? (yes/no)");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        decPrecision = Console.ReadLine();
        while (true)
        {
            if (String.Equals(decPrecision, "yes", StringComparison.OrdinalIgnoreCase))
            {
                useDecimals = true;
                break;
            }

            else if (String.Equals(decPrecision, "no", StringComparison.OrdinalIgnoreCase))
            {
                useDecimals = false;
                break;
            }

            else
            {
                Console.WriteLine("Please answer (yes) or (no).");
                decPrecision = Console.ReadLine();
            }
        }

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        Console.WriteLine("First number: ");
        attempt = Console.ReadLine();
        while (true)
        {
            if (useDecimals)
            {
                if (double.TryParse(attempt, out double value))
                {
                    num1 = value;
                    break;
                } else
                {
                    Console.WriteLine("Please enter a number.");
                    attempt = Console.ReadLine();
                }
            } else
            {
                if (int.TryParse(attempt, out int value))
                {
                    num1 = (double)value;
                    break;
                } else
                {
                    Console.WriteLine("Please enter a number.");
                    attempt = Console.ReadLine();
                }

            }
        }

        // TODO: Prompt user for second number (same type as first)
        Console.WriteLine("Second number: ");
        attempt = Console.ReadLine();
        while (true)
        {
            if (useDecimals)
            {
                if (double.TryParse(attempt, out double value))
                {
                    num2 = value;
                    break;
                } else
                {
                    Console.WriteLine("Please enter a number.");
                    attempt = Console.ReadLine();
                }
            } else
            {
                if (int.TryParse(attempt, out int value))
                {
                    num2 = (double)value;
                    break;
                } else
                {
                    Console.WriteLine("Please enter a number.");
                    attempt = Console.ReadLine();
                }

            }
        }

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"

        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        if (useDecimals)
        {
            Console.WriteLine($"\nAddition: {(num1 + num2).ToString("F2")} \n" +
            $"Difference: {(num1 - num2).ToString("F2")} \n" +
            $"Product: {(num1 * num2).ToString("F2")}");
            calculations = 3;
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            } else
            {
                Console.WriteLine($"Division: {(num1 / num2).ToString("F2")} \n" +
            $"Modulus: {(num1 % num2).ToString("F2")}");
            calculations += 2;
            }
            Console.WriteLine($"Average: {((num1 + num2) / 2).ToString("F2")}");
            if (num1 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            } else
            {
                Console.WriteLine($"Percentage Difference: {((((num1 - num2) / num1) * 100).ToString("F2"))}% \n");
                calculations++;
            }
        } else
        {
        Console.WriteLine($"\nAddition: {(num1 + num2).ToString("F0")} \n" +
            $"Difference: {(num1 - num2).ToString("F0")} \n" +
            $"Product: {(num1 * num2).ToString("F0")}");
            calculations = 3;
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            } else
            {
                Console.WriteLine($"Division: {(num1 / num2).ToString("F0")} \n" +
            $"Modulus: {(num1 % num2).ToString("F0")}");
            calculations += 2;
            }
            Console.WriteLine($"Average: {((num1 + num2) / 2).ToString("F0")}");
            if (num1 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            } else
            {
                Console.WriteLine($"Percentage Difference: {((((num1 - num2) / num1) * 100).ToString("F0"))}% \n");
                calculations++;
            }
        }
        Console.WriteLine($"Performed {calculations} calculations for {name}.");
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
