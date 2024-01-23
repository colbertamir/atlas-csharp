﻿/// <summary>
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
        public T value { get; set; } = default(T);

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
            value = value;
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
    /// Gets or sets the count of elements in the queue.
    /// </summary>
    public int count { get; private set; } = 0;

    /// <summary>
    /// Checks the type of the queue.
    /// </summary>
    /// <returns>A string representing the type of the queue.</returns>
    public string CheckType()
    {
        return $"System.{typeof(T).Name}";
    }

    /// <summary>
    /// Adds a new node to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            // If the queue is empty, the new node becomes both the head and tail
            head = newNode;
            tail = newNode;
        }
        else
        {
            // Otherwise, add the new node to the end of the queue
            tail.next = newNode;
            tail = newNode;
        }

        // Increment the count
        count++;
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>The count of nodes in the queue.</returns>
    public int Count()
    {
        return Count;
    }
}
