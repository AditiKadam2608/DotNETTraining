using System;
using System.Collections.Generic;

class gray
{
    static void Main()
    {
        Console.Write("Enter the number of bits: ");
        int n = int.Parse(Console.ReadLine());

        List<string> grayCodes = GenerateGrayCode(n);

        Console.WriteLine("Gray code sequence:");
        foreach (var code in grayCodes)
        {
            Console.WriteLine(code);
        }
    }

    static List<string> GenerateGrayCode(int n)
    {
        List<string> result = new List<string>();

        // Base case: Gray code sequence for 0 bits is just an empty string
        if (n == 0)
        {
            result.Add("0");
            return result;
        }
        
        // Generate Gray code sequence for (n-1) bits
        List<string> previousGrayCodes = GenerateGrayCode(n - 1);

        // Add a '0' prefix to the previous Gray codes
        foreach (var code in previousGrayCodes)
        {
            result.Add("0" + code);
        }

        // Add a '1' prefix to the reversed previous Gray codes
        for (int i = previousGrayCodes.Count - 1; i >= 0; i--)
        {
            result.Add("1" + previousGrayCodes[i]);
        }

        return result;
    }
}
