using System;

/// <summary>
/// Supplies utility methods for working with objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the object is an instance of a class that inherits from the specified class.
    /// </summary>
    /// <param name="derivedType">The type of derived class.</param>
    /// <param name="baseType">The type of the base class.</param>
    /// <returns>True if the object is a subclass specified base class; otherwise, False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return baseType.IsAssignableFrom(derivedType) && derivedType != baseType;
    }
}
