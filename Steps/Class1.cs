﻿using System;

namespace Steps
{
    public class Class1
    {
        //public
        //internal
        //protected

        private readonly int speed;
        public int health { get; private set; } = 100;
        public Race Race { get; private set; }
        public int Armor { get; private set; }

        public Class1(string name, int armor)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name arg can't be null");
            }

            if (armor < 0 || armor > 100)
            {
                throw new ArgumentException("armor can't be less than 0 or greater than 100");
            }
        }
        public Class1(Race race)
        {
            Race = race;
            Armor = (int)race;

            //switch (race)
            //{
            //    case Race.Elf:
            //        Armor = 20;
            //        break;
            //    case Race.Ork:
            //        Armor = 40;
            //        break;
            //    case Race.Terrain:
            //        Armor = 10;
            //        break;
            //    default:
            //        throw new ArgumentException("Unknown race");
            //}

            //if (race == Race.Terrain)
            //{
            //    Armor = 20;
            //}
            //else if (race == Race.Ork)
            //{
            //    Armor = 40;
            //}
            //else if (race == Race.Elf)
            //{
            //    Armor = 10;
            //}
            //else
            //{
            //    throw new ArgumentException("Unknown race");
            //}
        }
        public Class1(Race race, int armor)
        {
            Race = race;
            Armor = armor;
        }
        public Class1(Race race, int armor, int speed)
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
            if (health == 0)
            {
                throw new InvalidOperationException("Can't hit a dead character");
            }
            if (damage > health)
            {
                damage = health;
            }

            health -= damage;
        }
    }
    public class Point2D
    {
        private readonly int x;
        private readonly int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
