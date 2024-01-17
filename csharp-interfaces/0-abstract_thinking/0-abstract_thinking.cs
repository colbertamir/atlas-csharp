using System;

/// <summary>
/// Represents a abstract base class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns a string representation of object.
    /// </summary>
    /// <returns>Formatted string representing the object.</returns>
    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}