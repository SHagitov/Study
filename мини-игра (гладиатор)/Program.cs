using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace мини_игра__гладиатор_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float health1 = rand.Next(50, 100);
            int damage1 = rand.Next(5, 20);
            int armor1 = rand.Next(25, 65);
            float health2 = rand.Next(50, 100);
            int damage2 = rand.Next(5, 20);
            int armor2 = rand.Next(25, 65);
            Console.WriteLine("Гладиатор1 - " + health1 + " хп, " + damage1 + " Max Damage, " + armor1 + " armor");
            Console.WriteLine("Гладиатор2 - " + health2 + " хп, " + damage2 + " Max Damage, " + armor2 + " armor");
            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1)) / 100 * armor2;
                Console.WriteLine(" N1 - N2 " + health1 + " --- " + health2);
            }
            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья, оба мертвы.");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Гладиатор 1 пал.");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор 2 пал.");
            }
            Console.ReadKey();
        }

    }
}
