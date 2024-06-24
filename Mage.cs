using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr4
{
    public abstract class Mage
    {
        public string Name { get; private set; }
        public int MagicLevel { get; protected set; }
        public int Health { get; protected set; }
        protected Mage(string name, int magicLevel, int health)
        {
            Name = name;
            MagicLevel = magicLevel;
            Health = health;
        }
        public abstract void Attack(Mage target);
        public abstract void Defend(int damage);
        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}

