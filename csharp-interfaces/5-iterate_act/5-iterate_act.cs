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

/// <summary>
/// A class with all decorations parameters.
/// </summary>
public class Decoration: Base, IInteractive, IBreakable
{
    /// <summary>
    /// A boleen that will check the nature of an item.
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// An int that represents the durability of the items.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// A constructor that will set all parameters to Decoration class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="durability"></param>
    /// <param name="isQuestItem"></param>
    /// <exception cref="ArgumentException"></exception>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.name = name;

        this.durability = durability;

        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// A method that allows interactions between player and Decoration.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }

        if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }

        if (!isQuestItem && durability > 0)
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// A methode that manage breakable state of a decoration.
    /// </summary>
    public void Break()
    {
        durability -= 1;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// A class that represent an item key.
/// </summary>
public class Key: Base, ICollectable
{
    /// <summary>
    /// a booleen that check if a key is collected or not.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// A constructor to set the name and the collected state of class Key.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="isCollected"></param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// A methode that will allow to collect Key.
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

/// <summary>
/// A class that checks which interface to call.
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// A methode that will iterate through roomObject and check the types of its elements.
    /// This mehode will determine wich methode to use based on the interface used.
    /// </summary>
    /// <param name="roomObjects"></param>
    /// <param name="type"></param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive interactive)
            {
                interactive.Interact();
            }
            else if (type == typeof(IBreakable) && obj is IBreakable breakable)
            {
                breakable.Break();
            }
            else if (type == typeof(ICollectable) && obj is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}
