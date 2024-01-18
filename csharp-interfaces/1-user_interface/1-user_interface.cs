using System;

/// <summary>
/// Represents an interface for interactive objects.
/// </summary>
public interface IInteractive
{
    void Interact();
}

/// <summary>
/// Represents an interface for breakable objects.
/// </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// Represents an interface for collectable objects.
/// </summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Represents an abstract base class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string name;

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>A formatted string representing the object.</returns>
    public override string ToString()
    {
        return $"{name} is a {GetType().ToString()}";
    }
}

/// <summary>
/// Represents a class that inherits from Base and implements IInteractive, IBreakable, and ICollectable.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    // Implementation of IInteractive interface
    public void Interact()
    {
        // Implementation goes here
    }

    // Implementation of IBreakable interface
    public int durability { get; set; }
    public void Break()
    {
        // Implementation goes here
    }

    // Implementation of ICollectable interface
    public bool isCollected { get; set; }
    public void Collect()
    {
        // Implementation goes here
    }
}
