using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Classes
{
    [Serializable]
    public class Unit : Interfaces.IUnit
    {
        public string   name, 
                        className;
        public int      maxHealth,
                        health;
        public float    speed,
                        dexterity, 
                        strength, 
                        intelligence;
        public bool     alive;

        Unit()
        {
            name = "John";
            className = "Squire";
            maxHealth = 5;
            health = maxHealth;
            speed = 0f;
            dexterity = 0f;
            strength = 0f;
            intelligence = 0f;
            alive = true;
        }

        public Unit(string n, string cs, int mHealth, float spd, float dex, float str, float intel)
        {
            name         = n;
            className    = cs;
            maxHealth    = mHealth;
            health       = maxHealth;
            speed        = spd;
            dexterity    = dex;
            strength     = str;
            intelligence = intel;
            alive        = true;
        }

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

        public bool Alive
        {
            get
            {
                return alive;
            }

            set
            {
                alive = value;
            }
        }
        #endregion

        public void Attack(Unit target)
        {
            target.Health -= (int)this.Strength;
            Resolve();
        }

        private void Resolve()
        {
            if (Health <= 0)
            {
                Health = 0;
                Alive = false;
            }
        }
    }
}
