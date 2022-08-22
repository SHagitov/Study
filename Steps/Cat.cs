using System;

namespace Steps
{
    /// <summary>
    /// Кот
    /// </summary>
    public struct Cat1
    {
        /// <summary>
        /// Кличка
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Порода
        /// </summary>
        public string Breed;
    }
    /// <summary>
    /// Ходят слухи, что все любят котиков...
    /// </summary>
    /// <summary>
    /// Ходят слухи, что все любят котиков...
    /// </summary>
    public class Cat
    {
        /// <summary>
        /// Создание экземпляра котика
        /// </summary>
        /// <param name="Nickname">Кличка</param>
        /// <param name="Breed">Порода</param>
        public Cat(string Nickname, string Breed, int Weight)
        {
            this.Nickname = Nickname;
            this.breed = Breed;
            this.Weight = Weight;
        }

        /// <summary>
        /// Порода
        /// </summary>
        private string breed;

        /// <summary>
        /// Вес
        /// </summary>
        private int Weight { get; }

        /// <summary>
        /// Свойство, описываюее кличку
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Свойство, описываюее породу
        /// </summary>
        public string Breed => "Порода: " + this.breed;

        /// <summary>
        /// Метод, определеющий логику игры котика
        /// </summary>
        public void ToPlay() { Console.WriteLine($"{this.Nickname} играет..."); }

        /// <summary>
        /// Метод, определеющий логику сна котика
        /// </summary>
        public void ToSleep() { Console.WriteLine($"{this.Nickname} спит..."); }

        /// <summary>
        /// Метод, определеющий логику питания котика
        /// </summary>
        public void ToEat() { Console.WriteLine($"{this.Nickname} кушает..."); }

        /// <summary>
        /// Мяуканье котика
        /// </summary>
        public void ToMew() { Console.WriteLine($"Мяу!"); }

        public override string ToString()
        {
            return $"{Nickname,10} {breed,10} {Weight,3}";
        }
    }
}
