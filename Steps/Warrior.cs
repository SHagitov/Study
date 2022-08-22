using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    /// <summary>
    /// Герой "Warrior"
    /// </summary>
    class Warrior : Hero, IRampage
    {

        /// <summary>
        /// Девиз
        /// </summary>
        public override void Motto() { Console.WriteLine($"{this.Name}: Мой молот готов служить всезнающему!"); }


        uint blockDamage;



        /// <summary>
        /// Создание героя
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Level">Уровень</param>
        /// <param name="HitPoint">Запас здоровья</param>
        public Warrior(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
            this.blockDamage = 2;
            this.Charge = 5;
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
            this.Charge = 5;
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
