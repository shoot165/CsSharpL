using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr4
{
    public class Battle
    {
        public static void StartBattle(Mage mage1, Mage mage2)
        {
            Console.WriteLine("Починається битва між магами!");
            Console.WriteLine($"{mage1.Name} (Вогняний маг) vs {mage2.Name} (Водяний маг)");
            while (mage1.IsAlive() && mage2.IsAlive())
            {
                mage1.Attack(mage2);
                if (!mage2.IsAlive())
                {
                    Console.WriteLine($"{mage2.Name} переможений! {mage1.Name} виграв битву!");
                    break;
                }
                mage2.Attack(mage1);
                if (!mage1.IsAlive())
                {
                    Console.WriteLine($"{mage1.Name} переможений! {mage2.Name} виграв битву!");
                    break;
                }
            }
        }
    }
}
