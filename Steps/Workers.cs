namespace Steps
{
    /// <summary>
    /// Класс, описывающий модель работника
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия работника
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Возраст работника
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Зарплата работника
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Конструктор, позволяющий присвоить значение соответствующим полям работника
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Salary">Зарплата</param>
        public Worker(string FirstName, string LastName, int Age, int Salary)
        {
            this.FirstName = FirstName; // Сохранить переданное значение имени
            this.LastName = LastName;   // Сохранить переданное значение фамилии
            this.Age = Age;             // Сохранить переданное значение возраста
            this.Salary = Salary;       // Сохранить переданное значение зарплаты
        }

        /// <summary>
        /// Организация вывода информации о работнике
        /// </summary>
        /// <returns>Строковое представление информации</returns>
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {Age,10} {Salary,10:## ###} руб.";
        }
    }

    /// <summary>
    /// Класс, описывающая рабочего
    /// </summary>
    public class Worker_1
    {
        //    /// <summary>
        //    /// Должность
        //    /// </summary>
        //    public string Position { get; set; }

        //    /// <summary>
        //    /// Зарплата
        //    /// </summary>
        //    public uint Salary { get; set; }

        //    /// <summary>
        //    /// Имя
        //    /// </summary>
        //    public string FirstName { get; set; }


        //    /// <summary>
        //    /// Вывод данных о сотрунике
        //    /// </summary>
        //    /// <returns></returns>
        //    public override string ToString()
        //    {
        //        return $"Должность: {Position} Зарплата: {Salary} Имя: {FirstName}";
        //    }

        //    /// <summary>
        //    /// Создание сотрудника
        //    /// </summary>
        //    /// <param name="Position">Должность</param>
        //    /// <param name="Salary">Зарплата</param>
        //    /// <param name="FirstName">Имя</param>
        //    public Worker_1(string Position, uint Salary, string FirstName)
        //    {
        //        this.Position = Position;
        //        this.Salary = Salary;
        //        this.FirstName = FirstName;
        //}


        /// <summary>
        /// Табельный номер
        /// </summary>
        //public int Id { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        //public string Position { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        //public uint Salary { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        //public string FirstName { get; set; }


        /// <summary>
        /// Вывод данных о сотрунике
        /// </summary>
        /// <returns></returns>
        //public override string ToString()
        //{
        //    return $"Id: {Id} Должность: {Position} Зарплата: {Salary} Имя: {FirstName} ";
        //}

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name = "Position" > Должность </ param >
        /// < param name="Salary">Зарплата</param>
        /// <param name = "FirstName" > Имя </ param >
        //public Worker(string Position, uint Salary, string FirstName, int Id)
        //{
        //    this.Id = Id;
        //    this.Position = Position;
        //    this.Salary = Salary;
        //    this.FirstName = FirstName;
        //}
    }
}
