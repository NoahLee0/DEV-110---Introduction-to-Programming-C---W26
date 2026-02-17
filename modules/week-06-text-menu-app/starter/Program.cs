/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Xml.Linq;

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider


        string title = "Text Menu Studio";
        string subtitle = "String + Console Output Patterns";
        string divider = new String('=', 48);

        Console.WriteLine($"{divider} \n{title} \n{subtitle} \n{divider} \n");

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        Console.ForegroundColor = ConsoleColor.DarkBlue;



        do
        {
            Console.WriteLine("- 1) Greeting Card \n" +
            "- 2) Name Tag Formatter \n" +
            "- 3) Phrase Analyzer \n" +
            "- 4) Fancy Receipt Line \n" +
            "- 5) Menu Banner Builder \n" +
            "- 6) Exit");

            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"\n{divider} \nOPTION 1: Greeting Card \n{divider}");
                    string name = ReadString("Enter your name: ").Trim();
                    string note = ReadString("Enter a short message: ").Trim();
                    Console.WriteLine("\n+--------------------------------------+");
                    Console.WriteLine(String.Format("| Hello, {0}", name.ToUpper()));
                    Console.WriteLine($"| Message: {note}");
                    Console.WriteLine("+--------------------------------------+\n\n");
                    break;
                case 2:
                    Console.WriteLine($"\n{divider} \nOPTION 2: Name Tag Formatter \n{divider}");
                    string fName = ReadString("Enter your first name: ").Trim();
                    string lName = ReadString("Enter your last name: ").Trim();
                    char fInitial = fName[0];
                    char lInitial = lName[0];
                    Console.WriteLine($"\nNametag: [{fName} {lName}] \n" +
                    $"Initials: [{Char.ToUpper(fInitial)}{Char.ToUpper(lInitial)}]\n" +
                    $"Lowercase: [{fName.ToLower()} {lName.ToUpper()}]\n\n");
                    break;
                case 3:
                    Console.WriteLine($"\n{divider} \nOPTION 3: Phrase Analyzer \n{divider}");
                    Console.WriteLine("Enter a phrase: ");
                    string phrase = Console.ReadLine().Trim().ToLower();
                    string hasA;
                    if (phrase.Contains('a'))
                    {
                        hasA = "contains 'a'";
                    } else
                    {
                        hasA = "does not contain 'a'";
                    }
                    string phraseDash = phrase.Replace(' ', '-');
                    string[] phraseList = phrase.Split(' ');
                    Console.WriteLine($"\nLength: {phrase.Length}\n" +
                    $"{hasA}\n" +
                    $"\"{phraseDash}\"\n" +
                    $"word list: {string.Join(", ", phraseList)}");
                    break;
                case 4:
                    Console.WriteLine($"\n{divider} \nOPTION 4: Fancy Receipt Line \n{divider}");
                    Console.WriteLine("Enter item name: ");
                    string item = Console.ReadLine();
                    double price = ReadDouble("Enter price: ");
                    int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);
                    double total = price * quantity;
                    Console.WriteLine(string.Format("{0, -15} {1, 5} {2, 10}", "ITEM", "QTY", "TOTAL"));
                    Console.WriteLine(string.Format("{0, -15} {1, 5} {2, 10:C2}\n", item, quantity, total));
                    break;
                case 5:
                    Console.WriteLine($"\n{divider} \nOPTION 5: Menu Banner Builder \n{divider}");
                    title = ReadString("Enter a title: ").ToUpper();
                    subtitle = ReadString("Enter a subtitle: ");
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    divider = new string('=', width);

                    Console.WriteLine($"\nCentered:\n" +
                    $"{divider}\n" +
                    $"{title.PadLeft((width + title.Length)/2)} \n" +
                    $"{subtitle.PadLeft((width + subtitle.Length)/2)} \n" +
                    $"{divider}\n");

                    Console.WriteLine($"Left:\n" +
                    $"{divider}\n" +
                    $"{title} \n" +
                    $"{subtitle} \n" +
                    $"{divider}\n");

                    Console.WriteLine($"Right:\n" +
                    $"{divider}\n" +
                    $"{title.PadLeft(width)} \n" +
                    $"{subtitle.PadLeft(width)} \n" +
                    $"{divider}\n");
                    break;
            }
        } while (choice != 6);

        string closer = ReadString("Enter a closing word: ");
        Console.WriteLine($"Closing word is \"goodbye\": {closer.Equals("goodbye", StringComparison.OrdinalIgnoreCase)}");

        Console.Write("First 3 letters: ");
        if (closer.Length <= 3)
        {
            Console.Write(closer);
        } else
        {
            Console.Write(closer.Substring(0, 3));
        }

        Console.WriteLine($"Closing word ends with \'!\': {closer.EndsWith('!')}");


        if (closer.IndexOf(' ') > 0)
        {
            Console.WriteLine($"Closing word has \' \' character at index {closer.IndexOf(' ')}");
        } else
        {
            Console.WriteLine("Closing word does not have \' \' character");
        }
        Console.WriteLine("Goodbye!");
        {
            // TODO 3: Print the menu box
            // Required menu option texts (tests check for these):
            // - 1) Greeting Card
            // - 2) Name Tag Formatter
            // - 3) Phrase Analyzer
            // - 4) Fancy Receipt Line
            // - 5) Menu Banner Builder
            // - 6) Exit

            // TODO 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6

            // TODO 5: Use a switch statement to handle each menu option

            // ===== OPTION 1: Greeting Card =====
            // Prompts: "Enter your name: " and "Enter a short message: "
            // Required string operations:
            // - Use Trim() to clean up the name
            // - Use ToUpper() for an uppercase version
            // - Use concatenation OR interpolation for greeting text
            // - Use string.Format() for at least one output line
            // - Display a boxed card with the name, uppercase name, and message
            // Include the word "Message:" in your output

            // ===== OPTION 2: Name Tag Formatter =====
            // Prompts: "Enter first name: " and "Enter last name: "
            // Required string operations:
            // - Use Trim() on both inputs
            // - Use concatenation to build full name
            // - Use string indexing to get first characters for initials
            // - Use ToUpper() for initials
            // - Use ToLower() for lowercase version
            // Display three things:
            // - Name tag with the full name (include a bracket [)
            // - Initials (use word "Initials:" in label)
            // - Lowercase version (use word "Lowercase:" in label)

            // ===== OPTION 3: Phrase Analyzer =====
            // Prompt: "Enter a phrase: "
            // Required string operations:
            // - Use Trim() on input
            // - Use Length property
            // - Use Contains() to check for letter 'a' (convert to lowercase first)
            // - Use Replace() to change spaces to dashes
            // - Use Split() to break into words
            // - Use string.Join() to create comma-separated list
            // Display: length, contains check, dashed version, and words list

            // ===== OPTION 4: Fancy Receipt Line =====
            // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
            // Use ReadDouble for price and ReadIntInRange for quantity
            // Required:
            // - Calculate total (price * quantity)
            // - Create a receipt table with header row (ITEM, QTY, TOTAL)
            // - Use string.Format() with composite formatting for the data row
            // - Use alignment specifiers (left/right alignment)
            // - Use currency format specifier (:C2) for the total

            // ===== OPTION 5: Menu Banner Builder =====
            // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
            // Use ReadIntInRange for width (min=30, max=60)
            // Required string operations:
            // - Create border line with equals signs (use new string constructor)
            // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
            // - Use ToUpper() on title
            // - Display banner with borders and centered text
            // - Show three alignment examples (centered, left, right)

            // ===== OPTION 6: Exit with String Analysis =====
            // Prompt: "Enter a closing word: "
            // Required string operations (demonstrate these 4 methods):
            // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
            // - Use Substring() to extract first 3 characters (check length first!)
            // - Use EndsWith() to check if ends with "!"
            // - Use IndexOf() to find position of space character
            // Display the results of all four operations
            // Then print: "Goodbye!"

            // TODO 6: Add a blank line between menu actions (but not after Exit)
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // TODO 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number

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
            Console.WriteLine();
        } while (!isValid || value > max || value < min);

        return value;
    }

    private static string ReadString(string prompt)
    {
        Console.WriteLine(prompt + "\n");

        return Console.ReadLine();
    }

    private static double ReadDouble(string prompt)
    {
        bool isValid;
        double value;
        do
        {
            Console.WriteLine(prompt);
            isValid = double.TryParse(Console.ReadLine(), out value);
            if (!isValid)
            {
                Console.WriteLine($"Enter a number.");
            }
            Console.WriteLine();
        } while (!isValid);

        return value;
    }
}
