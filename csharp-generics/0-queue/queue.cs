/// <summary>
/// Represents a simple generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Checks the type of the queue.
    /// </summary>
    /// <returns>A string representing the type of the queue.</returns>
    public string CheckType()
    {
        return $"System.{typeof(T).Name}";
    }
}
