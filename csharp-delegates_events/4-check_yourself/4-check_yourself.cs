using System;

/// <summary>
/// EventArgs class for current health points.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    public float CurrentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        CurrentHp = newHp;
    }
}

/// <summary>
/// Represents a player with health-related properties and methods.
/// </summary>
public class Player
{
    /// <summary>
    /// Gets the name of the player.
    /// </summary>
    public string Name
    {
        get { return name; }
    }

    /// <summary>
    /// Gets the maximum health points of the player.
    /// </summary>
    public float MaxHp
    {
        get { return maxHp; }
    }

    /// <summary>
    /// Gets the current health points of the player.
    /// </summary>
    public float Hp
    {
        get { return hp; }
    }

    /// <summary>
    /// Event to notify when the current health changes.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The name of the player. Default is "Player".</param>
    /// <param name="maxHp">The maximum health points. Default is 100f.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        // Check if maxHp is greater than 0
        if (maxHp > 0)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
        else
        {
            // Set maxHp to the default value of 100f
            this.maxHp = 100f;
            this.hp = this.maxHp;

            // Print message
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        // Set default status
        this.status = $"{this.name} is ready to go!";

        // Assign CheckStatus to the HPCheck EventHandler
        this.HPCheck += CheckStatus;
    }

    /// <summary>
    /// Prints the health information of the player to the console.
    /// </summary>
    public void PrintHealth()
    {
        // Check if name is not null or empty before printing
        string playerName = string.IsNullOrEmpty(this.name) ? "Player" : this.name;

        Console.WriteLine($"{playerName} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// Delegate for calculating health.
    /// </summary>
    /// <param name="amount">The amount to calculate health.</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Takes damage from the player's health.
    /// </summary>
    /// <param name="damage">The amount of damage to be taken.</param>
    public void TakeDamage(float damage)
    {
        // Ensure damage is not negative
        float actualDamage = Math.Max(0, damage);

        Console.WriteLine($"{this.name} takes {actualDamage} damage!");
        // Calculate new value of hp without setting it here
        ValidateHP(this.hp - actualDamage);
    }

    /// <summary>
    /// Heals player's health.
    /// </summary>
    /// <param name="heal">The amount of health to be healed.</param>
    public void HealDamage(float heal)
    {
        // Ensure heal is not negative
        float actualHeal = Math.Max(0, heal);

        Console.WriteLine($"{this.name} heals {actualHeal} HP!");
        // Calculate new value of hp without setting it here
        ValidateHP(this.hp + actualHeal);
    }

    /// <summary>
    /// Validates and sets the new value of the player's hp.
    /// </summary>
    /// <param name="newHp">The new health points value.</param>
    public void ValidateHP(float newHp)
    {
        // Set hp based on validation criteria
        this.hp = newHp < 0 ? 0 : (newHp > this.maxHp ? this.maxHp : newHp);

        // Notify subscribers about the change in current health
        OnHPCheck();
    }

    /// <summary>
    /// Applies a modifier to the base value.
    /// </summary>
    /// <param name="baseValue">The base value to which the modifier is applied.</param>
    /// <param name="modifier">The modifier to apply (Weak, Base, Strong).</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }

    /// <summary>
    /// Method to invoke the HPCheck event.
    /// </summary>
    protected virtual void OnHPCheck()
    {
        HPCheck?.Invoke(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// Method to check the status based on the current health.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments containing current health.</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        // Check the current health value and set the status accordingly
        if (e.CurrentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
        }
        else if (e.CurrentHp >= 0.5f * this.maxHp && e.CurrentHp < this.maxHp)
        {
            this.status = $"{this.name} is doing well!";
        }
        else if (e.CurrentHp >= 0.25f * this.maxHp && e.CurrentHp < 0.5f * this.maxHp)
        {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (e.CurrentHp > 0 && e.CurrentHp < 0.25f * this.maxHp)
        {
            this.status = $"{this.name} needs help!";
        }
        else if (e.CurrentHp == 0)
        {
            this.status = $"{this.name} is knocked out!";
        }

        // Print the status
        Console.WriteLine(this.status);
    }

    // Private fields
    private string name;
    private float maxHp;
    private float hp;
    private string status;
}

/// <summary>
/// Represents modifiers for the player.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Represents a weak modifier.
    /// </summary>
    Weak,

    /// <summary>
    /// Represents a base modifier.
    /// </summary>
    Base,

    /// <summary>
    /// Represents a strong modifier.
    /// </summary>
    Strong
}

/// <summary>
/// Delegate for calculating modifiers.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
