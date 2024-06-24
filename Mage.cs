using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr5
{
    public abstract class Mage
    {
        public string Name { get; private set; }
        public int MagicLevel { get; protected set; }
        public int Health { get; protected set; }
        public event MageEventHandler OnAttack;
        public event MageEventHandler OnDefend;
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
        protected void RaiseAttackEvent(string message)
        {
            OnAttack?.Invoke(this, new MageEventArgs(message));
        }
        protected void RaiseDefendEvent(string message)
        {
            OnDefend?.Invoke(this, new MageEventArgs(message));
        }
    }
}
