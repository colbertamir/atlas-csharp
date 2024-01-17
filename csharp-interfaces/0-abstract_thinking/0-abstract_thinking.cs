using System;

/// <summary>
/// Represents an abstract base class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns string representation of object.
    /// </summary>
    /// <returns>Formatted string representing the object.</returns>
    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}

/// <summary>
/// Represents software engineer.
/// </summary>
public class SoftwareEngineer : Base
{
    // Additional members specific to SoftwareEngineer class can be added here
}
