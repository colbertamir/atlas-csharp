using System;

/// <summary>
/// Supplies utility methods for working with objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the object is type int.
    /// </summary>
    /// <param name="obj">The object to be checked.</param>
    /// <returns>True if the object is type int, otherwise False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
