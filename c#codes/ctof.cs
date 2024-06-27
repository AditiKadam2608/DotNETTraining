using System;

class ctof
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = CelsiusToFahrenheit(celsius);

        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
