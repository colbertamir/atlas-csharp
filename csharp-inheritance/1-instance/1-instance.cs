using System;

/// <summary>
/// Supplies utility methods for working with objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the object is an instance of, or if the object is an instance of a class
    /// that inherited from Array.
    /// </summary>
    /// <param name="obj">The object to be checked.</param>
    /// <returns>True if the object is an instance of Array or inherited from Array, otherwise False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
