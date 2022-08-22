using System;
using System.Collections.Generic;

namespace Steps
{
    /// <summary>
    /// Герой
    /// </summary>
    public abstract class Hero
    {
        public abstract void Motto();

        protected static uint defIndexName;
        protected static Random randomize = new Random();
        protected static List<string> dbNames;

        static Hero()
        {
            defIndexName = 1;
            dbNames = new List<string>();
        }

        protected byte level;
        protected uint hitPoint;
        protected uint maxHitPoint;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Уровень
        /// </summary>
        public byte Level { get { return this.level; } }

        /// <summary>
        /// Запас здоровья
        /// </summary>
        public uint HitPoint { get { return this.hitPoint; } }

        /// <summary>
        /// Создание героя
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Level">Уровень</param>
        /// <param name="HitPoint">Запас здоровья</param>
        public Hero(string Name, byte Level, uint HitPoint)
        {
            if (Name == String.Empty || Hero.dbNames.Contains(Name))
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)} #{Hero.defIndexName++}";
            }

            this.Name = Name;
            Hero.dbNames.Add(Name);
            this.level = Level;

            HitPoint = HitPoint != 0 ? HitPoint : (uint)Hero.randomize.Next(100, 400);
            this.hitPoint = HitPoint;
            this.maxHitPoint = HitPoint;
        }

        /// <summary>
        /// Создание героя с автопараметрами
        /// </summary>
        public Hero() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Метод, определяющий логику лечения
        /// </summary>
        public virtual void Treatment(uint Hp = 10)
        {
            if (this.hitPoint == 0) Console.WriteLine($"Лечение невозможно, {this.Name} в таверне");
            else { this.hitPoint = this.hitPoint + Hp <= this.maxHitPoint ? this.hitPoint + Hp : this.maxHitPoint; }
        }

        /// <summary>
        /// Метод, определяющий логику атаки
        /// </summary>
        public virtual uint Attack() { return 10; }

        /// <summary>
        /// Метод, определяющий логики в случае атаки другим героем
        /// </summary>
        public void Attacked(uint Damage)
        {
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
                if (this.hitPoint - Damage <= 0)
                {
                    this.hitPoint = 0;
                    this.Die();
                }
                else
                {
                    this.hitPoint -= Damage;
                }
            }
        }

        /// <summary>
        /// Логика отправки героя в таверну
        /// </summary>
        protected void Die()
        {
            Console.WriteLine($"У {this.Name} Критический уровень запаса жизни");
            this.Tavern();
        }

        /// <summary>
        /// Информация о нахождении в таверне
        /// </summary>
        protected void Tavern()
        {
            Console.WriteLine($"Герой {this.Name} в таверне");
        }

        /// <summary>
        /// Информация о герое
        /// </summary>
        /// <returns></returns>
        public string HeroInformation()
        {
            return String.Format("Name:{0,10} |  Level:{1,4} |  HitPoint:{2,6} |  Type:{3,12}",
                this.Name,
                this.Level,
                this.HitPoint,
                this.GetType().Name
                );
        }

    }
}
