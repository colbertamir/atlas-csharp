using System;

/// <summary>
/// Represents a player with health-related properties and methods.
/// </summary>
public class Player
{
    // ... (Your existing code remains unchanged)

    /// <summary>
    /// Takes damage from the player's health.
    /// </summary>
    /// <param name="damage">The amount of damage to be taken.</param>
    public void TakeDamage(float damage)
    {
        // Ensure damage is not negative
        float actualDamage = Math.Max(0, damage);

        Console.WriteLine($"{this.name} takes {actualDamage} damage!");
        // Apply damage directly without using ApplyModifier
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
        // Apply healing directly without using ApplyModifier
        ValidateHP(this.hp + actualHeal);
    }

    // ... (The rest of your existing code remains unchanged)
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
