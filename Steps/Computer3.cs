using System;

namespace Steps
{
    /// <summary>
    /// Компьютер
    /// </summary>
    public struct Computer3
    {

        /// <summary>
        /// Имя компьютера
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        private bool condition;

        /// <summary>
        /// Индикатор состояния
        /// </summary>
        public int Indicator => this.condition ? 1 : 0;

        /// <summary>
        /// Создание компьютера
        /// </summary>
        /// <param name="Title">Имя компьютера</param>
        public Computer3(string Title)
        {
            this.Title = Title;
            this.condition = false;
        }

        /// <summary>
        /// Питание
        /// </summary>
        public void Power()
        {
            if (this.condition)
            {
                this.PowerOff();
                this.condition = false;
            }
            else
            {
                this.PowerOn();
                this.condition = true;
            }

        }

        #region Методы вкл\выкл

        /// <summary>
        /// Загрузка BIOS
        /// </summary>
        private void ActivationBIOS() { Console.WriteLine($"{this.Title} | Activation BIOS..."); }

        /// <summary>
        /// Загрузка OS
        /// </summary>
        private void ActivationOS() { Console.WriteLine($"{this.Title} | Activation OS..."); }

        /// <summary>
        /// Приветствие
        /// </summary>
        private void Greeting() { Console.WriteLine($"{this.Title} | Hello..."); }

        /// <summary>
        /// Выгрузка BIOS
        /// </summary>
        private void DeactivationBIOS() { Console.WriteLine($"{this.Title} | Deactivation BIOS..."); }

        /// <summary>
        /// Выгрузка OS
        /// </summary>
        public void DeactivationOS() { Console.WriteLine($"{this.Title} | Deactivation OS..."); }

        /// <summary>
        /// Прощание
        /// </summary>
        private void Parting() { Console.WriteLine($"{this.Title} | Bye..."); }

        #endregion

        /// <summary>
        /// Включение
        /// </summary>
        private void PowerOn()
        {
            this.ActivationBIOS();
            this.ActivationOS();
            this.Greeting();
            this.Calculation();
        }

        /// <summary>
        /// Выключение
        /// </summary>
        private void PowerOff()
        {
            this.Parting();
            this.DeactivationOS();
            this.DeactivationBIOS();
        }

        /// <summary>
        /// Метод, демонстрирующий работу
        /// </summary>
        private void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }

    }
}
