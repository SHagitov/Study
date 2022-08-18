using System;

namespace Steps
{
    /// <summary>
    /// Структура, описывающая рабочего
    /// </summary>
    struct Worker
    {
        /// <summary>
        /// Должность
        /// </summary>
        public string Position;

        /// <summary>
        /// Зарплата
        /// </summary>
        public uint Salary;

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName;

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth;

        /// <summary>
        /// Вывод данных о сотрунике
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Должность: {Position} Зарплата: {Salary} Имя: {FirstName} Фамилия:{LastName} Дата рождения: {DateOfBirth.ToShortDateString()}";
        }


        #region Конструктор

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="Position">Должность</param>
        /// <param name="Salary">Зарплата</param>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        public Worker(string Position, uint Salary, string FirstName, string LastName, DateTime DateOfBirth)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }

        #region Конструкторы v 1.0
        ///// <summary>
        ///// Создание сотрудника
        ///// </summary>
        ///// <param name="Position">Должность</param>
        ///// <param name="Salary">Зарплата</param>
        ///// <param name="FirstName">Имя</param>
        ///// <param name="LastName">Фамилия</param>
        //public Worker(string Position, uint Salary, string FirstName, string LastName)
        //{
        //    this.Position = Position;
        //    this.Salary = Salary;
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.DateOfBirth = new DateTime(1900, 1, 1, 0, 0, 0);
        //}

        ///// <summary>
        ///// Создание сотрудника
        ///// </summary>
        ///// <param name="Position">Должность</param>
        ///// <param name="FirstName">Имя</param>
        ///// <param name="LastName">Фамилия</param>
        //public Worker(string Position, string FirstName, string LastName)
        //{
        //    this.Position = Position;
        //    this.Salary = 0;
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.DateOfBirth = new DateTime(1900, 1, 1, 0, 0, 0);
        //}

        ///// <summary>
        ///// Создание сотрудника
        ///// </summary>
        ///// <param name="Position">Должность</param>
        ///// <param name="FirstName">Имя</param>
        //public Worker(string Position, string FirstName)
        //{
        //    this.Position = Position;
        //    this.Salary = 0;
        //    this.FirstName = FirstName;
        //    this.LastName = String.Empty;
        //    this.DateOfBirth = new DateTime(1900, 1, 1, 0, 0, 0);
        //}

        ///// <summary>
        ///// Создание сотрудника
        ///// </summary>
        ///// <param name="FirstName">Имя</param>
        //public Worker(string FirstName)
        //{
        //    this.Position = String.Empty;
        //    this.Salary = 0;
        //    this.FirstName = FirstName;
        //    this.LastName = String.Empty;
        //    this.DateOfBirth = new DateTime(1900, 1, 1, 0, 0, 0);
        //}

        #endregion

        #region Конструкторы v 2.0

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="Position">Должность</param>
        /// <param name="Salary">Зарплата</param>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        public Worker(string Position, uint Salary, string FirstName, string LastName) :
            this(Position, Salary, FirstName, LastName, new DateTime(1900, 1, 1, 0, 0, 0))
        {

        }

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="Position">Должность</param>
        /// <param name="Salary">Зарплата</param>
        /// <param name="FirstName">Имя</param>
        public Worker(string Position, uint Salary, string FirstName) :
            this(Position, Salary, FirstName, String.Empty, new DateTime(1900, 1, 1, 0, 0, 0))
        {

        }

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="Position">Должность</param>
        /// <param name="FirstName">Имя</param>
        public Worker(string Position, string FirstName) :
            this(Position, 0, FirstName, String.Empty, new DateTime(1900, 1, 1, 0, 0, 0))
        {

        }

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="FirstName">Имя</param>
        public Worker(string FirstName) :
            this(String.Empty, 0, FirstName, String.Empty, new DateTime(1900, 1, 1, 0, 0, 0))
        {
            this.Salary = 100;
        }

        #endregion

        #endregion

    }
}
