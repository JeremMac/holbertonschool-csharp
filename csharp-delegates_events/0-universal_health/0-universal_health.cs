using System;

/// <summary>
/// A class that represents the player.
/// </summary>
public class Player
{
    /// <summary>
    /// A string that holds the name of the Player.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// A float that represents the max HP of the Player.
    /// </summary>
    public float maxHp { get; set; }

    /// <summary>
    /// A float that represents the current HP of the Player.
    /// </summary>
    public float hp { get; set; }

    /// <summary>
    /// A constructor for PLayer class that sets
    /// HP, and name values.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = this.maxHp;
    }

    /// <summary>
    /// A methode that print the health of the Player class.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
