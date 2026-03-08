using System;

class Program
{
    static void Main()
    {
        // welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // ask for weight
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        // if weight is too heavy end program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            return;
        }

        // ask for width
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // ask for height
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // ask for length
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // if dimensions are too big end program
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadLine();
            return;
        }

        // calculate shipping cost
        decimal total = (width * height * length * weight) / 100m;

        // show the price
        Console.WriteLine("Your estimated total for shipping this package is: $" + total);
        Console.WriteLine("Thank you!");

        Console.ReadLine();
    }
}