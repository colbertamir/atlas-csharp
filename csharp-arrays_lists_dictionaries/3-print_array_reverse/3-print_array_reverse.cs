using System;

class Array
{
    public static void Reverse(int[] array)
    {
        // Check if the array is not null
        if (array == null)
        {
            Console.WriteLine("Array is null");
            return;
        }

        // Reverse the array in-place
        Array.Reverse(array);

        // Print the reversed array
        Console.WriteLine("Reversed Array: " + string.Join(", ", array));
    }
}