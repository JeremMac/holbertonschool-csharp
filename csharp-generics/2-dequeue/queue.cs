using System;

/// <summary>
/// A class that contains the CheckType methode.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// a methode that returns the Queue’s type.
    /// </summary>
    /// <returns> the name of the type </returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// a class that sets a new node.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value of the node
        /// </summary>
        public T value { get; set; }

        /// <summary>
        /// the node that contains value
        /// </summary>
        public Node next { get; set; }

        /// <summary>
        /// Constructor that sets the value
        /// </summary>
        /// <param name="value"></param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    // Properties of Queue<T>
    private Node head;
    private Node tail;
    private int count;

    /// <summary>
    /// Constructor for Queue
    /// </summary>
    public Queue()
    {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }

    /// <summary>
    /// Method to add a new node to the end of the queue.
    /// </summary>
    /// <param name="value"></param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        
        if (this.tail != null)
        {
            this.tail.next = newNode;
        }
        this.tail = newNode;
        
        if (this.head == null)
        {
            this.head = newNode;
        }
        
        this.count++;
    }

    /// <summary>
    /// Method to remove the first node in the queue and return its value
    /// </summary>
    /// <returns> the value of the removed node</returns>
    public T Dequeue()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = this.head.value;
        this.head = this.head.next;
        
        if (this.head == null)
        {
            this.tail = null;
        }

        this.count--;
        return value;
    }

    /// <summary>
    /// Method to return the number of nodes in the queue
    /// </summary>
    /// <returns> Int number of nodes.</returns>
    public int Count()
    {
        return this.count;
    }
}
