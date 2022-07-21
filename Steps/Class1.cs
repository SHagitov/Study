using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    public class Class1
    {
        //public
        //internal
        //protected
        public int health { get; private set; } = 100;
        public void Hit(int damage)
        {
            if (damage > health)
                damage = health;
            health -= damage;
        }
    }
}
