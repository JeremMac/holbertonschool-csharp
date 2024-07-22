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
    /// Method to concatenate all values in the queue if it is of type String or Char.
    /// </summary>
    /// <returns>Concatanate string of all elements in the queue.</returns>
    public T Concatenate()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return default(T);
        }

        Node current = this.head;
        string result = "";

        while (current != null)
        {
            result += current.value.ToString();
            if (typeof(T) == typeof(string) && current.next != null)
            {
                result += " ";
            }
            current = current.next;
        }

        return (T)(object)result;
    }

    /// <summary>
    ///  a method that prints the queue, starting from the head.
    /// </summary>
    public void Print()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        Node current = this.head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    /// <summary>
    /// A method to that returns the value of the first node of the queue.
    /// </summary>
    /// <returns> Head's value or T's default value</returns>
    public T Peek()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return this.head.value;
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
