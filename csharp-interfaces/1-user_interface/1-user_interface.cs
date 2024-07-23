using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// An abstract class that contains the name property.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// A public string.
    /// </summary>
    public string name { get; set;}

    /// <summary>
    /// Overiden ToString methode.
    /// </summary>
    /// <returns>A caracter string</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}


/// <summary>
/// A class that nhérite all interfaces and base abstract class.
/// </summary>
public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// A int that value the durability.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// A bool that will determined if collected is true or not.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// A methode that will allow all player interactions.
    /// </summary>
    public void Interact()
    {}

    /// <summary>
    /// A methode that will determine a break state or not.
    /// </summary>
    public void Break()
    {}

    /// <summary>
    /// A method that wil allow to collect items.
    /// </summary>
    public void Collect()
    {}
}
