using System;

/// <summary>
/// A class that represents the player.
/// </summary>
public class Player
{
    private string name;

    private float maxHp;

    private float hp;

    private string status;

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
        this.status = $"{name} is ready to go!";
        this.HPCheck += CheckStatus;
    }

    /// <summary>
    /// A methode that print the health of the Player class.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// An event that handle CurrentHPArgss envent.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;


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

        OnCheckStatus(new CurrentHPArgs(this.hp));
        //OnHPCheck(new CurrentHPArgs(hp));
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

    /// <summary>
    /// Call CurrentHPArgs envent.
    /// </summary>
    /// <param name="e"></param>
    protected virtual void OnHPCheck(CurrentHPArgs e)
    {
        HPCheck?.Invoke(this, e);
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp < maxHp && e.currentHp >= maxHp / 2)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp < maxHp / 2 && e.currentHp >= maxHp / 4)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp < maxHp / 4 && e.currentHp > 0)
        {
            status = $"{name} needs help!";
        }
        else if (e.currentHp == 0)
        {
            status = $"{name} is knocked out!";
        }

        Console.WriteLine(status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Health is low!");
            Console.ResetColor();
        }
    }

    /// <summary>
    /// A methode that checks the status of the Player
    /// based on the Hp value.
    /// </summary>
    /// <param name="e"></param>
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
        {
            HPCheck += HPValueWarning; // Subscribe to the event
        }

        HPCheck?.Invoke(this, e); // Raise the event
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

/// <summary>
/// A class thet sets newHP based on events.
/// </summary>
public  class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// A float the holds the current Hp value.
    /// </summary>
    public float currentHp { get; }

    /// <summary>
    /// Consructor to set all value for CurrentHPArgs class.
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}
