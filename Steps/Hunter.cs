using System;

namespace Steps
{
    /// <summary>
    /// Герой "Hunter"
    /// </summary>
    internal class Hunter : Hero, IRampage
    {
        /// <summary>
        /// Девиз
        /// </summary>
        public override void Motto() { Console.WriteLine($"{this.Name}: Охота началась!"); }


        /// <summary>
        /// Создание героя
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Level">Уровень</param>
        /// <param name="HitPoint">Запас здоровья</param>
        public Hunter(string Name, byte Level, uint HitPoint)
              : base(Name, Level, HitPoint)
        {
            this.Charge = 3;
        }

        /// <summary>
        /// Создание героя с автопараметрами
        /// </summary>
        public Hunter() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Бонусный выстрел
        /// </summary>
        public void HeadShot(Hero Target)
        {
            Target.Attacked(10);
            if (Hunter.randomize.Next(4) != 0)
            {
                Target.Attacked((uint)Hunter.randomize.Next(10, 20));
            }
        }

        public int Charge { get; set; }

        public void Recharge()
        {
            this.Charge = 3;
        }

        public void UltraAttack(Hero Target)
        {
            for (int i = 0; i < this.Charge; i++)
            {
                Target.Attacked(10);
            }
            this.Charge = 0;
        }
    }
}
