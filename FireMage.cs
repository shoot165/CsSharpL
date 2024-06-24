using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr4
{
    public class FireMage : Mage
    {
        public FireMage(string name, int magicLevel, int health) : base(name, magicLevel, health) { }
        public override void Attack(Mage target)
        {
            Console.WriteLine($"{Name} атакує {target.Name} вогняним закляттям!");
            target.Defend(MagicLevel * 10);
        }
        public override void Defend(int damage)
        {
            Console.WriteLine($"{Name} захищається і отримує {damage} шкоди.");
            Health -= damage;
        }
    }
}

