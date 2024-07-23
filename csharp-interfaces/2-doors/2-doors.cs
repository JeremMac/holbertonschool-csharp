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
/// A class that represents a door.
/// </summary>
public class Door: Base, IInteractive
{
    /// <summary>
    /// Consructor to set the value of door's name.
    /// </summary>
    /// <param name="value"></param>
    public Door(string value = "Door")
    {
        name = value;
    }

    /// <summary>
    /// A functions that sums an interaction with Door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($@"You try to open the {name}. It's locked.");
    }
}
