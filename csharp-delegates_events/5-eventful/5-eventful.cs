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

    private string status;

    /// <summary>
    /// A constructor for Player class that sets HP and name values.
    /// </summary>
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

        HPCheck += CheckStatus;
    }

    /// <summary>
    /// A method that prints the health of the Player class.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// An event that handles CurrentHPArgs event.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// A delegate method that will call TakeDamage or HealDamage.
    /// </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Calculate the damage to the player.
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }

        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(this.hp - damage);
    }

    /// <summary>
    /// Calculate the amount of HP healed.
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }

        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// A method that will validate the value of hp after damage or heal.
    /// </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }

        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// Call CurrentHPArgs event.
    /// </summary>
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
        if (e.currentHp <= 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Health is low!");
        }
        Console.ResetColor();
    }

    /// <summary>
    /// Check player status based on hp value.
    /// </summary>
    /// <param name="e"></param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
        {
            HPCheck += HPValueWarning; // Subscribe to the event
        }

        HPCheck?.Invoke(this, e); // Raise the event
    }
}

/// <summary>
/// A modifier that will set the statuses weak, strong, or basic.
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// The delegate that will interact with Modifier and ApplyModifier.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// A class that sets new HP based on events.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    public float currentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}