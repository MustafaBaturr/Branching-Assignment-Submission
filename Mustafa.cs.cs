using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt user for package dimensions
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate total dimensions
        double totalDimensions = width + height + length;

        // Check if package is too big
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping quote
        // Formula: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display the quote formatted as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
} 