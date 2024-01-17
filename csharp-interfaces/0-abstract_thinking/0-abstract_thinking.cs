using System;

/// <summary>
/// Represents abstract base class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of object.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns string representation of the object.
    /// </summary>
    /// <returns>A formatted string representing the object.</returns>
    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}