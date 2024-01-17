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
        /// Represents name of the zombie.
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Initializes new instance of <see cref="Zombie"/> class with default health (0) and (No name) as the default name.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes new instance of the <see cref="Zombie"/> class with a specified health value and (No name) as the default name.
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
        /// Gets or sets the name of Zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets current health of Zombie.
        /// </summary>
        /// <returns>Current health of Zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
