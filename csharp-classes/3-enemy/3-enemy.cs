using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represents health of the zombie.
        /// </summary>
        private int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with default health (0).
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
        /// </summary>
        /// <param name="value">The initial health value. Must be greater than or equal to 0.</param>
        /// <exception cref="ArgumentException">Thrown when the specified health value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }

        /// <summary>
        /// Gets the current health of Zombie.
        /// </summary>
        /// <returns>The current health of Zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
