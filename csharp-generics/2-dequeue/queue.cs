/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
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
        public T value { get; set; } = default(T); // Use default(T) instead of null

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node next { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The initial value of the node.</param>
        public Node(T value)
        {
            this.value = value;
            next = null;
        }
    }

    /// <summary>
    /// Gets or sets the head node of the queue.
    /// </summary>
    public Node head { get; set; } = null;

    /// <summary>
    /// Gets or sets the tail node of the queue.
    /// </summary>
    public Node tail { get; set; } = null;

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes in the queue.</returns>
    public int Count() { return count; }

    private int count = 0;

    /// <summary>
    /// Checks the type of the queue.
    /// </summary>
    /// <returns>A string representing the type of the queue.</returns>
    public string CheckType()
    {
        return $"{typeof(T).Name}";
    }

    /// <summary>
    /// Adds a new node to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        // Otherwise, add the new node to the end of the queue
        if (tail != null)
        {
            tail.next = newNode;
            tail = newNode;
        }
        else
        {
            // Handle the case where tail is null
            head = newNode;
            tail = newNode;
        }

        // Increment the count
        count++;
    }

    /// <summary>
    /// Removes the first node in the queue and returns its value.
    /// If the queue is empty, invokes the provided action to write the message.
    /// </summary>
    public T Dequeue(System.Action<string> writeToConsole)
    {
        if (head != null)
        {
            T dequeuedValue = head.value;
            head = head.next;

            // Decrement the count
            count--;

            return dequeuedValue;
        }
        else
        {
            writeToConsole("Queue is empty");
            return default(T);
        }
    }
}
