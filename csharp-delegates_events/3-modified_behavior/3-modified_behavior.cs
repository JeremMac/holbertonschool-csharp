using System;

/// <summary>
/// A class that represents the player.
/// </summary>
public class Player
{
    /// <summary>
    /// A string that holds the name of the Player.
    /// </summary>
    private string name;

    /// <summary>
    /// A float that represents the max HP of the Player.
    /// </summary>
    private float maxHp;

    /// <summary>
    /// A float that represents the current HP of the Player.
    /// </summary>
    private float hp;

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
        else
        {
            this.maxHp = maxHp;
        }

        this.hp = this.maxHp;
    }

    /// <summary>
    /// A methode that print the health of the Player class.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// A delegate methode that will call TakeDamage or HealDamage.
    /// </summary>
    /// <param name="amount"></param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Calculate the damage to the player.
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        float HPdam;
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            HPdam = this.hp - damage;
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(HPdam);
        }

    }

    /// <summary>
    /// Calculate the amount of HP healed.
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        float HPheal;
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            HPheal = this.hp + heal;
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(HPheal);
        }

    }

    /// <summary>
    /// A methode that will validate the value
    /// of hp after damage or heal.
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if(newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    /// <summary>
    /// A methode that sets the application of Modifier.
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        else if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        else
        {
            return baseValue;
        }
    }
}

/// <summary>
/// A modifier that will set the statuses
/// week , strong or basic.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// A state that will divise baseValue by 2.
    /// </summary>
    Weak,

    /// <summary>
    /// The default state of baseValue.
    /// </summary>
    Base,

    /// <summary>
    /// A state that multiply baseValue by 1.5.
    /// </summary>
    Strong
}

/// <summary>
/// The delegate that will interact with Modifier and ApplyModifier.
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
