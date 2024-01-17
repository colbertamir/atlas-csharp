using System;

class IntUtils
{
    public static void divide(int a, int b)
    {
        try
        {
            // Attempts to perform the division
            int result = a / b;
            Console.WriteLine($"Result of {a} / {b} = {result}");
        }
        catch (DivideByZeroException)
        {
            // Handles the case where the denominator is zero
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        finally
        {
            // This block is executed regardless
            Console.WriteLine("Division operation completed.");
        }
    }
}