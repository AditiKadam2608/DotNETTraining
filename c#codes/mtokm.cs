using System;

class mtokm
{
    static void Main()
    {
        int choice;
        
        do
        {
            Console.WriteLine("\nConversion Menu:");
            Console.WriteLine("1. Convert Meters to Kilometers");
            Console.WriteLine("2. Convert Kilometers to Meters");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ConvertMetersToKilometers();
                    break;
                case 2:
                    ConvertKilometersToMeters();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 3);
    }

    static void ConvertMetersToKilometers()
    {
        Console.Write("Enter the value in meters: ");
        double meters = double.Parse(Console.ReadLine());
        double kilometers = meters / 1000;
        Console.WriteLine("{0} meters is equal to {1} kilometers.", meters, kilometers);
    }

    static void ConvertKilometersToMeters()
    {
        Console.Write("Enter the value in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        double meters = kilometers * 1000;
        Console.WriteLine("{0} kilometers is equal to {1} meters.", kilometers, meters);
    }
}
