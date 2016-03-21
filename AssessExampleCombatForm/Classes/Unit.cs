using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Classes
{
    [Serializable]
    class Unit : Interfaces.IUnit
    {
        string  name, 
                className;
        int     maxHealth,
                health;
        float   speed,
                dexterity, 
                strength, 
                intelligence;

        #region IUnit Inerface Implementation
        public string ClassName
        {
            get
            {
                return className;
            }
        }

        public float Dexerity
        {
            get
            {
                return dexterity;
            }

            set
            {
                dexterity = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }

        public float Intelligence
        {
            get
            {
                return intelligence;
            }

            set
            {
                intelligence = value;
            }
        }

        public int MaxHealth
        {
            get
            {
                return maxHealth;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public float Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }
        #endregion
    }
}
