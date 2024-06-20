using System;

class gotoSample
{
    static void Main()
    {
        

        Start:
        Console.Write("Please enter a non-negative number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
            goto Start;
        }

        Console.WriteLine("You entered: " + input);
    }
}
