using System;

/// <summary>
/// Represents a shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates and returns area of the shape.
    /// </summary>
    /// <returns>Area of the shape.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
