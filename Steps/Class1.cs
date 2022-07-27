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

        private readonly int speed;
        public int health { get; private set; } = 100;
        public string Race { get; private set; }

        public int Armor { get; private set; }
        public Class1(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }
        public Class1(string race, int armor, int speed)
        {
            Race = race;
            Armor = armor;
            this.speed = speed;
        }
        public Class1()
        {

        }
        public void Hit(int damage)
        {
            if (damage > health)
                damage = health;
            health -= damage;
        }
    }
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
