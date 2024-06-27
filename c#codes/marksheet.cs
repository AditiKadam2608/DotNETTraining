using System;
using System.Collections.Generic;

class marksheet
{
    static void Main()
    {
        Console.Write("Enter student's name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter student's roll number: ");
        string rollNumber = Console.ReadLine();

        Dictionary<string, int> subjects = new Dictionary<string, int>();
        string subject;
        int marks;
        char addMore;

        do
        {
            Console.Write("Enter subject name: ");
            subject = Console.ReadLine();
            Console.Write("Enter marks obtained: ");
            marks = int.Parse(Console.ReadLine());

            subjects.Add(subject, marks);

            Console.Write("Do you want to add more subjects? (y/n): ");
            addMore = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (addMore == 'y' || addMore == 'Y');

        GenerateMarksheet(studentName, rollNumber, subjects);
    }

    static void GenerateMarksheet(string studentName, string rollNumber, Dictionary<string, int> subjects)
    {
        int totalMarks = 0;
        Console.WriteLine("\nMarksheet:");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Subjects and Marks:");

        foreach (var subject in subjects)
        {
            Console.WriteLine(subject.Key + ": " + subject.Value);
            totalMarks += subject.Value;
        }

        double averageMarks = (double)totalMarks / subjects.Count;
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Average Marks: " + averageMarks.ToString("F2"));

        string grade = GetGrade(averageMarks);
        Console.WriteLine("Grade: " + grade);
    }

    static string GetGrade(double averageMarks)
    {
        if (averageMarks >= 90)
        {
            return "A+";
        }
        else if (averageMarks >= 80)
        {
            return "A";
        }
        else if (averageMarks >= 70)
        {
            return "B+";
        }
        else if (averageMarks >= 60)
        {
            return "B";
        }
        else if (averageMarks >= 50)
        {
            return "C";
        }
        else if (averageMarks >= 40)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
