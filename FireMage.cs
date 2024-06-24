using Pr5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Pr5
{
    public class FireMage : Mage
    {
        public FireMage(string name, int magicLevel, int health) : base(name, magicLevel, health) { }

        public override void Attack(Mage target)
        {
            string message = $"{Name} атакує {target.Name} вогняним закляттям!";
            RaiseAttackEvent(message);
            target.Defend(MagicLevel * 10);
        }

        public override void Defend(int damage)
        {
            string message = $"{Name} захищається і отримує {damage} шкоди.";
            RaiseDefendEvent(message);
            Health -= damage;
        }
    }
}

