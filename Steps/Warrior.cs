using System;

namespace Steps
{
    /// <summary>
    /// Герой "Warrior"
    /// </summary>
    internal class Warrior : Hero, IRampage
    {

        /// <summary>
        /// Девиз
        /// </summary>
        public override void Motto() { Console.WriteLine($"{Name}: Мой молот готов служить всезнающему!"); }

        private readonly uint blockDamage;



        /// <summary>
        /// Создание героя
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Level">Уровень</param>
        /// <param name="HitPoint">Запас здоровья</param>
        public Warrior(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
            blockDamage = 2;
            Charge = 5;
        }

        /// <summary>
        /// Создание героя с автопараметрами
        /// </summary>
        public Warrior() : this("", 1, 0)
        {

        }

        /// <summary>
        /// Получение урона
        /// </summary>
        /// <param name="Damage">Количество урона</param>
        public new void Attacked(uint Damage)
        {
            base.Attacked(Damage / blockDamage);
        }

        // IRampage

        public int Charge { get; set; }

        public void Recharge()
        {
            Charge = 5;
        }

        public void UltraAttack(Hero Target)
        {
            for (int i = 0; i < Charge; i++)
            {
                Target.Attacked(10);
            }
            Charge = 0;
        }
    }
}
