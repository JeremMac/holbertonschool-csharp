using System;

namespace Enemies
{
    ///<summary>
    ///Sets a Zombie class with no health.
    ///</summary>
    public class Zombie
    {
        public int health;

        public Zombie(int Health = 0)
        {
            health = Health;
        }
    }
}
