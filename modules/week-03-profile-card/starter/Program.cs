using System;
namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {


        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();
        Console.WriteLine("=== PERSONAL INFORMATION ===" +
        "\nEnter your full name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your hometown (city, state):");
        string hometown = Console.ReadLine();
        Console.WriteLine("Enter your favorite color:");
        string color = Console.ReadLine();
        Console.WriteLine("Enter your dream job:");
        string job = Console.ReadLine();


        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";
        Console.WriteLine("=== ACADEMIC INFORMATION ===" +
        "\nEnter your major:");
        string major = Console.ReadLine();
        Console.WriteLine("Enter your GPA:");
        double gpa = getNumber();
        while (true)
        {
            if (gpa >= 0 && gpa <= 4)
            {
                break;
            } else
            {
                Console.WriteLine("GPA must be between 0 and 4:");
                gpa = getNumber();
            }
        }
        Console.WriteLine("Enter your graduation year:");
        int gradYear = (int)getNumber();
        Console.WriteLine("Enter (yes) or (no) if you are a full time student:");
        bool isFullTime = false;
        string temp = Console.ReadLine();
        while (true)
        {
            if (temp.Equals("yes"))
            {
                isFullTime = true;
                break;
            } else if (temp.Equals("no"))
            {
                break;
            } else
            {
                Console.WriteLine("Enter (yes) or (no):");
                temp = Console.ReadLine();
            }

        }

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)
        Console.WriteLine("=== ADDITIONAL DETAILS ===" +
        "\nEnter your age:");
        int age = (int)getNumber();
        Console.WriteLine("Enter your height in inches:");
        double height = getNumber();
        Console.WriteLine("Enter your favorite number:");
        int favNum = (int)getNumber();



        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12
        int birthYear = 2026 - age;
        int yearsToGrad = gradYear - 2026;
        int heightF = (int)(height / 12);
        double heightI = (int)(height % 12);
        bool honorStudent = gpa >= 3.5;
        int ageMonths = age * 12;

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n\n\n╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine("\n=== PERSONAL INFORMATION ===\n" +
        name + "\n" +
        hometown + "\n" +
        $"Favorite color: {color}"  + "\n" +
        $"Favorite number: {favNum}" + "\n" +
        $"Dream job: {job}"  + "\n");

        Console.WriteLine("=== ACADEMIC DETAILS ==="  + "\n" +
        $"Major: {major}" + "\n" +
        $"GPA: {gpa.ToString("F2")}" + "\n" +
        $"Graduation year: {gradYear}");
        if (isFullTime)
        {
            Console.WriteLine("Fulltime student\n");
        } else
        {
            Console.WriteLine("Parttime student\n");
        }

        Console.WriteLine("=== CALCULATED STATISTICS ===" + "\n" +
        $"Born: {birthYear}" + "\n" +
        $"Years until graduation: {yearsToGrad}" + "\n" +
        $"Age: {age}" + "\n" +
        heightF.ToString("F2") + " feet " + heightI + " inches" + "\n");
        if (honorStudent)
        {
            Console.WriteLine("Honor Student");
        }
        Console.WriteLine($"Age in months: {ageMonths}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }

    public static double getNumber()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                return value;

            } else
            {
                Console.WriteLine("Enter a number:");
            }
        }
    }
}
