using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ім'я першого мага:");
            string name1 = Console.ReadLine();
            Mage fireMage = new FireMage(name1, 5, 100);

            Console.WriteLine("Введіть ім'я другого мага:");
            string name2 = Console.ReadLine();
            Mage waterMage = new WaterMage(name2, 5, 100);

            Battle.StartBattle(fireMage, waterMage);
        }
    }
}
