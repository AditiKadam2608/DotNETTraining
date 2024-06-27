using System;
using System.Diagnostics;

class stopwatch
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        int choice;
        
        do
        {
            Console.WriteLine("\nStopwatch Menu:");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Stop");
            Console.WriteLine("3. Reset");
            Console.WriteLine("4. Display Elapsed Time");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StartStopwatch(stopwatch);
                    break;
                case 2:
                    StopStopwatch(stopwatch);
                    break;
                case 3:
                    ResetStopwatch(stopwatch);
                    break;
                case 4:
                    DisplayElapsedTime(stopwatch);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 5);
    }

    static void StartStopwatch(Stopwatch stopwatch)
    {
        if (!stopwatch.IsRunning)
        {
            stopwatch.Start();
            Console.WriteLine("Stopwatch started.");
        }
        else
        {
            Console.WriteLine("Stopwatch is already running.");
        }
    }

    static void StopStopwatch(Stopwatch stopwatch)
    {
        if (stopwatch.IsRunning)
        {
            stopwatch.Stop();
            Console.WriteLine("Stopwatch stopped.");
        }
        else
        {
            Console.WriteLine("Stopwatch is not running.");
        }
    }

    static void ResetStopwatch(Stopwatch stopwatch)
    {
        stopwatch.Reset();
        Console.WriteLine("Stopwatch reset.");
    }

    static void DisplayElapsedTime(Stopwatch stopwatch)
    {
        TimeSpan elapsed = stopwatch.Elapsed;
        Console.WriteLine("Elapsed Time: {0:hh\\:mm\\:ss\\.fff}", elapsed);
    }
}
