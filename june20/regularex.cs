using System;
using System.Text.RegularExpressions;

class regularex
{
    static void Main()
    {
        // Define a regular expression for validating an email
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        // Create a Regex object with the email pattern
        Regex emailRegex = new Regex(emailPattern);

        // Some example email addresses to validate
        string[] emails = { "test@example.com", "invalid-email", "user@domain", "user@domain.com", "another.test@sub.domain.com" };

        foreach (var email in emails)
        {
            if (emailRegex.IsMatch(email))
            {
                Console.WriteLine("valid email address." +email);
            }
            else
            {
                Console.WriteLine(" not a valid email address." +email);
            }
        }
    }
}
