/// <summary>
/// Represents a simple generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T Value { get; set; } = default(T);

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node Next { get; set; } = null;

        /// <summary>
        /// Initializes new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The initial value of the node.</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// Gets or sets the head node of the queue.
    /// </summary>
    public Node Head { get; set; } = null;

    /// <summary>
    /// Gets or sets the tail node of the queue.
    /// </summary>
    public Node Tail { get; set; } = null;

    /// <summary>
    /// Gets or sets count of elements in the queue.
    /// </summary>
    public int GetCount { get; private set; } = 0;

    /// <summary>
    /// Checks the type of the queue.
    /// </summary>
    /// <returns>A string representing the type of the queue.</returns>
    public string CheckType()
    {
        return $"System.{typeof(T).Name}";
    }

    /// <summary>
    /// Adds new node to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (Head == null)
        {
            // If the queue is empty, the new node becomes both the head and tail
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            // Otherwise, add the new node to the end of the queue
            Tail.Next = newNode;
            Tail = newNode;
        }

        // Increment the count
        Count++;
    }

    /// <summary>
    /// Returns number of nodes in the queue.
    /// </summary>
    /// <returns>The count of nodes in the queue.</returns>
    public int Count()
    {
        return Count;
    }
}
