using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        // Ensure number is non-negative
        number = Math.Abs(number);

        // Extract the last digit
        int lastDigit = number % 10;

        // Print the last digit
        Console.WriteLine($"The last digit of {number} is {lastDigit}");

        // Return the last digit
        return lastDigit;
    }
}