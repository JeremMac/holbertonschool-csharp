using System;

namespace Enemies
{
    ///<summary>
    ///Sets a Zombie class with no health.
    ///</summary>
    public class Zombie
    {
        ///<summary>
        ///public health field.
        ///</summary>
        private int health;
        private string name = "(No name)";

        ///<summary>
        ///getter and setter for name.
        ///</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        ///<summary>
        ///Constructor to set health value.
        ///</summary>
        public Zombie()
        {
            health = 0;
        }
        
        ///<summary>
        ///Constructor to verifie that value is not inferior to zero.
        ///</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        
        ///<summary>
        ///a method that returnst the value of health.
        ///</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
