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
        public int Indicator => condition ? 1 : 0;

        /// <summary>
        /// Создание компьютера
        /// </summary>
        /// <param name="Title">Имя компьютера</param>
        public Computer3(string Title)
        {
            this.Title = Title;
            condition = false;
        }

        /// <summary>
        /// Питание
        /// </summary>
        public void Power()
        {
            if (condition)
            {
                PowerOff();
                condition = false;
            }
            else
            {
                PowerOn();
                condition = true;
            }

        }

        #region Методы вкл\выкл

        /// <summary>
        /// Загрузка BIOS
        /// </summary>
        private void ActivationBIOS() { Console.WriteLine($"{Title} | Activation BIOS..."); }

        /// <summary>
        /// Загрузка OS
        /// </summary>
        private void ActivationOS() { Console.WriteLine($"{Title} | Activation OS..."); }

        /// <summary>
        /// Приветствие
        /// </summary>
        private void Greeting() { Console.WriteLine($"{Title} | Hello..."); }

        /// <summary>
        /// Выгрузка BIOS
        /// </summary>
        private void DeactivationBIOS() { Console.WriteLine($"{Title} | Deactivation BIOS..."); }

        /// <summary>
        /// Выгрузка OS
        /// </summary>
        public void DeactivationOS() { Console.WriteLine($"{Title} | Deactivation OS..."); }

        /// <summary>
        /// Прощание
        /// </summary>
        private void Parting() { Console.WriteLine($"{Title} | Bye..."); }

        #endregion

        /// <summary>
        /// Включение
        /// </summary>
        private void PowerOn()
        {
            ActivationBIOS();
            ActivationOS();
            Greeting();
            Calculation();
        }

        /// <summary>
        /// Выключение
        /// </summary>
        private void PowerOff()
        {
            Parting();
            DeactivationOS();
            DeactivationBIOS();
        }

        /// <summary>
        /// Метод, демонстрирующий работу
        /// </summary>
        private void Calculation()
        {
            Console.WriteLine($"\n{Title} | Calculation...\n");
        }

    }
}
