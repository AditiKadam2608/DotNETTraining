using System;

class sqfeet
{
    static void Main()
    {
        int numberOfRooms;

        Console.Write("Enter the number of rooms in the house: ");
        numberOfRooms = int.Parse(Console.ReadLine());

        double totalSquareFeet = 0.0;

        for (int i = 1; i <= numberOfRooms; i++)
        {
            Console.WriteLine("Enter dimensions for room :");

            Console.Write("Length (in feet): ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width (in feet): ");
            double width = double.Parse(Console.ReadLine());

            double roomArea = CalculateArea(length, width);
            Console.WriteLine("Area of room "+i+ " " + roomArea + "square feet\n");

            totalSquareFeet += roomArea;
        }

        Console.WriteLine("Total square footage of the house: " + totalSquareFeet+  " square feet");
    }

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }
}
