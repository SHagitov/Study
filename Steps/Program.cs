using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace Steps
{

    public static class Program
    {
        private static void Main(string[] args)
        {
            Covariance();
            Console.ReadLine();
        }

        private static void Covariance()
        {
            #region 

            List<Kiwi> listKiwi = new List<Kiwi>() { new Kiwi() };
            List<Bird> listBird = new List<Bird>() { new Bird() };
            List<Animal> listAnimal = new List<Animal> { new Animal() };

            // Ковариантность даёт возможность использовать более конкретный тип, чем заданный изначально

            IEnumerable<Animal> enumerableAnimal = listKiwi;

            listAnimal = enumerableAnimal.ToList();

            IEnumerable<object> enumerableObject = listKiwi;

            List<object> listObject = enumerableObject.ToList();

            foreach (object item in listObject)
            {
                Console.WriteLine(item.GetType());
            }

            Console.ReadKey();
            Console.Clear();

            #endregion

            //namespace Example
            //{

            //    abstract class Animal
            //    {
            //        public string Name { get; private set; }
            //        public Animal(string Name) { this.Name = Name; }
            //    }

            //    class Bird : Animal
            //    {
            //        public Bird(string Name) : base(Name) { }
            //    }

            //    #region ToDo Важно
            //    // interface IAnimal<out T>

            //    // T GetAnimal { get; set; }
            //    // void Method(T args);
            //    // Ошибка CS1961  Недопустимое отклонение: 
            //    // Параметр типа "T" должен быть инвариантно, допустимым на "IAnimal<T>.GetAnimal". 
            //    // "T" является ковариантный.Example_1333    

            //    #endregion

            //    interface IAnimal<out T>
            //        where T : Animal
            //    {
            //        T GetValue { get; }
            //        T GetValueMethod(); 
            //    }

            //    class Kiwi : IAnimal<Bird>
            //    {
            //        public Bird GetValue { get { return new Bird("KiwiBirdP"); } }

            //        public Bird GetValueMethod() { return new Bird("KiwiBirdM"); }
            //    }


            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            Kiwi concreteKiwi = new Kiwi();
            //            IAnimal<Bird> concreteBirdIAnimal = concreteKiwi;
            //            IAnimal<Animal> concreteAnimalIAnimal = concreteKiwi; // Нельзя т к типы инвариантны
            //            // Ковариантность даёт возможность использовать более конкретный тип, чем заданный изначально
            //        }
            //    }
            //}


        }
        private static void Invariance()
        {
            Kiwi concreteKiwi = new Kiwi();

            Bird concreteBird = concreteKiwi;

            Animal concreteAnimal = concreteBird;
            concreteAnimal = concreteKiwi;

            object abstractObject = concreteAnimal;
            abstractObject = concreteBird;
            abstractObject = concreteAnimal;


            List<Kiwi> listKiwi = new List<Kiwi>();

            List<Bird> listBird = new List<Bird>();

            List<Animal> listAnimal = new List<Animal>();

            // List<Animal> errorListAnimal = new List<Bird>();
            // List<Bird> errorListBird = new List<Kiwi>();

            // т к List<Animal> и List<Bird> никак не связаны в иерархии наследования

            // Инвариантность даёт возможность использовать только тот тип, 
            // который изначально задан  в обобщении

        }
        private static void Example0()
        {
            //static void Swap(ref int A, ref int B) { int c = A; A = B; B = c; }
            //static void Swap(ref double[] A, ref double[] B) { double[] c = A; A = B; B = c; }
            //static void Swap(ref byte[] A, ref byte[] B) { byte[] c = A; A = B; B = c; }

            #region T

            static void Swap<T>(ref T A, ref T B) { (B, A) = (A, B); }

            #endregion

            #region 

            int a = 1, b = 2;
            Console.WriteLine($"a = {a}  b = {b} ");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a = {a}  b = {b} "); Console.WriteLine();

            double[] x = { 1.1, 2.3, 4.5 };
            double[] y = { 6.7, 8.9, 10 };

            Console.Write("x: "); foreach (double e in x)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            Console.Write("y: "); foreach (double e in y)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();

            Swap<double[]>(ref x, ref y);

            Console.Write("x: "); foreach (double e in x)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            Console.Write("y: "); foreach (double e in y)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine(); Console.WriteLine();

            byte[] k = { 1, 2, 4 };
            byte[] l = { 6, 8, 10 };

            Console.Write("k: "); foreach (byte e in k)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            Console.Write("l: "); foreach (byte e in l)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();

            Swap<byte[]>(ref k, ref l);

            Console.Write("k: "); foreach (byte e in k)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            Console.Write("l: "); foreach (byte e in l)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();

            #endregion

            #region T

            Console.WriteLine("\n---\n");

            Swap<int>(ref a, ref b);
            Console.WriteLine($"a = {a}  b = {b} "); Console.WriteLine();

            Swap<byte[]>(ref k, ref l);
            Console.Write("k: "); foreach (byte e in k)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            Console.Write("l: "); foreach (byte e in l)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();



            #endregion
        }
        private static void Temporary()
        {
            #region 

            Dictionary<int, string> dic = new Dictionary<int, string>();

            #endregion

            #region Temporary<T, U>

            Console.ReadKey();

            Temporary<double, int> t1 = new Temporary<double, int>(28.09, 1990); t1.GetPropertyInformation();
            Temporary<string, bool> t2 = new Temporary<string, bool>("value", false); t2.GetPropertyInformation();
            Temporary<bool, double> t3 = new Temporary<bool, double>(false, 22.33); t3.GetPropertyInformation();

            #endregion
        }
        private static void Something()
        {
            #region SomethingA

            SomethingA a = new SomethingA();
            for (int i = 0; i < a.array.Length; i++)
            {
                Console.Write($"{a.array[i],3} ");
            }
            Console.WriteLine();

            Console.ReadKey();

            #endregion

            #region SomethingB

            SomethingB b = new SomethingB();

            b.Reset();

            while (b.MoveNext())
            {
                Console.Write($"{b.Current(),3} ");
            }


            Console.WriteLine();

            b.Reset();

            while (b.MoveNext())
            {
                Console.Write($"{b.Current(),3} ");
            }

            Console.WriteLine();

            Console.ReadKey();
            #endregion

        }

        private class A { }

        private class B : A { }

        private class C : A { }

        private class D : A { }

        private class E : B { }

        private class MyClass<T1, T2, T3>
            where T1 : T2
            where T3 : T1
        {

        }

        private static void MyyClass()
        {
            MyClass<B, A, E> my = new MyClass<B, A, E>();
            //MyClass<C, A, A> myClass1 = new MyClass<C, A, A>();
            //MyClass<E, A, A> myClass2 = new MyClass<E, A, A>();
            //MyClass<E, B, C> myClass3 = new MyClass<E, B, C>();

            //MyClass<string, object, int> myClass4 = new MyClass<string, object, int>();
            //MyClass<int, object, int> myClass5 = new MyClass<int, object, int>();
            //MyClass<int, ValueType, int> myClass6 = new MyClass<int, ValueType, int>();
            //MyClass<ValueType, object, int> myClass7 = new MyClass<ValueType, object, int>();
        }
        private class Class1<T>
        where T : new()
        {
            public T field;

            public Class1()
            {
                field = new T();
            }
        }
        public class SomethingA
        {
            public int[] array;
            public SomethingA() { array = Enumerable.Range(1, 10).ToArray(); }

            //public int this[int index]
            //{
            //    get { return this.array[index]; }
            //    set { this.array[index] = value; }
            //}

            // public int Count { get { return this.array.Length; } }

        }
        public class SomethingB
        {
            private int index;

            //  Возвращает элемент, соответствующий текущей позиции 
            public int Current() { return array[index]; }

            // Перемещает перечислитель к следующему элементу 
            public bool MoveNext()
            {
                return ++index < array.Length;
            }


            // Сводка:
            // Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом
            public void Reset() { index = -1; }

            private readonly int[] array;
            public SomethingB()
            {
                array = Enumerable.Range(11, 10).ToArray();
                index = -1;
            }

            //public int this[int index]
            //{
            //    get { return this.array[index]; }
            //    set { this.array[index] = value; }
            //}

            //public int Count { get { return this.array.Length; } }

        }

        private static void RepositoryWorkers()
        {
            Repository rep = new Repository(10);
            rep.Print("Вывод");

            foreach (object item in rep)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();
        }

        private static void Robots()
        {
            Robot robot1 = new Robot("Robot_1", "Test");
            List<Robot> robots = new List<Robot> { new Robot("Robot_1", "Test") };
            Robot robot2 = new Robot("Robot_1", "Test");
            Console.WriteLine(robots.Contains(robot2));
            Console.WriteLine(robots.Contains(robot1));

            Console.ReadKey();
            Console.Clear();

            _ = new Robot("Robot_1", "Test");
            _ = new List<Robot> { new Robot("Robot_1", "Test") };
            _ = new Robot("Robot_1", "Test");
            Console.WriteLine(robots.Contains(robot2));
            Console.WriteLine(robots.Contains(robot1));

            Console.ReadKey();
            Console.Clear();

            _ = new Robot("Robot_1", "Test");
            _ = new List<Robot> { new Robot("Robot_1", "Test") };
            _ = new Robot("Robot_1", "Test");
            Console.WriteLine(robots.Contains(robot2));
            Console.WriteLine(robots.Contains(robot1));

            List<Cat> cats = new List<Cat>();

            Random r = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Cat c = new Cat($"Котик_{i}", $"Порода_{i}", r.Next(3, 12));
                cats.Add(c);
                Console.WriteLine(c);
            }

            Console.ReadKey();
            Console.Clear();

            foreach (Cat e in cats)
            {
                Console.WriteLine(e);
            }
        }

        private static void Interface()
        {
            //namespace Example
            //{


            //    class A
            //    {
            //        public void M()
            //        {

            //        }
            //    }

            //    class B
            //    {

            //    }

            //    //class C : A, B
            //    //{

            //    //}

            //    interface IInterface1
            //    {

            //    }

            //    interface IInterface2
            //    {

            //    }

            //    class C : B, IInterface1, IInterface2
            //    {

            //    }



            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            #region interface

            //            // Предназначены для описания общего поведения
            //            // Иногда используется для гарантии, реализации некоторого поведения
            //            // Интерфейс - аналог полностью абстрактного класса, но позволяет множественное "наследование"

            //            // Интерфейсы могут содержать 
            //            //  Методы
            //            //  Свойства
            //            //  Индексаторы
            //            //  События

            //            #endregion

            //        }
            //    }
            //}
        }

        private static void HeroClass()
        {
            Druid druid = new Druid("druid", 1, 500);

            Console.WriteLine(druid.HeroInformation());

            List<IRampage> rampages = new List<IRampage>()
            {
                new Hunter(),
                new Warrior(),
            };

            foreach (IRampage e in rampages)
            {
                e.UltraAttack(druid);

                //Console.WriteLine(druid.HeroInformation());
            }

            Console.WriteLine(druid.HeroInformation());

            foreach (IRampage e in rampages)
            {
                e.Recharge();

                //Console.WriteLine(druid.HeroInformation());
            }

            foreach (IRampage e in rampages)
            {
                e.UltraAttack(druid);

                //Console.WriteLine(druid.HeroInformation());
            }
            Console.WriteLine(druid.HeroInformation());

            foreach (IRampage e in rampages)
            {
                e.UltraAttack(druid);

                //Console.WriteLine(druid.HeroInformation());
            }
            Console.WriteLine(druid.HeroInformation());


            //Полиморфизм.
            #region Команда

            //// Создать 20 случайных героев

            //int count = 10;

            //Random r = new Random();

            //int countDruid = r.Next(0, count);
            //int countHunter = r.Next(0, count - countDruid);
            //int countWarrior = count - countDruid - countHunter;

            //Console.WriteLine($"countDruid: {countDruid} countHunter: {countHunter} countWarrior: {countWarrior}");

            //List<Druid> druids = new List<Druid>();

            //for (int i = 0; i < countDruid; i++)
            //{
            //    druids.Add(new Druid());
            //    Console.WriteLine(druids[i].HeroInformation());
            //    druids[i].Motto();

            //}

            //Console.WriteLine();
            //List<Hunter> hunters = new List<Hunter>();

            //for (int i = 0; i < countHunter; i++)
            //{
            //    hunters.Add(new Hunter());
            //    Console.WriteLine(hunters[i].HeroInformation());
            //    hunters[i].Motto();
            //}

            //Console.WriteLine();
            //List<Warrior> warriors = new List<Warrior>();

            //for (int i = 0; i < countWarrior; i++)
            //{
            //    warriors.Add(new Warrior());
            //    Console.WriteLine(warriors[i].HeroInformation());
            //    warriors[i].Motto();
            //}

            #endregion

            #region Полиморфизм

            //Hero hero = new Hero(); Console.WriteLine(hero.HeroInformation());
            //hero = new Druid(); Console.WriteLine(hero.HeroInformation());
            //hero = new Hunter(); Console.WriteLine(hero.HeroInformation());
            //hero = new Warrior(); Console.WriteLine(hero.HeroInformation());

            #endregion

            #region is as

            //Hero hero = new Hero(); Console.WriteLine(hero.HeroInformation());
            //hero = new Druid(); Console.WriteLine(hero.HeroInformation());


            //((Druid)hero).Heal();

            //(hero as Druid).Heal();

            #endregion

            #region Команда с полиморфизмом

            //Random r = new Random();

            //List<Hero> heroes = new List<Hero>();

            //for (int i = 0; i < 10; i++)
            //{
            //    switch (r.Next(3))
            //    {
            //        case 0: heroes.Add(new Druid()); break;
            //        case 1: heroes.Add(new Hunter()); break;
            //        default: heroes.Add(new Warrior()); break;
            //    }

            //    Console.WriteLine(heroes[i]);

            #region _

            //(heroes[i] as Druid).Heal();

            #region 


            //if (heroes[i] is Druid) (heroes[i] as Druid).Heal();
            //if (heroes[i].GetType() == typeof(Druid)) ((Druid)heroes[i]).Heal();

            #endregion

            #endregion


            //heroes[i].Motto();
            //}

            #endregion

        }

        private static void Classes()
        {
            /// Создание котиков
            //Cat cat1 = new Cat("Басик", "Русская голубая кошка");
            //Cat cat2 = new Cat("Мурзик", "Мейн-кун");
            //Cat cat3 = new Cat("Плюмгильда", "Манчкин");

            /// Создание домов
            House house1 = new House(18, 182, "г. Смоленск, ул. Ленина, д. 1");
            House house2 = new House(18, 182, "п. Запрудня, ул. Пролетарский проспект, д. 2");

            /// Создание роботов
            Robot robot = new Robot("С-3PO", "Звёздные воины");
            Console.WriteLine("Good");
        }

        private static void SerializationComplicatedJson()
        {
            #region Parse

            //string json = File.ReadAllText("telegram.json");
            //Console.WriteLine(json); Console.ReadLine();Console.Clear();

            //Console.WriteLine(JObject.Parse(json)["ok"].ToString());

            //var messages = JObject.Parse(json)["result"].ToArray();
            //Console.WriteLine();
            //foreach (var item in messages)
            //{
            //    Console.WriteLine(item["message"]["message_id"].ToString());
            //    Console.WriteLine(item["message"]["text"].ToString());
            //    Console.WriteLine(item["message"]["chat"]["username"].ToString());
            //    Console.WriteLine();
            //}

            //Console.ReadLine(); Console.Clear();
            #endregion

            #region Create


            //JArray array = new JArray();

            //JObject mainTree = new JObject();


            //mainTree["ok"] = true;

            //JObject o = new JObject();
            //o["update_id"] = 1880746;
            //o["message_id"] = 886;

            //array.Add(o);
            //array.Add(o);
            //array.Add(o);

            //mainTree["messages"] = array;

            //JObject userObj = new JObject();
            //userObj["id"] = 220310598;
            //userObj["first_name"] = "С.K.";
            //userObj["username"] = "sk";

            //mainTree["user"] = userObj;


            //string json = mainTree.ToString();

            //Console.WriteLine(json);

            #endregion

            #region _

            //List<Worker> list = new List<Worker>();

            //JObject data = new JObject();
            //JArray jArray = new JArray();

            //for (uint i = 1; i <= 5; i++)
            //{
            //    JObject obj = new JObject
            //    {
            //        ["FirstName"] = $"Имя_{i}",
            //        ["LastName"] = $"Фамилия_{i}",
            //        ["Position"] = $"Должность_{i}",
            //        ["Department"] = $"Отдел_{i}",
            //        ["Salary"] = i * 1000
            //    };

            //    jArray.Add(obj);
            //}

            //Console.WriteLine(jArray.ToString());



            #endregion
        }

        private static void SerializationComplicatedXml()
        {
            #region XDocument.Parse


            //string xml = System.IO.File.ReadAllText("_weather.xml");

            //var col = XDocument.Parse(xml)
            //                   .Descendants("MMWEATHER")
            //                   .Descendants("REPORT")
            //                   .Descendants("TOWN")
            //                   .Descendants("FORECAST")
            //                   .ToList();

            //foreach (var item in col)
            //{
            //    Console.WriteLine($"\n\n{item}");
            //}

            //Console.ReadLine(); Console.Clear();

            //foreach (var item in col)
            //{
            //    Console.WriteLine("day: {0} month: {1} year: {2}",
            //                        item.Attribute("day").Value,
            //                        item.Attribute("month").Value,
            //                        item.Attribute("year").Value);
            //}

            //Console.ReadLine(); Console.Clear();

            //foreach (var item in col)
            //{
            //    Console.WriteLine("min: {0} max: {1}",
            //                        item.Element("TEMPERATURE").Attribute("min").Value,
            //                        item.Element("TEMPERATURE").Attribute("max").Value);
            //}

            //Console.ReadLine(); Console.Clear();


            //string city = XDocument.Parse(xml)
            //                       .Element("MMWEATHER")
            //                       .Element("REPORT")
            //                       .Element("TOWN")
            //                       .Attribute("sname").Value;

            //Console.WriteLine(city);

            #endregion

            #region XDocument.Create

            XElement myMMWEATHER = new XElement("MMWEATHER");
            XElement myTOWN = new XElement("TOWN");
            XElement myFORECAST = new XElement("FORECAST");
            XElement myTEMPERATURE = new XElement("TEMPERATURE");

            XAttribute xAttributeMin = new XAttribute("min", 7);
            XAttribute xAttributeMax = new XAttribute("max", 10);

            myTEMPERATURE.Add(xAttributeMin, xAttributeMax);
            myFORECAST.Add(myTEMPERATURE);

            XAttribute xAttributeCityName = new XAttribute("sname", "Москва");


            myTOWN.Add(myFORECAST, xAttributeCityName);
            myTOWN.Add(myFORECAST);
            myTOWN.Add(myFORECAST);
            myTOWN.Add(myFORECAST);

            myMMWEATHER.Add(myTOWN);

            myMMWEATHER.Save("_myWeather.xml");

            #endregion

        }

        private static void SerializationXml()
        {
            #region class Worker
            //public class Worker
            //{
            //    #region Конструкторы

            //    public Worker()
            //    {

            //    }

            //    /// <summary>
            //    /// Создание сотрудника
            //    /// </summary>
            //    /// <param name="FirstName">Имя</param>
            //    /// <param name="LastName">Фамилия</param>
            //    /// <param name="Position">Должность</param>
            //    /// <param name="Department">Отдел</param>
            //    /// <param name="Salary">Оплата труда</param>
            //    public Worker(string FirstName, string LastName, string Position, uint Salary, string Department)
            //    {
            //        this.firstName = FirstName;
            //        this.lastName = LastName;
            //        this.position = Position;
            //        this.department = Department;
            //        this.salary = Salary;
            //    }

            //    #endregion

            //    #region Методы

            //    public string Print()
            //    {
            //        return $"{this.firstName,15} {this.lastName,15} {this.department,15} {this.position,15} {this.salary,10}";
            //    }

            //    #endregion

            //    #region Свойства

            //    /// <summary>
            //    /// Имя
            //    /// </summary>
            //    public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

            //    /// <summary>
            //    /// Фамилия
            //    /// </summary>
            //    public string LastName { get { return this.lastName; } set { this.lastName = value; } }

            //    /// <summary>
            //    /// Должность
            //    /// </summary>
            //    public string Position { get { return this.position; } set { this.position = value; } }

            //    /// <summary>
            //    /// Отдел
            //    /// </summary>
            //    public string Department { get { return this.department; } set { this.department = value; } }

            //    /// <summary>
            //    /// Оплата труда
            //    /// </summary>
            //    public uint Salary { get { return this.salary; } set { this.salary = value; } }

            //    /// <summary>
            //    /// Почасовая оплата
            //    /// </summary>
            //    public double HourRate
            //    {
            //        get
            //        {
            //            byte workingDays = 25; // Рабочих дней в месяце
            //            byte workingHours = 8; // Рабочих часов в день
            //            return ((double)Salary) / workingDays / workingHours;
            //        }
            //    }

            //    #endregion

            //    #region Поля

            //    /// <summary>
            //    /// Поле "Имя"
            //    /// </summary>
            //    private string firstName;

            //    /// <summary>
            //    /// Поле "Фамилия"
            //    /// </summary>
            //    private string lastName;

            //    /// <summary>
            //    /// Поле "Должность"
            //    /// </summary>
            //    private string position;

            //    /// <summary>
            //    /// Поле "Отдел"
            //    /// </summary>
            //    private string department;

            //    /// <summary>
            //    /// Поле "Оплата труда"
            //    /// </summary>
            //    private uint salary;

            //    #endregion
            //}
            #endregion
            #region XML:Создание и чтение файлов
            //class Program
            //{

            //    /// <summary>
            //    /// Метод сериализации Worker
            //    /// </summary>
            //    /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
            //    /// <param name="Path">Путь к файлу</param>
            //    static void SerializeWorker(Worker СoncreteWorker, string Path)
            //    {
            //        // Создаем сериализатор на основе указанного типа 
            //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            //        // Создаем поток для сохранения данных
            //        Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            //        // Запускаем процесс сериализации
            //        xmlSerializer.Serialize(fStream, СoncreteWorker);

            //        // Закрываем поток
            //        fStream.Close();
            //    }

            //    /// <summary>
            //    /// Метод десериализации Worker
            //    /// </summary>
            //    /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
            //    /// <param name="Path">Путь к файлу</param>
            //    static Worker DeserializeWorker(string Path)
            //    {
            //        Worker tempWorker = new Worker();
            //        // Создаем сериализатор на основе указанного типа 
            //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            //        // Создаем поток для чтения данных
            //        Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            //        // Запускаем процесс десериализации
            //        tempWorker = xmlSerializer.Deserialize(fStream) as Worker;

            //        // Закрываем поток
            //        fStream.Close();

            //        // Возвращаем результат
            //        return tempWorker;
            //    }

            //    /// <summary>
            //    /// Метод сериализации List<Worker >
            //    /// </summary>
            //    /// <param name="СoncreteWorker">Коллекция для сериализации</param>
            //    /// <param name="Path">Путь к файлу</param>
            //    static void SerializeWorkerList(List<Worker> СoncreteWorkerList, string Path)
            //    {
            //        // Создаем сериализатор на основе указанного типа 
            //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            //        // Создаем поток для сохранения данных
            //        Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            //        // Запускаем процесс сериализации
            //        xmlSerializer.Serialize(fStream, СoncreteWorkerList);

            //        // Закрываем поток
            //        fStream.Close();
            //    }

            //    /// <summary>
            //    /// Метод десериализации Worker
            //    /// </summary>
            //    /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
            //    /// <param name="Path">Путь к файлу</param>
            //    static List<Worker> DeserializeWorkerList(string Path)
            //    {
            //        List<Worker> tempWorkerCol = new List<Worker>();
            //        // Создаем сериализатор на основе указанного типа 
            //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            //        // Создаем поток для чтения данных
            //        Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            //        // Запускаем процесс десериализации
            //        tempWorkerCol = xmlSerializer.Deserialize(fStream) as List<Worker>;

            //        // Закрываем поток
            //        fStream.Close();

            //        // Возвращаем результат
            //        return tempWorkerCol;
            //    }


            //    static void Main(string[] args)
            //    {
            //        #region Worker

            //        Worker worker = new Worker("Bill", "Gates", "CEO", uint.MaxValue, "Microsoft Corporation");
            //        Console.WriteLine(worker.Print());

            //        SerializeWorker(worker, "_bill.xml");

            //        worker = DeserializeWorker("_satya.xml");
            //        Console.WriteLine(worker.Print());

            //        #endregion

            //        #region List<Worker>

            //        List<Worker> list = new List<Worker>();

            //        for (uint i = 1; i <= 5; i++)
            //        {
            //            list.Add(new Worker($"Имя_{i}", $"Фамилия_{i}", $"Должность_{i}", i * 1000, $"Департамент_{i}"));
            //        }

            //        SerializeWorkerList(list, "_listWorker.xml");

            //        list = DeserializeWorkerList("_listWorker.xml");

            //        #endregion
            //    }
            //}
            #endregion
        }

        private static void SerializationInto()
        {
            // Сериализация — процесс перевода какой-либо структуры данных в последовательность битов
            // Десериализации — восстановление начального состояния структуры данных из битовой последовательности 

            #region csv

            // Имя_1,Фамилия_1,Должность_778,4931,Отдел_94
            // Имя_2,Фамилия_2,Должность_368,3838,Отдел_88
            // Имя_3,Фамилия_3,Должность_731,4746,Отдел_4
            // Имя_4,Фамилия_4,Должность_917,3765,Отдел_7
            // Имя_5,Фамилия_5,Должность_671,1791,Отдел_96
            // Имя_6,Фамилия_6,Должность_753,1671,Отдел_99
            // Имя_7,Фамилия_7,Должность_162,4487,Отдел_28
            // Имя_8,Фамилия_8,Должность_294,2937,Отдел_5
            // Имя_9,Фамилия_9,Должность_125,2318,Отдел_35
            // Имя_10,Фамилия_10,Должность_151,2657,Отдел_50
            // Имя_11,Фамилия_11,Должность_425,2367,Отдел_89

            #endregion

            #region xml
            // <?xml version="1.0"?>
            // <ArrayOfWorker xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            //   <Worker>
            //     <FirstName>Имя_1</FirstName>
            //     <LastName>Фамилия_1</LastName>
            //     <Position>Должность_1</Position>
            //     <Department>Департамент_1</Department>
            //     <Salary>1000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_2</FirstName>
            //     <LastName>Фамилия_2</LastName>
            //     <Position>Должность_2</Position>
            //     <Department>Департамент_2</Department>
            //     <Salary>2000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_3</FirstName>
            //     <LastName>Фамилия_3</LastName>
            //     <Position>Должность_3</Position>
            //     <Department>Департамент_3</Department>
            //     <Salary>3000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_4</FirstName>
            //     <LastName>Фамилия_4</LastName>
            //     <Position>Должность_4</Position>
            //     <Department>Департамент_4</Department>
            //     <Salary>4000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_5</FirstName>
            //     <LastName>Фамилия_5</LastName>
            //     <Position>Должность_5</Position>
            //     <Department>Департамент_5</Department>
            //     <Salary>5000</Salary>
            //   </Worker>
            // </ArrayOfWorker>

            #endregion

            #region json

            // 
            // [
            //   {
            //     "FirstName": "Имя_1",
            //     "LastName": "Фамилия_1",
            //     "Position": "Должность_1",
            //     "Department": "Отдел_1",
            //     "Salary": 1000
            //   },
            //   {
            //     "FirstName": "Имя_2",
            //     "LastName": "Фамилия_2",
            //     "Position": "Должность_2",
            //     "Department": "Отдел_2",
            //     "Salary": 2000
            //   },
            //   {
            //     "FirstName": "Имя_3",
            //     "LastName": "Фамилия_3",
            //     "Position": "Должность_3",
            //     "Department": "Отдел_3",
            //     "Salary": 3000
            //   },
            //   {
            //     "FirstName": "Имя_4",
            //     "LastName": "Фамилия_4",
            //     "Position": "Должность_4",
            //     "Department": "Отдел_4",
            //     "Salary": 4000
            //   },
            //   {
            //     "FirstName": "Имя_5",
            //     "LastName": "Фамилия_5",
            //     "Position": "Должность_5",
            //     "Department": "Отдел_5",
            //     "Salary": 5000
            //   }
            // ]

            #endregion
        }

        private static void OtherCollections()
        {
            #region Dictionary


            Dictionary<string, string> pairs = new Dictionary<string, string>();
            //         ключ ,  значение
            // Add -  Добавляет указанные ключ и значение в словарь
            // Count -  Возвращает число пар "ключ-значение", содержащихся в словаре
            // Clear - Удаляет все ключи и значения из словаря 
            // [] - Возвращает или задает значение, связанное с указанным ключом
            // ContainsKey - Определяет, содержится ли указанный ключ в словаре
            // Remove - Удаляет значение с указанным ключом из словаря
            // Keys - Возвращает коллекцию, содержащую ключи из словаря 
            // Values - Возвращает коллекцию, содержащую значения из словаря 
            // KeyValuePair<string, string>

            //pairs.Add("Учитель", "Teacher");
            //pairs.Add("Проверка", "Check");
            //pairs.Add("Компьютер", "Computer");
            //pairs.Add("Автомобиль", "Car");

            //Console.WriteLine("\npairs");
            //foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");      // Вывод всех пар       

            //Console.WriteLine($"\n\npairs[\"Учитель\"] = {pairs["Учитель"]}"); // Teacher

            //Console.WriteLine("\npairs.Keys");
            //foreach (var e in pairs.Keys) Console.Write($"{e} ");      // Вывод всех ключей

            //Console.WriteLine("\n\npairs.Values");
            //foreach (var e in pairs.Values) Console.Write($"{e} ");      // Вывод всех Значений

            //Console.WriteLine("\n\nУдаление \"Учитель\"");

            //pairs.Remove("Учитель");  // Удаление по ключу

            //Console.WriteLine("\npairs");
            //foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");      // Вывод всех пар      

            //Console.WriteLine("\n");

            //Console.WriteLine($"Элементов в словаре: {pairs.Count}"); // 3
            //pairs.Clear();             // Очистить словарь
            //Console.WriteLine("pairs.Clear(); выполнен");
            //Console.WriteLine($"Элементов в словаре: {pairs.Count}"); // 0

            #endregion

            #region Queue

            //Queue<int> queue = new Queue<int>();

            //// Enqueue - Добавляет объект в конец очереди
            //// Dequeue - Удаляет объект из начала очереди и возвращает его
            ////
            //// Peek - Возвращает объект, находящийся в начале очереди, но не удаляет его
            //// Count - Получает число элементов, содержащихся в очереди
            //// Clear - Удаляет все объекты из очереди
            //// First In First Out = FIFO

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (var e in queue) Console.Write($"{e} "); // 1 2 3 4 5
            //Console.WriteLine("\n");

            //Console.WriteLine($"queue.Dequeue() = {queue.Dequeue()}"); // 1
            //foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            //Console.WriteLine("\n");


            //Console.WriteLine($"queue.Peek() = {queue.Peek()}"); // 2
            //foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            //Console.WriteLine("\n");


            #endregion

            #region Stack


            // Stack<int> stack = new Stack<int>();
            // First In Last Out - FILO

            // Push - Вставляет объект как верхний элемент стека
            // Pop - Удаляет и возвращает объект, находящийся в начале Stack.
            //
            // Peek -  Возвращает объект, находящийся в начале Stack, без его удаления.
            // Count - Получает число элементов, содержащихся в стеке
            // Clear - Удаляет все объекты из стека

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //foreach (var e in stack) Console.Write($"{e} "); // 5 4 3 2 1
            //Console.WriteLine("\n");

            //Console.WriteLine($"stack.Pop() = {stack.Pop()}"); // 5
            //foreach (var e in stack) Console.Write($"{e} "); // 4 3 2 1
            //Console.WriteLine("\n");


            //Console.WriteLine($"stack.Peek() = {stack.Peek()}"); // 4
            //foreach (var e in stack) Console.Write($"{e} "); // 4 3 2 1
            //Console.WriteLine("\n");

            #endregion

            #region HashSet

            //Console.ReadLine();
            //// Add - Добавляет указанный элемент в коллекцию
            //// Remove - Удаляет указанный элемент из коллекции
            //// Contains - Определяет, содержит ли указанный элемент
            //// UnionWith - Изменяет текущий объект так, чтобы он содержал все элементы, 
            ////             имеющиеся в нем или в указанной коллекции либо как в нем, так и в указанной коллекции
            //// IntersectWith - Изменяет текущий объект так, чтобы он содержал только элементы, 
            ////                 которые имеются в этом объекте и в указанной коллекции
            //// ExceptWith - Удаляет все элементы в указанной коллекции из текущего объекта
            //// IsSubsutOf - Определяет, является ли объект подмножеством указанной коллекции
            //// IsSuperSetOf - Определяет, является ли объект супермножеством указанной коллекции
            //// IsProperSubsetOf - Определяет, является ли объект строгим подмножеством указанной коллекции
            //// IsProperSupersetOf - Определяет, является ли объект строгим супермножеством указанной коллекции

            //HashSet<int> set1 = new HashSet<int>(new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 5 });
            //Console.WriteLine("set1: ");

            //foreach (var e in set1) { Console.Write($"{e} "); }

            //Console.WriteLine($"\n\nЭлемент '3' Присутствует в set1: {set1.Contains(3)}");
            //Console.WriteLine($"Элемент '20' Присутствует в set1: {set1.Contains(20)}\n");

            //Console.WriteLine("set2: ");

            //HashSet<int> set2 = new HashSet<int>() { 1, 3, 5, 7, 9, 11, 15 };
            //foreach (var e in set2) { Console.Write($"{e} "); }

            //set1.UnionWith(set2);

            //Console.WriteLine("\n\nset1 после UnionWith: ");
            //foreach (var e in set1) { Console.Write($"{e} "); }

            //set1.ExceptWith(new int[] { 3, 5, 15 });

            //Console.WriteLine("\n\nset1 после ExceptWith(new int[] { 3, 5, 15 }): ");
            //foreach (var e in set1) { Console.Write($"{e} "); }

            //// A: 1 2 3 4 5
            //// B: 1 3 5 7 9 
            //// A ꓴ B = 1 2 3 4 5 7 9
            //// A ꓵ B = 1 3 5
            //// A \ B = 2 4 
            //// B \ A = 7 9
            //// A ∆ B = 2 4 7 9

            #endregion

            #region Other

            // System.Collections.Generic.SortedSet
            // System.Collections.Generic.SortedList
            // System.Collections.Generic.SortedDictionary

            #endregion
        }

        private static void List()
        {
            #region List<T>

            // Add - Добавляет объект в конец
            // AddRange -  Добавляет элементы указанной коллекции в конец списка
            // Remove - Удаляет первое вхождение указанного объекта из коллекции 
            // RemoveAt - Удаляет элемент списка с указанным индексом
            // Contains - Определяет, входит ли элемент в коллекцию
            // IndexOf - Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс
            //           первого вхождения, найденного в пределах всего списка
            // LastIndexOf - Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс
            //               последнего вхождения, найденного в пределах всего списка 
            // [] - Возвращает или задает элемент по указанному индексу
            // Insert - Вставляет элемент в коллекцию по указанному индексу
            // Count - Получает число элементов, содержащихся в коллекции
            // Clear - Удаляет все элементы из коллекции 
            //Сортировка списка
            // Sort или Sort(функция_сравнения)
            // Reverse

            List<int> list = new List<int>
            {
                //  List<int> list = new List<int>(){ 1, 2, 3, 4, 5 };
                145,
                2
            };
            list[1] = 11;

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }

            list.Sort();
            Console.WriteLine("\n");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }


            // SortedList<> - аналог List<>, за исключением того, что отсортирован по умолчаию


            #endregion
        }

        private static void Computers()
        {
            #region Computer1

            //Computer1 computer1 = new Computer1("Computer 1");


            //computer1.ActivationBIOS();
            //computer1.ActivationOS();
            //computer1.Greeting();

            //computer1.Calculation();

            //computer1.Parting();
            //computer1.DeactivationOS();
            //computer1.DeactivationBIOS();

            //Console.ReadKey();
            //Console.WriteLine();

            #endregion

            #region Computer2


            //Computer2 computer2 = new Computer2("Computer 2");

            //computer2.PowerOff();
            //computer2.PowerOff();
            //computer2.PowerOff();

            //computer2.PowerOn();

            //Console.ReadKey();



            #endregion

            #region Computer3

            Computer3 computer3 = new Computer3("Computer 3");

            for (int i = 0; i < 3; i++)
            {
                computer3.Power();
                Console.WriteLine(computer3.Indicator);

                Console.ReadKey();
            }


            Console.ReadKey();


            #endregion
        }

        private static void StructWorker()
        {
            #region Конструкторы

            //    /// <summary>
            //    /// Создание сотрудника
            //    /// </summary>
            //    /// <param name="FirstName">Имя</param>
            //    /// <param name="LastName">Фамилия</param>
            //    /// <param name="Position">Должность</param>
            //    /// <param name="Department">Отдел</param>
            //    /// <param name="Salary">Оплата труда</param>
            //    public Worker(string FirstName, string LastName, string Position, uint Salary, string Department)
            //    {
            //        this.firstName = FirstName;
            //        this.lastName = LastName;
            //        this.position = Position;
            //        this.department = Department;
            //        this.salary = Salary;
            //    }

            #endregion

            #region Методы

            //    public string Print()
            //    {
            //        return $"{this.firstName,15} {this.lastName,15} {this.department,15} {this.position,15} {this.salary,10}";
            //    }

            #endregion

            #region Свойства

            //    /// <summary>
            //    /// Имя
            //    /// </summary>
            //    public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

            //    /// <summary>
            //    /// Фамилия
            //    /// </summary>
            //    public string LastName { get { return this.lastName; } set { this.lastName = value; } }

            //    /// <summary>
            //    /// Должность
            //    /// </summary>
            //    public string Position { get { return this.position; } set { this.position = value; } }

            //    /// <summary>
            //    /// Отдел
            //    /// </summary>
            //    public string Department { get { return this.department; } set { this.department = value; } }

            //    /// <summary>
            //    /// Оплата труда
            //    /// </summary>
            //    public uint Salary { get { return this.salary; } set { this.salary = value; } }

            //    /// <summary>
            //    /// Почасовая оплата
            //    /// </summary>
            //    public double HourRate
            //    {
            //        get
            //        {
            //            byte workingDays = 25; // Рабочих дней в месяце
            //            byte workingHours = 8; // Рабочих часов в день
            //            return ((double)Salary) / workingDays / workingHours;
            //        }
            //    }

            #endregion

            #region Поля

            //    /// <summary>
            //    /// Поле "Имя"
            //    /// </summary>
            //    private string firstName;

            //    /// <summary>
            //    /// Поле "Фамилия"
            //    /// </summary>
            //    private string lastName;

            //    /// <summary>
            //    /// Поле "Должность"
            //    /// </summary>
            //    private string position;

            //    /// <summary>
            //    /// Поле "Отдел"
            //    /// </summary>
            //    private string department;

            //    /// <summary>
            //    /// Поле "Оплата труда"
            //    /// </summary>
            //    private uint salary;

            #endregion
        }

        private static void AccessModifiers()
        {
            //Cat1 cat = new Cat1();

            //cat.Nickname = "Кличка 1";

            #region Модификаторы доступа

            //public – публичный член класс, он доступен из любого места в коде, 
            //         а также из других программ и сборок

            //private – закрытый член класса, он полностью противоположен public.
            //          Закрытый член класса доступен только из кода в том же классе

            //protected – такой член класса доступен из любого места в текущем классе или 
            //            в производных классах.При этом производные классы могут располагаться в других сборках

            //internal – члены класса доступны из любого места кода в той же сборке, 
            //           однако он недоступен для других программ и сборок

            //protected internal – совмещает функционал двух модификаторов.
            //                     Члены класса с таким модификатором доступны из текущей сборки и 
            //                     из производных классов

            //private protected – такой член класса доступен из любого места в текущем классе или 
            //                    в производных классах, которые определены в той же сборке

            #endregion

            //Workers w = new Workers("Программист", 1111, "Иван", "Иванов", new DateTime(1980, 1, 2));
            //Console.WriteLine(w.Print());

            //w = new Workers("Иван IV");
            //Console.WriteLine(w.Print());

            //Repository1 db1 = new Repository1(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5")
            //    );

            //Console.WriteLine(db1.Workers[0].Print());

            #region db2
            //Repository2 db2 = new Repository2(
            //     new Worker("Должность_1", 10000, "Имя_1"),
            //     new Worker("Должность_2", 10000, "Имя_2"),
            //     new Worker("Должность_3", 10000, "Имя_3"),
            //     new Worker("Должность_4", 10000, "Имя_4"),
            //     new Worker("Должность_5", 10000, "Имя_5")
            //     );


            //Console.WriteLine(db2[0].Print());

            //db2[0] = new Worker("Должность_777", 10000, "Имя_777");

            //Console.WriteLine(db2[0].Print());
            //Console.ReadKey();
            #endregion

            #region db3

            //Repository3 db3 = new Repository3(
            //     new Worker("Должность_1", 10000, "Имя_444"),
            //     new Worker("Должность_2", 10000, "Имя_2"),
            //     new Worker("Должность_3", 10000, "Имя_3"),
            //     new Worker("Должность_4", 10000, "Имя_4"),
            //     new Worker("Должность_5", 10000, "Имя_5")
            //     );


            //Console.WriteLine(db3[0]);


            //Console.ReadKey();
            #endregion

            //Repository0 db4 = new Repository0(
            //     new Workers("Должность_1", 10000, "Имя_444"),
            //     new Workers("Должность_2", 10000, "Имя_2"),
            //     new Workers("Должность_3", 10000, "Имя_3"),
            //     new Workers("Должность_4", 10000, "Имя_4"),
            //     new Workers("Должность_5", 10000, "Имя_5")
            //     );


            //Console.WriteLine(db4[0]);

            //Console.WriteLine(db4["*"]);
        }

        private static void Structures()
        {
            // Структуры и введение в ООП


            #region Задание 1.


            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            int[] income = new int[12];         // массив хранящий доходы
            int[] consumption = new int[12];    // массив хранящий расходы
            int[] arrived = new int[12];        // массив хранящий прибыль

            #endregion

            #region MonthlyReport

            MonthlyReport january = new MonthlyReport
            {
                Month = "Январь",
                Income = 10_000,
                consumption = 3_000
            };
            january.arrived = january.Income - january.consumption;


            // Январь: Доход: 10000 Расход: 3000 Прибыль: 7000
            Console.WriteLine("{0}: Доход: {1} Расход: {2} Прибыль: {3}",
                                january.Month,
                                january.Income,
                                january.consumption,
                                january.arrived);
            #endregion

            #region Worker

            //Workers worker = new Workers()
            //{
            //    Position = "Инженер",
            //    FirstName = "Роберт",
            //    LastName = "Иванов",
            //    Salary = 10_000,
            //    DateOfBirth = new DateTime(1990, 09, 28)
            //};

            #endregion

            #region Замечание

            // В Visual Studio 2017 нет шаблона структуры, 
            // поэтому нужно добавить класс, а затем сменить тип вручную.

            #endregion
        }

        private static void Files()
        {
            #region File

            //// using System.IO;
            //// Предоставляет статические методы для создания, копирования, удаления, перемещения и открытия 

            //string text = File.ReadAllText(@"e:\data.txt"); // Открывает текстовый файл, считывает все строки файла и затем закрывает файл.
            //Console.WriteLine(text);

            //string[] lines = File.ReadAllLines(@"e:\data.txt"); // Открывает текстовый файл, считывает все строки файла и затем закрывает файл.

            //foreach (var line in lines) Console.WriteLine($">>{line}<<");

            //lines = new string[] { "один", "два", "три" };
            //File.WriteAllLines(@"e:\data2.txt", lines); // Создает новый файл, записывает в него указанный массив строк и затем закрывает файл

            //text = "Пример текста";
            //File.WriteAllText(@"e:\data3.txt", text);   // Создает новый файл, записывает в него указанную строку и затем закрывает файл.
            //                                            // Если целевой файл уже существует, он будет переопределен.


            ////File.AppendAllLines
            ////File.AppendAllText

            //File.Copy(@"e:\data3.txt", @"e:\newdata3.txt"); // Копирует существующий файл в новый файл. Перезапись файла с тем же именем не
            //                                                // разрешена.

            //File.Exists(@"e:\newdata3.txt"); // Определяет, существует ли заданный файл.

            //File.Delete(@"e:\newdata3.txt"); // Удаляет указанный файл.

            //File.Exists(@"e:\newdata3.txt"); // Определяет, существует ли заданный файл.

            //File.Move(@"e:\data3.txt", @"d:\newdata3.txt"); // Перемещает заданный файл в новое местоположение и разрешает переименование файла.


            #endregion
            #region FileInfo

            ////using System.IO;
            //// Предоставляет свойства и методы экземпляра для создания, копирования, удаления,
            //// перемещения и открытия файлов, а также позволяет создавать объекты System.IO.FileStream.
            //// Этот класс не наследуется. Просмотреть исходный код .NET Framework для этого
            //// типа Reference Source.

            //FileInfo fileInfo = new FileInfo(@"E:\data.txt");

            //Console.WriteLine(fileInfo.Attributes);     // Archive
            //Console.WriteLine(fileInfo.Exists);         // True
            //Console.WriteLine(fileInfo.Extension);      // .txt
            //Console.WriteLine(fileInfo.IsReadOnly);     // False
            //Console.WriteLine(fileInfo.LastAccessTime); // 22.08.2025 18:52:14
            //Console.WriteLine(fileInfo.LastWriteTime);  // 22.08.2025 18:52:14

            //Console.WriteLine(fileInfo.FullName);       // E:\data.txt
            //Console.WriteLine(fileInfo.Name);           // data.txt
            //Console.WriteLine(fileInfo.DirectoryName);  // E:\

            #endregion
            #region Directory, DirectoryInfo

            // using System.IO;
            // Предоставляет статические методы для создания, перемещения и перечисления в каталогах и вложенных каталогах. 

            //Directory.CreateDirectory
            //Directory.Delete
            //Directory.Exists
            //Directory.Move


            DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\");

            //directoryInfo.Attributes
            //directoryInfo.Create
            //directoryInfo.Delete
            //directoryInfo.Exists
            //directoryInfo.FullName
            //directoryInfo.Name
            //directoryInfo.Root
            //directoryInfo.GetDirectories
            //directoryInfo.GetFiles

            GetDir(@"C:\SAVE\SYS");
            //GetDir(@"C:\Program Files\Windows Defender");



            #endregion
            #region Streams
            //var dirs = new DirectoryInfo(@"c:\").GetDirectories();  // dirs хранит все каталоги диска C:\

            //StreamWriter streamWriter = new StreamWriter("cDirs.txt");  // Создание "потока" для работы с файлом cDirs.txt

            //foreach (DirectoryInfo dir in dirs)
            //{
            //    streamWriter.WriteLine(dir.FullName);   // Записать текущее имя каталога в файл
            //    Console.WriteLine($">> {dir.FullName}");
            //}

            //Console.ReadKey();
            //streamWriter.Flush();
            //streamWriter.Close();                   // Закрываем "поток"

            //// Замечание 1. После работы с поток обязательно нужно закрыть при помощи void Close();
            //// или хотя бы записать в файл текущие данные, находящиеся в буфере при помощи void Flush();
            //// streamWriter.Flush();

            //// Замечание 2. StreamWriter разработан для вывода символов в определенной кодировке, 
            //// тогда как классы, производные от Stream предназначены для ввода и вывода байтов.

            //// Замечание 3. Для более удобной работы с потоками (в общем случае и не только) в C# есть 
            //// оператор using предоставляющий удобный синтаксис, обеспечивающий правильное использование объектов IDisposable
            ////
            ////using (StreamWriter sw = new StreamWriter("cDirs.txt"))  // Создание "потока" для работы с файлом cDirs.txt
            ////{
            ////    foreach (DirectoryInfo dir in dirs)
            ////    {
            ////        sw.WriteLine(dir.Name);   // Записать текущее имя каталога в файл
            ////    }
            ////}


            //// Поток для чтения

            //using (StreamReader sr = new StreamReader("cDirs.txt"))  // Создание "потока" для работы с файлом cDirs.txt
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());   // Записать текущее имя каталога в файл
            //    }
            //}


            #endregion
            #region Catalog
            //// Требуется создать файл - аналог записной книжки.
            //// В файле хранится 
            //// Имя автора записи
            //// Дата
            //// Описание заметки

            ////using (StreamWriter sw = new StreamWriter("db.csv", true, Encoding.Unicode))
            ////{
            ////    char key = 'д';

            ////    do
            ////    {
            ////        string note = string.Empty;
            ////        Console.Write("\nВведите имя автора записи: ");
            ////        note += $"{Console.ReadLine()}\t";

            ////        string now = DateTime.Now.ToShortTimeString();
            ////        Console.WriteLine($"Время заметки {now}");
            ////        note += $"{now}\t";

            ////        Console.Write("Введите описание заметки: ");
            ////        note += $"{Console.ReadLine()}\t";
            ////        sw.WriteLine(note);
            ////        Console.Write("Продожить н/д"); key = Console.ReadKey(true).KeyChar;
            ////    } while (char.ToLower(key) == 'д');
            ////}

            //#region Чтение



            //using (StreamReader sr = new StreamReader("data.csv", Encoding.Unicode))
            //{
            //    string line;
            //    Console.WriteLine($"{"Автор",15}{" Время",8} {"Описание"}");

            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        string[] data = line.Split('\t');
            //        Console.WriteLine($"{data[0],15}{data[1],8} {data[2]}");
            //    }
            //}

            //#endregion

            #endregion
            #region Add
            ////using (StreamReader sr = new StreamReader("db.txt", Encoding.Unicode))
            ////{
            ////    while (!sr.EndOfStream)
            ////    {
            ////        var c = sr.Read();
            ////        //Console.WriteLine($"{c} - {(char)c}");
            ////    }
            ////}

            ////Console.WriteLine();

            ////using (StreamReader sr = new StreamReader("db.txt", Encoding.Unicode))
            ////{
            ////    Console.WriteLine(sr.ReadToEnd());
            ////}



            //#region BinaryWriter, BinaryReader

            ////Console.WriteLine($"Нажмите Enter для продолжения\n");

            ////Console.ReadKey(); Console.Clear();

            ////string[] names = { "Юлия", "Ирина", "Светлана", "Екатерина", "Алиса" };

            ////string path = @"BinaryNames.dat";


            ////using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            ////{
            ////    // записываем в файл значение каждого поля структуры
            ////    foreach (var name in names)
            ////    {
            ////        writer.Write(name);
            ////    }
            ////}
            ////Console.WriteLine($"Файл {path} успешно создать. Нажмите Enter для продолжения\n");
            ////Console.ReadLine();

            ////using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            ////{
            ////    // пока не достигнут конец файла
            ////    // считываем каждое значение из файла
            ////    while (reader.PeekChar() > -1)
            ////    {
            ////        string name = reader.ReadString();
            ////        Console.WriteLine(name);
            ////    }
            ////}

            //#endregion

            //#region FileStream

            ////Console.WriteLine($"Нажмите Enter для продолжения\n");

            ////Console.ReadKey(); Console.Clear();
            ////Console.Write("Введите строку: ");
            ////string text = Console.ReadLine();

            ////// запись в файл
            ////using (FileStream fstream = new FileStream(@"note.txt", FileMode.Create))
            ////{
            ////    byte[] array = System.Text.Encoding.Default.GetBytes(text); // преобразуем строку в байты
            ////    fstream.Write(array, 0, array.Length);                      // запись массива байтов в файл
            ////}

            ////// чтение из файла
            ////using (FileStream fstream = File.OpenRead(@"note.txt"))
            ////{

            ////    byte[] array = new byte[fstream.Length];    // преобразуем строку в байты

            ////    fstream.Read(array, 0, array.Length);       // считываем данные

            ////    text = System.Text.Encoding.Default.GetString(array);    // декодируем байты в строку
            ////    Console.WriteLine($"Текст : {text}");
            ////}

            ////Console.ReadLine();

            //#endregion

            //#region GZipStream

            //string source = "voina-i-mir.txt";
            //string compressed = "voina-i-mir.zip";
            //using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
            //{
            //    using (FileStream ts = File.Create(compressed))   // поток для записи сжатого файла
            //    {
            //        // поток архивации
            //        using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
            //        {
            //            ss.CopyTo(cs); // копируем байты из одного потока в другой
            //            Console.WriteLine("Сжатие файла {0} завершено. Было: {1}  стало: {2}.",
            //                              source,
            //                              ss.Length,
            //                              ts.Length);
            //        }
            //    }
            //}

            //Console.WriteLine($"Нажмите Enter для продолжения\n");

            //Console.ReadKey();


            //using (FileStream ss = new FileStream(compressed, FileMode.OpenOrCreate))  // поток для чтения из сжатого файла
            //{

            //    using (FileStream ts = File.Create($"{source}_.txt")) // поток для записи восстановленного файла
            //    {
            //        // поток разархивации
            //        using (GZipStream ds = new GZipStream(ss, CompressionMode.Decompress))
            //        {
            //            ds.CopyTo(ts);
            //            Console.WriteLine($"{source} восстановлен");

            //            Console.WriteLine("Востановление файла {0} завершено. Было: {1}  стало: {2}.",
            //                              source,
            //                              ss.Length,
            //                              ts.Length);
            //        }
            //    }
            //}
            //#endregion
            #endregion
            #region StringBuilder
            #region Проблема string

            //string s1 = "Првет";
            //string s2 = s1.Insert(2, "и");
            //Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            //Console.WriteLine("Объём выделенной памяти");
            //Console.WriteLine($"s1 = {s1.Length * 2} байт, s2 = {s2.Length * 2} байт");
            //Console.WriteLine(s1[1]);
            //s1[1] = '!';

            #endregion

            #region StringBuilder

            // using System.Text;
            // StringBuilder // Предоставляет изменяемую строку символов.

            StringBuilder sb1 = new StringBuilder("Првет");
            Console.WriteLine($"\nДлина sb1 = {sb1.Length}");
            Console.WriteLine($"Вместимость sb1 = {sb1.Capacity}");

            StringBuilder sb2 = new StringBuilder(100);
            Console.WriteLine($"\nДлина sb2 = {sb2.Length}");
            Console.WriteLine($"Вместимость sb2 = {sb2.Capacity}");

            //public StringBuilder();
            //  public StringBuilder(int capacity);
            //  public StringBuilder(string value);
            //public StringBuilder(string value, int capacity);
            //public StringBuilder(int capacity, int maxCapacity);
            //public StringBuilder(string value, int startIndex, int length, int capacity);

            sb2.Append("Один "); // Добавляет копию указанной строки к данному экземпляру.
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");

            sb2.AppendFormat("{0} {1} ", "Два", "Три"); // Добавляет к данному экземпляру строку, возвращаемую в результате обработки строки
                                                        // составного формата

            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");

            sb2.AppendLine(); // Добавляет знак завершения строки по умолчанию в конец
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");

            sb2.AppendLine("Четыре"); // Добавляет копию указанной строки и знак завершения строки по умолчанию в конец
                                      // текущего объекта 
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");


            sb2.Remove(14, 9); // Удаляет указанный диапазон символов из данного экземпляра.
            Console.WriteLine(sb2);

            sb2.Replace('Д', 'д'); // Замещает все вхождения указанного символа в данном экземпляре на другой указанный знак.
            sb2.Replace('Т', 'т'); // Замещает все вхождения указанного символа в данном экземпляре на другой указанный знак.
            sb2.Replace('О', 'о'); // Замещает все вхождения указанного символа в данном экземпляре на другой указанный знак.
            //public StringBuilder Replace(string oldValue, string newValue);
            //public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count);
            //public StringBuilder Replace(char oldChar, char newChar);
            //public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count);

            sb2[4] = '!';

            Console.WriteLine(sb2);


            #endregion

            #region Рекомендации по использованию 

            //String StringBuilder
            // Небольшом количество операций и изменений элементов строки
            // Когда требуется выполнять поиск, например IndexOf, т е StringBuilder не имеет подобных методов.

            // 
            // Если неизвестно количество операций, которые будут произвоится над строками в процессе работы программы


            #endregion

            #endregion
            #region StringReaderWriter
            // using System.IO;
            //  Реализует объект System.IO.TextWriter для записи сведений в строку. 
            // Сведения хранятся в базовом System.Text.StringBuilder.

            StringBuilder sb = new StringBuilder(100);
            string s = "Ролик 5. Расширенная работа со строками: StringReader и StringWriter; изменяемые строки: StringBuilder";
            sb.Append(s);
            Console.WriteLine(sb);

            using (StringWriter sw = new StringWriter(sb))
            {
                sw.Write("!!!");
            };
            Console.WriteLine(sb);

            // Реализует System.IO.TextReader считывает данные из строки.
            using (StringReader sr = new StringReader(s))
            {
                char[] buf = new char[5];
                sr.ReadBlock(buf, 0, buf.Length);
            };
            #endregion
        }

        private static void GetDir(string path, string trim = "")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);  // Получаем информацию о текущем каталоге

            foreach (DirectoryInfo item in directoryInfo.GetDirectories())    // Перебираем все подкаталоги текущего каталога
            {
                Console.WriteLine($"{trim}{item.Name}");            // Выводим информацию о нём
                GetDir(item.FullName, trim + "    ");               // Запускаем "просмотре" вложенного каталога
            }

            foreach (FileInfo item in directoryInfo.GetFiles())          // Перебираем все файлы текущего каталога
            {
                Console.WriteLine($"{trim}{item.Name}");            // Выводим информацию о них
            }
        }

        private static void Chars()
        {
            // Char.IsDigit         // Показывает, относится ли указанный символ Юникода к категории десятичных цифр.
            // Char.IsLetter        // Показывает, относится ли указанный символ Юникода к категории букв Юникода.
            // Char.IsLower         // Показывает, относится ли указанный символ Юникода к категории букв нижнего регистра.
            // Char.IsUpper         // Показывает, относится ли указанный символ Юникода к категории букв верхнего регистра.

            char[] symbols = "symbols".ToCharArray();
            foreach (char item in symbols)
            {
                Console.Write($"{item} ");
            }

            string s = new string(symbols);
        }

        private static void Strings()
        {
            string str = "Visual alusiV";
            Console.WriteLine($"str = {str} ");
            // Возвращает индекс с отсчетом от нуля первого вхождения указанного символа Юникода в данной строке.
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");
            Console.WriteLine($"str.IndexOf('%') = {str.IndexOf('%')}");

            // Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанного
            // символа Юникода в пределах данного экземпляра.
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");

            // Отсчитываемое от нуля значение индекса параметра value, если этот знак найден;
            // в противном случае — значение -1.
            Console.WriteLine($"str.LastIndexOf('z') = {str.LastIndexOf('z')}");

            // Возвращает новую строку, в которой указанная строка вставляется в указанной позиции
            // индекса в данном экземпляре.
            string s = str.Insert(str.IndexOf(' ') + 1, "C# ");
            Console.WriteLine($"s = {s}");

            // Возвращает новую строку, в которой были удалены все символы, начиная с указанной позиции
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");
            // Возвращает новую строку, в которой были удалены все символы, начиная с указанной позиции count элементов
            Console.WriteLine($"str.Remove(6, 3) = {str.Remove(6, 3)}");

            // Возвращает новую строку, в которой все вхождения заданного знака Юникода в текущем
            // экземпляре заменены другим заданным знаком Юникода.
            Console.WriteLine($"str.Replace('a','z') = {str.Replace('a', 'z')}");


            // Извлекает подстроку из данного экземпляра. Подстрока начинается в указанном положении
            // символов и продолжается до конца строки.
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");


            Console.WriteLine($"str.ToUpper() = {str.ToUpper()}");
            Console.WriteLine($"str.ToLower() = {str.ToLower()}");


            //str.Trim();       // Удаляет все начальные и конечные символы-разделители из текущего объекта System.String.
            //str.TrimEnd();    // Удаляет все конечные символы-разделители из текущего объекта System.String.
            //str.TrimStart();  // Удаляет все начальные символы-разделители из текущего объекта System.String.

            // Разбивает строку на подстроки в зависимости от символов в массиве.
            string[] array = "1 2 3 4,5 6;7 8 9;10".Split(' ', ',', ';');


            string test = null;

            Console.WriteLine($"String.IsNullOrEmpty(test) = {string.IsNullOrEmpty(test)}");    // True

            test = string.Empty;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {string.IsNullOrEmpty(test)}");    // True

            test = "Skill";
            Console.WriteLine($"String.IsNullOrEmpty(test) = {string.IsNullOrEmpty(test)}");    // False

        }

        private static void MathDateConvert()
        {

            #region Convert
            // Преобразует значение одного базового типа данных к другому базовому типу данных.

            //bool
            //byte
            //char
            //DateTime
            //decimal
            //double
            //short
            //int
            //long
            //sbyte
            //float
            //string
            //ushort
            //uint
            //ulong

            //int i = Convert.ToByte("20");
            //byte j = 0 ;
            //j = (byte)int.Parse("2011");
            //i = Convert.ToByte(12.45);
            //i = Convert.ToByte(56.78f);
            //i = Convert.ToByte(89.09m);

            #endregion

            #region Math

            //// Console.ReadKey();
            //// Предоставляет константы и статические методы для тригонометрических, логарифмических
            //// и иных общих математических функций. 

            //// Вычислить площадь окружности. Радиусом 2;
            ////               
            //// S окр. = πr²

            ////Math.PI // Представляет отношение длины окружности к ее диаметру, определяемое константой
            ////Math.E //Представляет основание натурального логарифма, определяемое константой e.

            //// Math.Abs - Возвращает абсолютное значение числа 

            //// Sin, Cos, Tan, Atan, Tanh и т.д.
            //// Log, Log10
            //// Max, Min
            //// var result = Math.Max(11,22);

            ////Возвращает наименьшее целое число, которое больше или равно заданному десятичному
            //Console.WriteLine(Math.Ceiling(1.2));   // 2
            //Console.WriteLine(Math.Ceiling(-1.2));  // -1

            //// Возвращает значение e, возведенное в указанную степень.
            //Console.WriteLine(Math.Exp(2)); // e²

            //// Возвращает наибольшее целое число, которое меньше или равно указанному десятичному числу.
            //Console.WriteLine(Math.Floor(1.2)); // 1
            //Console.WriteLine(Math.Floor(-1.2)); // -2

            //// Возвращает указанное число, возведенное в указанную степень.
            //Console.WriteLine(Math.Pow(4,3));       // 4³
            //Console.WriteLine(Math.Pow(2020,2));    // 2020²

            //// Округляет десятичное значение до указанного числа дробных разрядов.
            //Console.WriteLine(Math.Round(1.2345)); // 1
            //Console.WriteLine(Math.Round(1.5345)); // 2
            //Console.WriteLine(Math.Round(-1.5345)); // -2
            //Console.WriteLine(Math.Round(-1.56789,3)); // -1,568


            //// Возвращает целое число, указывающее знак 8-разрядного целого числа со знаком.
            //Console.WriteLine(Math.Sign(-20));  // -1
            //Console.WriteLine(Math.Sign(20));   // 1



            //int r = 2;
            //double s = Math.PI * Math.Pow(r, 2);
            //Console.WriteLine(s);

            //Console.ReadKey();
            #endregion

            #region DateTime TimeSpan

            //Console.ReadKey();

            DateTime date = new DateTime(2020, 09, 28, 01, 30, 00);
            Console.WriteLine($"{date}"); // 28.09.2020 1:30:00

            // date.Year         // Возвращает компонент года даты, представленной этим экземпляром.
            // date.Month        // Возвращает компонент месяца даты, представленной этим экземпляром.
            // date.Day          // Возвращает день месяца, представленный этим экземпляром.
            // date.Hour         // Возвращает компонент часа даты, представленной этим экземпляром.
            // date.Minute       // Возвращает компонент минуты даты, представленной этим экземпляром.
            // date.Second       // Возвращает компонент секунды даты, представленной этим экземпляром.
            // date.Millisecond  // Возвращает компонент миллисекунд для даты, представленной в данном экземпляре. 

            Console.WriteLine(date.ToShortTimeString());        // Получение только времени    1:30
            Console.WriteLine(date.ToShortDateString());        // Получение только даты       28.09.2020

            DateTime newDate = date.AddDays(10);
            Console.WriteLine($"{newDate}"); // 08.10.2020 1:30:00

            // Console.WriteLine(DateTime.Now);     // Возвращает System.DateTime, которому присвоены текущие дата и время 
            // данного компьютера, выраженные как местное время.

            TimeSpan span = newDate - date;
            Console.WriteLine(span);                     // 10.00:00:00
            Console.WriteLine(span.TotalMinutes);        // 14400


            Console.Clear();

            date = DateTime.Now;

            double sum = 0;

            for (int k = 0; k <= 1_000_000_000; k++)
            {
                sum += k;
            }

            Console.WriteLine($"sum = {sum}");

            TimeSpan timeSpan = DateTime.Now.Subtract(date);
            Console.WriteLine($"timeSpan.TotalMilliseconds = {timeSpan.TotalMilliseconds}");

            #endregion
        }

        private static void Recursion()
        {
            static int Fib(int N)
            {
                return (N == 1 || N == 2) ? 1 : Fib(N - 1) + Fib(N - 2);
            }

            static int FibLoop(int N)
            {
                int a1 = 1;
                int a2 = 1;
                int t = a2;

                for (int i = 2; i < N; i++)
                {
                    t = a1 + a2;
                    a1 = a2;
                    a2 = t;
                }

                return t;
            }

            // 1  1  2  3  5  8  13  21  34  55
            // fib(1) = 1
            // fib(2) = 1
            // fib(n) = fib(n-1) fib(n-2), n >= 3

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Fib({i,2}) = {Fib(i)}  {FibLoop(i)}");
            }

            static string Numbers(int n)
            {
                return n < 10 ? n.ToString() : $"{n % 10} {Numbers(n / 10)}";
            }

            //Выведите все цифры натурального числа N по одной
            Console.WriteLine(Numbers(1234654));

            static void Find(char[] Set, char[] Word, int N)
            {
                if (N == Word.Length)
                {
                    foreach (char e in Word) { Console.Write(e); }
                    Console.WriteLine();
                    return;
                }

                char[] tWord = Word;

                for (int i = 0; i < Set.Length; i++)
                {
                    tWord[N] = Set[i];
                    Find(Set, tWord, N + 1);
                }
            }

            char[] alphabet = { 'q', 'w', 'e', 'r', 't' };
            char[] currentWord = new char[4];

            Find(alphabet, currentWord, 0);

            static void Print(char[,] Map)
            {
                for (int i = 0; i < Map.GetLength(0); i++)
                {
                    for (int j = 0; j < Map.GetLength(1); j++)
                    {
                        Console.Write(Map[i, j] == '.' ? ' ' : Map[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }

            static void ToColor(char[,] Map, int PosX, int PosY)
            {
                if (Map[PosX, PosY] == '.')
                {
                    Map[PosX, PosY] = '+';              // "Закрашиваем" текущую ячейку
                    ToColor(Map, PosX - 1, PosY);       // Просматриваем ячейку выше текущей
                    ToColor(Map, PosX, PosY + 1);       // Просматриваем ячейку правее текущей
                    ToColor(Map, PosX + 1, PosY);       // Просматриваем ячейку ниже текущей
                    ToColor(Map, PosX, PosY - 1);       // Просматриваем ячейку левее текущей
                }
            }

            char[,] map = new char[,]
             {
                {'.','+','+','.','+','+','.', },
                {'+','.','.','+','.','.','+', },
                {'+','.','.','.','.','.','+', },
                {'.','+','.','.','.','+','.', },
                {'.','.','+','.','+','.','.', },
                {'.','.','.','+','.','.','.', }
            };

            Print(map);
            Console.WriteLine();
            ToColor(map, 1, 1);
            Print(map);

            static int F(int N)
            {
                //Console.WriteLine($" F{N}");
                return (N > 2) ? F(N - 1) + G(N - 2) : N;
            }

            static int G(int N)
            {
                //Console.WriteLine($" G{N}");

                return (N > 2) ? G(N - 1) + F(N - 2) : N + 1;
            }
            Console.ReadKey();
            Console.WriteLine(F(13));

            static void Infinity()
            {
                Console.Write("O_- "); // Шаг рекурсии
                                       //Thread.Sleep(100);         // 
                Infinity();                //
            }

            static void NotInfinity(int Count)
            {
                Console.WriteLine("O_- ");
                Thread.Sleep(100);
                Count--;
                if (Count > 0) // Базовый случай
                {
                    NotInfinity(Count);
                }
            }

            //Infinity();
            NotInfinity(5);
        }

        private static void Params()
        {

            //static int Sum(int V1) { return V1; }
            //static int Sum(int V1, int V2) { return V1 + V2; }
            //static int Sum(int V1, int V2, int V3) { return V1 + V2 + V3; }
            //static int Sum(int V1, int V2, int V3, int V4) { return V1 + V2 + V3 + V4; }
            //static int Sum(int V1, int V2, int V3, int V4, int V5) { return V1 + V2 + V3 + V4 + V5; }
            //static int Sum(int V1, int V2, int V3, int V4, int V5, int V6) { return V1 + V2 + V3 + V4 + V5 + V6; }
            //static int Sum(int[] Args)
            //{
            //    int result = 0;

            //    foreach (var e in Args)
            //    {
            //        result += e;
            //    }

            //    return result;
            //}

            //// Менеджер проекта просит написать метод, которыый будет 
            //// Находить сумму наперед неизвестное количества целых чисел

            //var res = Sum(1);
            //res = Sum(1, 9);
            //res = Sum(1, 9, 9);
            //res = Sum(1, 9, 9, 0);
            //res = Sum(1, 9, 9, 0, 2);
            //res = Sum(1, 9, 9, 0, 2, 8);

            //int[] col = new int[] { 2, 8, 0, 9, 9, 0 };

            //Console.WriteLine(res);

            //res = Sum(col);
            //res = Sum(new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });
            //Console.WriteLine(res);

            //res = Sum(new int[] { 2, 8, 0, 9 });
            //Console.WriteLine(res);

            //res = Sum(new int[] { 2, 8 });
            //Console.WriteLine(res);

            //res = Sum(new int[] { 2 });
            //Console.WriteLine(res);

            static int Sum(params int[] Args)
            {
                int result = 0;

                foreach (int e in Args)
                {
                    result += e;
                }

                return result;
            }

            int res = Sum(1);
            res = Sum(1, 9);
            res = Sum(1, 9, 9);
            res = Sum(1, 9, 9, 0);
            res = Sum(1, 9, 9, 0, 2);
            res = Sum(1, 9, 9, 0, 2, 8);

            int[] col = new int[] { 2, 8, 0, 9, 9, 0 };

            Console.WriteLine(res);

            res = Sum(col);
            res = Sum(new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2, 8, 0, 9 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2, 8 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2 });
            Console.WriteLine(res);

            //static int Sum(int Factor, params int[] Args)
            //{
            //    int result = 0;

            //    foreach (var e in Args)
            //    {
            //        result += e;
            //    }

            //    return result * Factor;
            //}

            //static int Sum(int Factor, string Msg, params int[] Args) { return 0; }
            //static int Sum(double Factor, string Msg, params int[] Args) { return 0; }
            //static int Sum(double Factor, string Msg, params double[] Args) { return 0; }

            //var res = Sum(1);
            //res = Sum(1, 9);
            //res = Sum(1, 9, 9);
            //res = Sum(1, 9, 9, 0);
            //res = Sum(1, 9, 9, 0, 2);
            //res = Sum(1, 9, 9, 0, 2, 8);

            //int[] col = new int[] { 2, 8, 0, 9, 9, 0 };

            //Console.WriteLine(res);

            //res = Sum(13, col);
            //res = Sum(13, new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });
            //Console.WriteLine(res);

            //res = Sum(8, 2, 8, 0, 9);
            //Console.WriteLine(res);

            //res = Sum(5, new int[] { 2, 8 });
            //Console.WriteLine(res);

            //res = Sum(3, new int[] { 2 });
            //Console.WriteLine(res);
        }

        private static void MethodExp()
        {
            ///// <summary>
            ///// Метод откладывающий закрытие консоли на Interval секунд 
            ///// </summary>
            ///// <param name="Interval">Количество секунд до закрытия консоли
            ///// </param>
            //static void Pause(int Interval)
            //{
            //    Thread.Sleep(Interval * 1000);
            //}

            ///// <summary>
            ///// Метод, заполняющий массив Col
            ///// </summary>
            ///// <param name="Col">Массив целых чисел, который нужно заполнить</param>
            //static void Fill(int[] Col)
            //{
            //    Random r = new Random();
            //    for (int i = 0; i < Col.Length; i++)
            //    {
            //        Col[i] = r.Next(100);
            //    }
            //}

            ///// <summary>
            ///// Метод, выводы массива Col в консоль
            ///// </summary>
            ///// <param name="Col">Массив целых чисел, который нужно вывести в консоль</param>
            //static void Print(int[] Col)
            //{
            //    Random r = new Random();
            //    for (int i = 0; i < Col.Length; i++)
            //    {
            //        Console.Write($"{Col[i]} ");
            //    }
            //    Console.WriteLine();
            //}


            ///// <summary>
            ///// Метод, поиска максимального значения в массиве
            ///// </summary>
            ///// <param name="Col">Массив целых чисел, в котором нужно найти максимальный элемент</param>
            ///// <returns>Максимальное значение в массиве</returns>
            //static int Max(int[] Col)
            //{
            //    if (Col.Length < 0) return -1;

            //    int localMax = Col[0];

            //    for (int i = 1; i < Col.Length; i++)
            //    {
            //        if (Col[i] > localMax) localMax = Col[i];
            //    }

            //    return localMax;
            //}

            ///// <summary>
            ///// Метод, поиска минимального значения в массиве
            ///// </summary>
            ///// <param name="Col">Массив целых чисел, в котором нужно найти минимальный элемент</param>
            ///// <returns>Минимальное значение в массиве</returns>
            //static int Min(int[] Col)
            //{
            //    if (Col.Length <= 0) return -1;

            //    int localMin = Col[0];

            //    for (int i = 1; i < Col.Length; i++)
            //    {
            //        if (Col[i] < localMin) localMin = Col[i];
            //    }

            //    return localMin;
            //}

            //Random r = new Random();
            //int N = r.Next(10, 20);


            //int[] arr = new int[N];


            //Fill(arr);
            //Print(arr);
            //Console.WriteLine($"maxArr = {Max(arr)}");
            //Console.WriteLine($"minArr = {Min(arr)}\n");

            //int M = r.Next(10, 20);
            //int[] brr = new int[N];
            //Pause(5);

            //Fill(brr);
            ////Fill(brr, Count);
            ////Fill(brr, Count, BottomRange, UpperRange);
            //Print(brr);
            //Console.WriteLine($"maxBrr = {Max(brr)}");
            //Console.WriteLine($"minBrr = {Min(brr)}\n");

            //#region Важно

            //// Сигнатура метода - это набор типов, которые возвращает метод и
            //// принимает в качестве параметров.

            //#endregion

            /// <summary>
            /// Метод, заполняющий массив Col
            /// </summary>
            /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
            static void Fill(int[] Col)
            {
                Random r = new Random();
                for (int i = 0; i < Col.Length; i++)
                {
                    Col[i] = r.Next(100);
                }
            }

            /// <summary>
            /// Метод, заполняющий первых Count элементов массив Col
            /// </summary>
            /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
            /// <param name="Count">Количество элементов, которые нужно изменить</param>
            static void Fill2(int[] Col, int Count)
            {
                Random r = new Random();
                for (int i = 0; i < Count; i++)
                {
                    Col[i] = r.Next(100);
                }
            }

            /// <summary>
            /// Метод, заполняющий первых Count элементов массив Col числами из диапазона BottomRange UpperRange.
            /// BottomRange должен быть строго меньше UpperRange
            /// </summary>
            /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
            /// <param name="Count">Количество элементов, которые нужно изменить</param>
            /// <param name="BottomRange">Нижняя граница диапазона</param>
            /// <param name="UpperRange">Верхняя граница диапазона</param>
            static void Fill4(int[] Col, int Count, int BottomRange, int UpperRange)
            {
                Random r = new Random();
                for (int i = 0; i < Count; i++)
                {
                    Col[i] = r.Next(BottomRange, UpperRange);
                }
            }


            /// <summary>
            /// Метод, заполняющий элементы массив Col числами из диапазона BottomRange UpperRange.
            /// BottomRange должен быть строго меньше UpperRange
            /// </summary>
            /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
            /// <param name="BottomRange">Нижняя граница диапазона</param>
            /// <param name="UpperRange">Верхняя граница диапазона</param>
            static void Fill3(int[] Col, int BottomRange, int UpperRange)
            {
                Random r = new Random();
                for (int i = 0; i < Col.Length; i++)
                {
                    Col[i] = r.Next(BottomRange, UpperRange);
                }
            }

            /// <summary>
            /// Метод, выводы массива Col в консоль
            /// </summary>
            /// <param name="Col">Массив целых чисел, который нужно вывести в консоль</param>
            static void Print(int[] Col)
            {


                Random r = new Random();
                for (int i = 0; i < Col.Length; i++)
                {
                    Console.Write($"{Col[i],3}");
                }
                Console.WriteLine();
            }


            #region Перегрузка метода

            // Перегрузка метода - это набор методов, имеющих одинаковое имя,
            // отличающиеся количеством формальных параметров или их типом

            #endregion

            int[] arr = new int[20];

            Fill2(arr, 10);  // static void Fill(int[] Col, int Count)
            Print(arr);
            Console.ReadKey();

            Fill(arr); //static void Fill(int[] Col)
            Print(arr);
            Console.ReadKey();


            Fill3(arr, -10, 0); //  static void Fill(int[] Col, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();


            Fill4(arr, 10, 1, 30); //  static void Fill(int[] Col, int Count, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();
        }

        private static void Method()
        {
            // 1. Разделение логики: использование методов

            // Есть два массива содержащие не менее 10 и не более 20 элементов элементов. 
            // Организовать заполнение и вывод на экран каждого из них
            // Найти максимальный и минимальный элементы в каждом массиве

            #region Пример 1

            Random r = new Random();

            // Первый массив
            int N = r.Next(10, 20);

            int[] arr = new int[N];
            int[] brr = new int[N];


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(20);
                brr[i] = r.Next(20);
            }

            // Поиск
            int maxArr = arr[0];
            int minArr = arr[0];
            int maxBrr = brr[0];
            int minBrr = brr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxArr)
                {
                    maxArr = arr[i];
                }

                if (arr[i] < minArr)
                {
                    minArr = arr[i];
                }

                if (brr[i] > maxBrr)
                {
                    maxBrr = brr[i];
                }

                if (brr[i] < minBrr)
                {
                    minBrr = brr[i];
                }
            }

            Console.WriteLine("arr");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],3}");
            }

            Console.WriteLine($"\nmaxArr = {maxArr}");
            Console.WriteLine($"minArr = {minArr}");

            Console.WriteLine("\nbrr");

            for (int i = 0; i < brr.Length; i++)
            {
                Console.Write($"{brr[i],3}");
            }
            Console.WriteLine();
            Console.WriteLine($"maxBrr = {maxBrr}");
            Console.WriteLine($"minBrr = {minBrr}");

            #endregion

            // Есть два массива содержащие не менее 10 и не более 20 элементов элементов. 
            // Организовать заполнение и вывод на экран каждого из них
            // Найти максимальный и минимальный элементы в каждом массиве

            #region Пример 1

            _ = new Random();

            // Первый массив
            _ = r.Next(10, 30);
            _ = new int[N];
            Console.WriteLine("arr");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(20);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            // Максимум
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"max = {max}");


            // Минимум
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"min = {min}");


            // Второй массив
            Console.WriteLine("\nbrr");

            int M = r.Next(10, 30);
            _ = new int[M];
            for (int i = 0; i < brr.Length; i++)
            {
                brr[i] = r.Next(20);
                Console.Write($"{brr[i]} ");
            }
            Console.WriteLine();

            // Максимум
            max = brr[0];

            for (int i = 0; i < brr.Length; i++)
            {
                if (brr[i] > max)
                {
                    max = brr[i];
                }
            }
            Console.WriteLine($"max = {max}");

            // Минимум
            min = brr[0];

            for (int i = 0; i < brr.Length; i++)
            {
                if (brr[i] < min)
                {
                    min = brr[i];
                }
            }
            Console.WriteLine($"min = {min}");


            #region Примечание

            Console.WriteLine($"arrMax = {arr.Max()}");
            Console.WriteLine($"arrMix = {arr.Min()}");
            Console.WriteLine($"brrMax = {brr.Max()}");
            Console.WriteLine($"brrMix = {brr.Min()}");

            #endregion

            #endregion

            /// <summary>
            /// Метод, позволяющий сделать задержку закрытия консоли
            /// </summary>
            static void Delay()
            {
                Console.ReadKey();
            }

            /// <summary>
            /// Метод, позволяющий вывести сообщение "Hello World" в консоль
            /// </summary>
            static void HelloWorld()
            {
                Console.WriteLine("Hello World");
            }

            /// <summary>
            /// Метод, позволяющий вывести сообщение в консоль
            /// </summary>
            /// <param name="Text">Текст сообщения</param>
            static void Print(string Text)
            {
                Console.WriteLine(Text);
            }

            #region Теория

            // Метод может быть создан внутри класса, 
            // Общая структура 
            //
            // 
            // УровниДоступа МодификаторыДоступа ВозвращаемыйТип ИмяМетода(ПараметрыМетода)
            // {
            //    Тело метода
            //    return
            // }
            // 
            // УровниДоступа: public, protected, internal, private. 
            //   С помощью четырех модификаторов доступа можно объявить шесть уровней доступности.
            //
            // МодификаторыДоступа: static, abstract, async, extern, override, virtual
            //
            // ВозвращаемыйТип: int, double, string и т.д.
            //                  void если ничего возвращать не нужно
            // 
            // ИмяМетода: Строчные и прописные буквы латинского алфавита, цифры, _
            //            цифра не может быть на первом месте
            // 
            // ПараметрыМетода: аргументы, над которыми, как правило производятся какие-то действия
            //                  Формальные парамметры - параметры указанные при описании метода
            //                  Фактические параметры - параметры указанные при вызове метода
            // 
            // Соглашение об именах для методов - описательное имя для каждого слова начинается с прописной буквы.

            // Вызов метода:
            // Написать имя метода и указать фактические параметры, если они есть

            // Пример 1. Вызов метода void HelloWorld()
            HelloWorld();

            // Пример 2. Вызов метода void Print(string Text)
            Print("Shagitov");

            // Пример 3. Вызов метода void Delay()
            Delay();

            #endregion

            // 2. Параметры методов, модификаторы параметров, возвращение значений
            //
            //
            // УровниДоступа МодификаторыДоступа ВозвращаемыйТип ИмяМетода(ПараметрыМетода)
            // {
            //    Тело метода
            // }
            //
            // УровниДоступа: [ private, public, protected, internal ]. 
            //   С помощью четырех модификаторов доступа можно объявить шесть уровней доступности.
            //
            // МодификаторыДоступа: static [ , abstract, async, extern, override, virtual ]
            //
            // ВозвращаемыйТип: int, double, string и т.д.
            //                  void если ничего возвращать не нужно
            // 
            // ИмяМетода: Строчные и прописные буквы латинского алфавита, цифры, _
            //            цифра не может быть на первом месте
            // 
            // ПараметрыМетода: аргументы, над которыми, как правило производятся какие-то действия
            //                  Формальные парамметры - параметры указанные при описании метода
            //                  Фактические параметры - параметры указанные при вызове метода


            // static ВозвращаемыйТип ИмяМетода(ПараметрыМетода)
            // {
            //    Тело метода
            // }

            ////
            //// 01. Первая группа
            ////
            //// ┌───────────────────────────────────────────┐
            //// │                                           │
            //// │                Что-то делает              │
            //// │                                           │
            //// └───────────────────────────────────────────┘
            ////
            ////
            //// 02. Вторая группа
            ////
            ////    │    Что-то     │
            ////    │   принимает   │
            ////    │  аргументами  │
            //// ┌──┘               └────────────────────────┐
            //// │                                           │
            //// │                Что-то делает              │
            //// │                                           │
            //// └───────────────────────────────────────────┘
            ////
            ////
            //// 03. Третья группа
            ////
            //// ┌───────────────────────────────────────────┐
            //// │                                           └──────
            //// │                Что-то делает                     >>> выдаёт результат своей работы
            //// │                                           ┌──────
            //// └───────────────────────────────────────────┘
            ////
            //// 04. Четвертая группа
            ////
            ////    │    Что-то     │
            ////    │   принимает   │
            ////    │  аргументами  │
            //// ┌──┘               └────────────────────────┐
            //// │                                           └──────
            //// │                Что-то делает                     >>> выдаёт результат своей работы
            //// │                                           ┌──────
            //// └───────────────────────────────────────────┘

            #region Есть и другие

            ////                              │               │
            ////                              │       ^       │
            ////                              │      ^^^      │
            ////                              │     ^^^^^     │
            ////                              │               │
            ////                              │    Что-то     │
            ////                              │  возвращает   │
            ////                              │  аргументами  │
            //// ┌────────────────────────────┘               └────┐
            //// │                                                 │
            //// │                Что-то делает                    │
            //// │                                                 │
            //// └─────────────────────────────────────────────────┘


            ////    │               │         │               │
            ////    │    Что-то     │         │       ^       │
            ////    │   принимает   │         │      ^^^      │
            ////    │  аргументами  │         │     ^^^^^     │
            ////    │               │         │               │
            ////    │     vvvvv     │         │    Что-то     │
            ////    │      vvv      │         │  возвращает   │
            ////    │       v       │         │  аргументами  │
            //// ┌──┘               └─────────┘               └────┐
            //// │                                                 │
            //// │                Что-то делает                    │
            //// │                                                 │
            //// └─────────────────────────────────────────────────┘



            ////                              │               │
            ////                              │      ^        │
            ////                              │     ^^^       │
            ////                              │    ^^^^^      │
            ////                              │               │
            ////                              │    Что-то     │
            ////                              │  возвращает   │
            ////                              │  аргументами  │
            //// ┌────────────────────────────┘               └────┐
            //// │                                                 └──────
            //// │                Что-то делает                           >>> выдаёт результат своей работы
            //// │                                                 ┌──────
            //// └─────────────────────────────────────────────────┘



            ////    │               │         │               │
            ////    │    Что-то     │         │      ^        │
            ////    │   принимает   │         │     ^^^       │
            ////    │  аргументами  │         │    ^^^^^      │
            ////    │               │         │               │
            ////    │     vvvvv     │         │    Что-то     │
            ////    │      vvv      │         │  возвращает   │
            ////    │       v       │         │  аргументами  │
            //// ┌──┘               └─────────┘               └────┐
            //// │                                                 └──────
            //// │                Что-то делает                           >>> выдаёт результат своей работы
            //// │                                                 ┌──────
            //// └─────────────────────────────────────────────────┘



            #region ¯\_(ツ)_/¯

            ////    │     vvvvv     │        
            ////    │      vvv      │        
            ////    │       v       │          
            //// ┌──┘               └──────────────────────────────────────────┐
            //// │      Что-то делает                                          │
            //// │                                                             │   
            //// │       │               │                                     │           
            //// │       │      vvv      │                                     │             
            //// │       │       v       │                                     │            
            //// │    ┌──┘               └────────────────────────┐            │                  
            //// │    │       Что-то делает                       │            │             
            //// │    │                                           │            │
            //// │    │       │               │                   │            │             
            //// │    │       │      vvv      │                   │            │           
            //// │    │       │       v       │                   │            │             
            //// │    │    ┌──┘               └─────┐             │            │                
            //// │    │    │    Что-то делает       │             │            │
            //// │    │    │                        │             │            │
            //// │    │    │     │ V │              │             │            │
            //// │    │    │   ┌─┘   └──┐           │             │            │
            //// │    │    │   │        └──────     │             │            │
            //// │    │    │   |  ???         >>>   │             │            │
            //// │    │    │   |        ┌──────     └──────       │            │
            //// │    │    │   └────────┘                >>>      │            │
            //// │    │    │                        ┌──────       │            │     
            //// │    │    └────────────────────────┘             │            │                     
            //// │    │                                           └──────      │
            //// │    │                                                >>>     │
            //// │    │                                           ┌──────      └──────
            //// │    └───────────────────────────────────────────┘                 >>> выдаёт результат своей работы                                
            //// │                                                             ┌──────
            //// └─────────────────────────────────────────────────────────────┘

            #endregion


            #endregion

            //static void Pause()
            //{
            //    Console.ReadKey();
            //}
            ///// <summary>
            ///// Вывод приветствия в консоль
            ///// </summary>
            //static void Hi()
            //{
            //    Console.WriteLine("Привет!");
            //}

            ///// <summary>
            ///// Беспорядок в консоли
            ///// </summary>
            //static void ApplauseAndOvations()
            //{
            //    Random r = new Random();

            //    for (int i = 0; i < r.Next(1, 5); i++)
            //    {
            //        int posX = r.Next(Console.WindowWidth - 5);   // Получение ширины консоли
            //        int posY = r.Next(Console.WindowHeight - 1);  // Получение высоты консоли
            //        Console.SetCursorPosition(posX, posY + 1);  // Установка курсора в случайную позицию на экране
            //        Console.Write(r.Next(2) == 0 ? "Ура!" : "Ууу!");  // Вывод одного из радостных сообщений
            //    }
            //}
            //#region 01. Первая группа

            //////
            ////// ┌───────────────────────────────────────────┐
            ////// │                                           │
            ////// │                Что-то делает              │
            ////// │                                           │
            ////// └───────────────────────────────────────────┘
            //////
            //////
            ////   static void MethodName()
            ////   {
            ////
            ////   }

            //#endregion

            //Hi(); // Вызов метода Hi
            //ApplauseAndOvations(); // Вызов метода ApplauseAndOvations
            //Pause(); // Вызов метода Pause

            /// <summary>
            /// Метод откладывающий закрытие консоли на Interval секунд 
            /// </summary>
            /// <param name="Interval">Количество секунд до закрытия консоли
            /// </param>
            static void Pause(int Interval)
            {
                Thread.Sleep(Interval * 1000);
            }

            /// <summary>
            /// Вывод персонифицированного приветствия в консоль
            /// </summary>
            /// <param name="Name">Имя, кото нужно поприветствовать</param>
            //static void Hi(string Name)
            //{
            //    Random r = new Random();

            //    string text = string.Empty;

            //    switch (r.Next(5))
            //    {
            //        case 0: text = $"Привет, {Name}!"; break;
            //        case 1: text = $"Добрый день, {Name}!"; break;
            //        case 2: text = $"Приветствую тебя, {Name}!"; break;
            //        case 3: text = $"Рад тебя видеть, {Name}!"; break;
            //        default: text = $"Я так ждал тебя, {Name}!"; break;
            //    }

            //    Console.WriteLine(text);
            //}

            /// <summary>
            /// Упорядоченный беспорядок на экране нужное количество раз
            /// </summary>
            /// <param name="Text1">Первый текст для вывода на экран</param>
            /// <param name="Text2">Второй текст для вывода на экран</param>
            /// <param name="Count">Сколько раз нужно вывести один из случайным образом выбранных текстов</param>
            static void ApplauseAndOvations(string Text1, string Text2, int Count)
            {
                Random r = new Random();
                int max = new int[] { Text1.Length, Text1.Length }.Max();

                for (int i = 0; i < Count; i++)
                {
                    int posX = r.Next(Console.WindowWidth - max);   // Получение ширины консоли
                    int posY = r.Next(Console.WindowHeight);        // Получение высоты консоли
                    Console.SetCursorPosition(posX, posY + 1);      // Установка курсора в случайную позицию на экране
                    Console.Write(r.Next(2) == 0 ? Text1 : Text2);  // Вывод одного из радостных сообщений
                }
            }

            #region 02. Вторая группа
            ////
            ////    │    Что-то     │
            ////    │   принимает   │
            ////    │  аргументами  │
            //// ┌──┘               └────────────────────────┐
            //// │                                           │
            //// │                Что-то делает              │
            //// │                                           │
            //// └───────────────────────────────────────────┘
            // 
            //   static void MethodName(ФормаьныеПараметры)
            //   {
            //
            //   }

            #endregion

            //Hi("Илон"); // Вызов метода Hi
            ApplauseAndOvations("Огого!", "Ёёёёууу!", 70); // Вызов метода ApplauseAndOvations
            Pause(1); // Вызов метода Pause
            Console.Clear();
            Console.ReadKey();

            /// <summary>
            /// Метод генерации строки из набора случайных символов
            /// </summary>
            /// <param name="Count">Количество символов</param>
            /// <returns>Случайная строка</returns>
            static string GetRandomString(int Count)
            {
                return Guid.NewGuid().ToString().Substring(0, Count);
            }

            /// <summary>
            /// Метод, возвращающий полный путь к текущему приложению
            /// </summary>
            /// <returns>Полный путь к текущему приложению</returns>

            /// <summary>
            /// Метод, возвращающий максимальное из двух чисел
            /// </summary>
            /// <param name="Value1">Первое число</param>
            /// <param name="Value2">Второе число</param>
            /// <returns>Максимальнео число</returns>
            //static int Max(int Value1, int Value2)
            //{
            //    return Value1 > Value2 ? Value1 : Value2;
            //}

            /// <summary>
            /// Метод, принимающий массив целых чисел и возвращающий массив с противолоными числами
            /// </summary>
            /// <param name="Args">Входной массив</param>
            /// <returns>Преобразованный массив</returns>
            static int[] Inverse(int[] Args)
            {
                int[] t = new int[Args.Length];

                for (int i = 0; i < Args.Length; i++)
                {
                    t[i] = -Args[i];
                }
                return t;
            }

            #region 04. Четвертая группа
            //// 
            ////
            ////    │    Что-то     │
            ////    │   принимает   │
            ////    │  аргументами  │
            //// ┌──┘               └────────────────────────┐
            //// │                                           └──────
            //// │                Что-то делает                     >>> выдаёт результат своей работы
            //// │                                           ┌──────
            //// └───────────────────────────────────────────┘
            //
            // 
            //   static ТипДанных MethodName(ФормаьныеПараметры)
            //   {
            //      
            //   }

            #endregion

            Console.WriteLine(GetRandomString(5));    // Вызов метода GetRandomString
            Console.WriteLine(GetRandomString(10));   // Вызов метода GetRandomString
            Console.WriteLine(GetRandomString(15));   // Вызов метода GetRandomString

            int[] col = { 1, 3, 5, 7, 9 };

            foreach (int e in col)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            int[] inverseCol = Inverse(col);          // Вызов метода Inverse
            foreach (int e in inverseCol)
            {
                Console.Write($"{e} ");
            }
        }

        private static void ForEach()
        {
            // 7. Цикл foreach

            #region Задача 1

            //Console.WriteLine("Сформировать массив из N случайных чисел от -5 до 5");

            ////Решение

            //Console.Write("Введите n: ");               // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());      // Ввод числа с клавиатуры

            //Random random = new Random();               // Инициализация генератора псевдослучайных чисел

            //int[] numbs = new int[n];                   // Объявление и инициализация массива

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(-5, 6);          // Заполнение массива
            //}                                           // 

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //}                                           //
            //Console.WriteLine();

            //foreach (var e in numbs)
            //{
            //    Console.Write($"{e} ");
            //}

            //Console.ReadKey();

            #endregion

            #region int[][] dataTime

            //int[][] dataTime = new int[24][];

            ////int[][][] vs = new int[3][][];
            ////vs[0] = new int[3][];


            //for (int j = 0; j < dataTime.Length; j++)
            //{
            //    dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            //}

            ////for (int i = 0; i < dataTime.Length; i++)
            ////{
            ////    for (int j = 0; j < dataTime[i].Length; j++)
            ////    {
            ////        Console.Write($"{dataTime[i][j],3} ");
            ////    }
            ////    Console.WriteLine();
            ////}

            //foreach (var array in dataTime)
            //{
            //    foreach (var e in array)
            //    {
            //        Console.Write($"{e,3} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region String

            //string message = "Я С#-разработчик";

            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write($"{message[i]} ");
            //}

            //Console.WriteLine();

            //foreach (var c in message)
            //{
            //    Console.Write($"{c} ");
            //}

            Console.WriteLine();
            Console.ReadKey();

            #endregion
        }

        private static void JaggedArray2()
        {
            // 6. Массив массивов

            ////         0     1     2     3
            ////     ┌─────────────────────────┐
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  0  │ │ 1 │ │ 3 │ │ 0 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  1  │ │ 1 │ │ 0 │ │ 3 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  2  │ │ 2 │ │ 0 │ │ 1 │ │ 9 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     └─────────────────────────┘



            ////         0     1     2     3
            ////     ┌─────────────┐
            ////     │ ┌───┐ ┌───┐ │
            ////  0  │ │ 1 │ │ 3 │ │
            ////     │ └───┘ └───┘ └───────────┐
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  1  │ │ 1 │ │ 0 │ │ 3 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌─────┘
            ////  2  │ │ 2 │ │ 0 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ │
            ////     └───────────────────┘

            // Зубчатые массивы являются массивами массивов
            // Они могут иметь неправильные размеры.
            // Размеры распределяются по одному за раз

            //int[,]
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[2];
            //jaggedArray[0,1]
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 3;

            jaggedArray[1] = new int[4];
            jaggedArray[1][0] = 1;
            jaggedArray[1][1] = 0;
            jaggedArray[1][2] = 3;
            jaggedArray[1][3] = 1;

            jaggedArray[2] = new int[3];
            jaggedArray[2][0] = 2;
            jaggedArray[2][1] = 0;
            jaggedArray[2][2] = 1;


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }

            // Написать программу, моделирующую получение показаний метоостанции
            // Собирать и хранить информацию о температуре воздуха
            // В период с 9 ч утра до 21 ч вечера каждые 5 минут
            // В период с 21 ч вечера до 9 утра каждые 15 минут

            #region  int[,] dataTime 
            //Random r = new Random();

            //int[,] dataTime = new int[24, 12];

            //for (int i = 0; i < dataTime.GetLength(0); i++)
            //{
            //    Console.Write($"{i,3}ч. ");
            //    for (int j = 0; j < dataTime.GetLength(1); j++)
            //    {
            //        if (i >= 9 && i < 21) dataTime[i, j] = r.Next(20);
            //        else dataTime[i, j] = (j < 4) ? r.Next(20) : 0;

            //        Console.Write($"{dataTime[i, j],3} ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.ReadKey();
            //Console.Clear();
            //for (int i = 0; i < dataTime.GetLength(0); i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write($"{i,3}ч. ");
            //    for (int j = 0; j < dataTime.GetLength(1); j++)
            //    {
            //        if (i >= 9 && i < 21) Console.ForegroundColor = ConsoleColor.White;
            //        else Console.ForegroundColor = (j < 4) ? ConsoleColor.White : ConsoleColor.Red;
            //        Console.Write($"{dataTime[i, j],3} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ForegroundColor = ConsoleColor.White;

            #endregion

            #region int[][] dataTime

            //Random r = new Random();
            //int[][] dataTime = new int[24][];

            //for (int j = 0; j < dataTime.Length; j++)
            //{
            //    dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            //}

            //for (int i = 0; i < dataTime.Length; i++)
            //{
            //    Console.Write($"{i} ч. ");
            //    for (int j = 0; j < dataTime[i].Length; j++)
            //    {
            //        dataTime[i][j] = r.Next(20);
            //        Console.Write($"{dataTime[i][j],3} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
        }

        private static void MultiAray()
        {
            // 5. Многомерные массивы: использование, задание
            int[,,] matrix3D = new int[3, 4, 5];

            Console.WriteLine($"matrix3D.Rank = {matrix3D.Rank}");

            Console.WriteLine($"matrix3D.Length = {matrix3D.Length}");
            Console.WriteLine($"matrix3D.GetLength(0) = {matrix3D.GetLength(0)}");
            Console.WriteLine($"matrix3D.GetLength(1) = {matrix3D.GetLength(1)}");
            Console.WriteLine($"matrix3D.GetLength(2) = {matrix3D.GetLength(2)}");

            Random r = new Random();


            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        matrix3D[i, j, k] = r.Next(10);
                        Console.Write($"{matrix3D[i, j, k]} ");
                    }
                }
            }

            Console.WriteLine("\n\n");

            int[,,,] matrix4D = new int[3, 4, 5, 6];

            Console.WriteLine($"matrix4D.Rank = {matrix4D.Rank}");

            Console.WriteLine($"matrix4D.Length = {matrix4D.Length}");
            Console.WriteLine($"matrix4D.GetLength(0) = {matrix4D.GetLength(0)}");
            Console.WriteLine($"matrix4D.GetLength(1) = {matrix4D.GetLength(1)}");
            Console.WriteLine($"matrix4D.GetLength(2) = {matrix4D.GetLength(2)}");
            Console.WriteLine($"matrix4D.GetLength(3) = {matrix4D.GetLength(3)}");

            for (int i = 0; i < matrix4D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix4D.GetLength(2); k++)
                    {
                        for (int l = 0; l < matrix4D.GetLength(3); l++)
                        {
                            matrix4D[i, j, k, l] = r.Next(10);
                            Console.Write($"{matrix4D[i, j, k, l]} ");
                        }
                    }
                }
            }

            Console.WriteLine("\n\n");

            int[,,,,] matrix5D = new int[3, 4, 5, 6, 10];

            Console.WriteLine($"matrix5D.Rank = {matrix5D.Rank}");

            Console.WriteLine($"matrix5D.Length = {matrix5D.Length}");
            Console.WriteLine($"matrix5D.GetLength(0) = {matrix5D.GetLength(0)}");
            Console.WriteLine($"matrix5D.GetLength(1) = {matrix5D.GetLength(1)}");
            Console.WriteLine($"matrix5D.GetLength(2) = {matrix5D.GetLength(2)}");
            Console.WriteLine($"matrix5D.GetLength(3) = {matrix5D.GetLength(3)}");
            Console.WriteLine($"matrix5D.GetLength(4) = {matrix5D.GetLength(4)}");

            Console.WriteLine("\n\n");

            Console.ReadKey();

        }

        private static void Array2D()
        {
            // 4. Двумерные массивы: использование, задание

            // int[] collection = new int[3];
            //// ┌───────────────────────────────────────────┐
            //// │    ┌────────┐   ┌────────┐   ┌────────┐   │
            //// │    │   31   │   │   12   │   │  1771  │   │
            //// │    └────────┘   └────────┘   └────────┘   │
            //// │         0            1           2        │
            //// └───────────────────────────────────────────┘

            ////         0     1     2     3
            ////     ┌─────────────────────────┐
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  0  │ │ 1 │ │ 3 │ │ 0 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  1  │ │ 1 │ │ 0 │ │ 3 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  2  │ │ 2 │ │ 0 │ │ 1 │ │ 9 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     └─────────────────────────┘

            //

            int[,] matrix = new int[3, 4]; // Задание двумерного массива, в котором 3 строки и 4 столбца

            matrix[1, 2] = 3;

            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = r.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[row, col];
            _ = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = r.Next(10);
                    Console.Write($"{arr2d[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            string[,] table = new string[,] {
                                  { "00", "01", "02", "03" },
                                  { "10", "11", "12", "13" },
                                  { "20", "21", "22", "23" }
                                };

            Console.WriteLine();

            Console.WriteLine($"table.Rank = {arr2d.Rank}");
            Console.WriteLine($"table.GetLength(0) = {arr2d.GetLength(0)}");
            Console.WriteLine($"table.GetLength(1) = {arr2d.GetLength(1)}");

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j],3} ");
                }
                Console.WriteLine();
            }

            #region Элементы одномерного массива А из 9 чисел построчно расположить в матрице B[3×3]

            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[,] b = new int[3, 3];

            //int counterA = 0;

            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        b[i, j] = a[counterA++];
            //        Console.Write($"{b[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region В матрице Z[3×3] каждый элемент разделить на диагональный, стоящий в том же столбце.

            //
            //  1 2 3
            //  4 5 6
            //  7 8 9
            //Random r = new Random();

            //var Z = new double[3, 3];

            //Console.WriteLine("Исходная матрица Z[3x3]: ");

            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        Z[i, j] = r.Next(1, 10);
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Матрица Z[3x3] после преобразования: ");

            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    double div = Z[i, i];
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        Z[i, j] /= div;
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Для каждой строки матрицы A[4×4] найти сумму элементов.

            _ = new Random();

            int[,] A = new int[4, 4];

            Console.WriteLine("Исходная матрица A[4x4]: ");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r.Next(1, 3);
                    sum += A[i, j];
                    Console.Write($"{A[i, j],2} ");
                }
                Console.WriteLine($" : {sum}");
            }

            #endregion
        }

        private static void ArrayMethods()
        {
            // 2. Основные методы работы с одномерными массивами
            #region Задача 4

            Console.Clear();
            Console.WriteLine("Массив из N элементов состоит из нулей и единиц.\nПоставить нули в начало, а единицы – в конец.");

            // Решение
            Random random = new Random();               // Инициализация генератора псевдослучайных чисел

            Console.Write("\nКоличество элементов: ");  // Приглашение ко вводу числа
            int n = int.Parse(Console.ReadLine());      // Ввод искомого числа с клавиатуры
            int[] numbs = new int[n];                  // Объявление и инициализация массива

            Console.Write("\nИсходный массив: ");       // 

            for (int i = 0; i < numbs.Length; i++)      //
            {                                           //
                numbs[i] = random.Next(0, 2);           // Заполнение массива
                Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            }                                           // 

            //     0  1  0  0  0  0  1  0  1  0
            //     ^                          ^
            //                                  

            #region Old

            //int head = 0;                               // Указатель головного элемента
            //int tail = numbs.Length - 1;                // Указатель хвостового элемента

            //bool flag = true;                           // Флаг, показывающий увеличивать позицию головного - flag = true
            //                                            // или уменьшать позицию хвостового - flag = false

            //while (head < tail)                         // Пока "голова" меньше "хвоста"
            //{
            //    if (flag)                               // flag = true
            //    {                                       //
            //        if (numbs[head] == 1) flag = false; // Работаем с головным элементом
            //        else head++;                        //
            //    }
            //    else                                    // иначе flag = false
            //    {                                       //
            //        if (numbs[tail] == 0) flag = true;  // Работаем с хвостовым элементом
            //        else tail--;                        // 
            //    }

            //    if (numbs[head] == 1 && numbs[tail] == 0)  // Если головной элемент = 1 и хвостовой = 0
            //    {
            //        int temp = numbs[head];             //
            //        numbs[head] = numbs[tail];          // Меняем их местами
            //        numbs[tail] = temp;                 //

            //        head++;                             // Сдвигаем голову 
            //        tail--;                             // и хвост
            //    }
            //}

            #endregion

            #region ToDo

            Array.Sort(numbs);

            #endregion

            Console.Write("\nПолучившийся массив: ");

            for (int i = 0; i < numbs.Length; i++)      //
            {                                           //
                Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            }

            Console.ReadKey();

            #endregion
            int[] data = new int[] { 1, 5, 2, 5, 4, 6, 5, 7, 6, 8, 6, 9, 5, 1 };

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"data.Length = {data.Length}"); // Получает общее число элементов во всех измерениях массива

            int result = Array.IndexOf(data, 5); // Выполняет поиск указанного объекта внутри 
                                                 // всего одномерного массива и возвращает индекс его первого вхождения.

            Console.WriteLine($"Array.IndexOf(data, 5) = {result}");

            result = Array.LastIndexOf(data, 5);
            Console.WriteLine($"Array.LastIndexOf(data, 5) = {result}");

            int rank = data.Rank; // Получает ранг (число измерений) массива. 

            Console.WriteLine($"data.Rank = {rank}");

            Array.Sort(data);   // Сортирует элементы во всем массиве 

            Console.WriteLine("\nМассив после применения Array.Sort(data): ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Array.Reverse(data);   // Изменяет порядок элементов во всем одномерном массиве на обратный.

            Console.WriteLine("Массив после применения Array.Reverse(data): ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Array.Clear(data, 7, 3);    // Задает для диапазона элементов в массиве значение, предусмотренное по умолчанию

            Console.WriteLine("Массив после применения Array.Clear(data, 7, 3): ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            int[] copyData = new int[20];

            Array.ConstrainedCopy(data, 2, copyData, 10, 5);
            // Копирует диапазон элементов из массива (data), начиная с заданного индекса (2)
            // источника, и вставляет его в другой массив (copyData) , начиная с заданного
            // индекса (10) назначения. Гарантирует, что в случае невозможности успешно скопировать
            // весь диапазон, все изменения будут отменены.
            // 5 - количество копируемых элементов

            //Array.Copy()

            Console.WriteLine("Массив copyData: ");

            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Массив copyData после применения  Array.ConstrainedCopy(data, 4, copyData, 10, 5): ");

            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine("\n");

            // 3. Вложенные циклы, операторы break и continue

            #region Распечатать таблицу умножения

            // 2 x 1 = 2        3 x 1 = 3          4 x 1 = 4
            // 2 x 2 = 4        3 x 2 = 6          4 x 2 = 8
            // 2 x 3 = 6        3 x 3 = 9          4 x 3 = 12
            // 2 x 4 = 8        3 x 4 = 12         4 x 4 = 16
            // 2 x 5 = 10       3 x 5 = 15         4 x 5 = 20
            // 2 x 6 = 12       3 x 6 = 18         4 x 6 = 24
            // 2 x 7 = 14       3 x 7 = 21         4 x 7 = 28
            // 2 x 8 = 16       3 x 8 = 24         4 x 8 = 32
            // 2 x 9 = 18       3 x 9 = 27         4 x 9 = 36
            // 2 x 10 = 20      3 x 10 = 30        4 x 10 = 40

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"2 x {i} = {2 * i}");
            //}
            //Console.WriteLine();


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"3 x {i} = {3 * i}");
            //}
            //Console.WriteLine();


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"4 x {i} = {4 * i}");
            //}
            Console.WriteLine();

            #region ToDo

            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region Показать всевозможные трехбуквенные слова из алфавита S K I L
            //4 * 4 * 4 = 4^3

            #region ToDo

            //char[] symbols = { 'S', 'K', 'I', 'L' };
            //int count = 1;

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    for (int j = 0; j < symbols.Length; j++)
            //    {
            //        for (int k = 0; k < symbols.Length; k++)
            //        {
            //            Console.WriteLine($"{count++,3}: {symbols[i]}{symbols[j]}{symbols[k]}");
            //        }
            //    }
            //}

            #endregion

            #endregion

            #region Найти хотя бы одно решение уравнения в целых числах

            //     ┌                             ┐
            //     │     ┌   ┐ 3         ┌   ┐ 2 │
            //     │ 2 × │ a │    +  3 × │ b │   │ = 8337
            //     │     └   ┘           └   ┘   │
            //     └                             ┘

            // 2 * 1^3 + 3 * 1^2
            // 2 * 1^3 + 3 * 2^2
            // 2 * 1^3 + 3 * 3^2
            // 2 * 1^3 + 3 * 4^2
            // 2 * 1^3 + 3 * 5^2
            // ...
            // 2 * 2^3 + 3 * 1^2
            // 2 * 2^3 + 3 * 2^2
            // 2 * 2^3 + 3 * 3^2
            // 2 * 2^3 + 3 * 4^2
            // 2 * 2^3 + 3 * 5^2
            // ...
            // 2 * 3^3 + 3 * 1^2
            // 2 * 3^3 + 3 * 2^2
            // 2 * 3^3 + 3 * 3^2
            // 2 * 3^3 + 3 * 4^2
            // 2 * 3^3 + 3 * 5^2

            #region ToDo

            //for (double a = -500; a < 500; a++)
            //{
            //    for (double b = -500; b < 500; b++)
            //    {
            //        if ((2 * a * a * a + 3 * b * b) == 8337) Console.WriteLine($"a = {a}  b = {b}");
            //    }
            //}

            #endregion

            #endregion

            #region break и continue

            int count = 0;

            //for (int i = 0; i < 1_000; i++)
            //{
            //    //if (i % 2 == 0) continue;
            //    for (int j = 0; j < 1_000; j++)
            //    {
            //        break;
            //        //Console.Write($"({i} {j})  ");


            //    }
            //    count++;
            //}

            Console.WriteLine($"count = {count}");

            Console.WriteLine();
            #endregion

        }

        private static void Arrays()
        {
            // 1. Одномерные массивы: инициализация, определения, использование, задание

            #region Введение

            //
            // Массив - структура данных, хранящая набор значений (элементов массива), 
            // идентифицируемых по индексу или набору индексов, 
            //
            // Массив данных имеет одинаковый тип данных.
            // Чтобы объявить массив, типу данных добавляется набор квадратных скобок.
            // Это будет означать, что выпланируете создать массив
            // После этого указывается идентификатор (имя) массива. 
            // Массив может быть объявлен любым типом данных, и все его элементы будут иметь этот тип.

            // Задание массива целых чисел 
            int[] x;

            // Массив объявляется с ключевым словом new, за которым идёт информация о
            // типе данных и количестве элементов массива.
            // Это фиксированное количество, которые может содержать массив. 
            // Когда массив создан, элементы будут автоматически назначены данными по умолчанию для 
            // этого типа. (числа - нули, bool - false и т.д. )

            x = new int[3]; // int-массив из 3 элементов

            double[] array = new double[5]; // double-массив из 5 элементов

            // Для заполнения элементов массива нужно указать его номер в квадратных скобках.
            // Обратите внимание, что индекс первого элемента начинается с нуля.

            x[0] = 1;
            x[1] = 12;
            x[2] = 223;

            array[0] = 3;
            array[1] = 5;
            array[2] = 8;
            array[3] = 13;
            array[4] = 21;

            // 
            int[] birthdayCollection = new int[8] { 2, 8, 0, 9, 1, 9, 9, 0 };
            int[] newYearCollection = new int[] { 31, 12, 2319 };
            string[] dateCollection = { "01", "01", "1771" };

            ////
            //// ┌───────────────────────────────────────────┐
            //// │    ┌────────┐   ┌────────┐   ┌────────┐   │
            //// │    │   31   │   │   12   │   │  1771  │   │
            //// │    └────────┘   └────────┘   └────────┘   │
            //// │         0            1           2        │
            //// └───────────────────────────────────────────┘
            ////               newYearCollection              
            ////                                              
            //// birthdayCollection[0]
            //// birthdayCollection[1]
            //// birthdayCollection[2]
            //// Индексы меняются от 0 до 2                               
            ///

            #endregion

            #region Задача 1

            //Console.WriteLine("Сформировать массив из N случайных чисел от -5 до 5");

            //// Решение

            //Console.Write("Введите n: ");               // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());      // Ввод числа с клавиатуры

            //Random random = new Random();               // Инициализация генератора псевдослучайных чисел

            //int[] numbs = new int[n];                   // Объявление и инициализация массива

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(-5, 6);          // Заполнение массива
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //}                                           // 


            Console.ReadKey();

            #endregion

            #region Задача 2

            //Console.Clear();
            //Console.WriteLine("Сформировать массив N случайных чисел. Подсчитать количество четных чисел");

            Random random = new Random();
            //// Решение

            //Console.Write("Введите n: ");               // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());          // Ввод числа с клавиатуры

            //var numbs = new int[n];                         // Объявление и инициализация массива

            //int evenElement = 0;                        // Количество четных элементов

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(10);             // Заполнение массива
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //    if (numbs[i] % 2 == 0) evenElement++;    // Подсчёт чётных элементов
            //}                                           // 



            //                                        //

            //Console.WriteLine($"\nЧётных: {evenElement}");

            //Console.ReadKey();

            #endregion

            #region Задача 3

            //Console.Clear();
            //Console.WriteLine("В массиве из 10 чисел вычислить, сколько раз встречается введенное число");

            //// Решение

            //int[] numbs = new int[10];                         // Объявление и инициализация массива

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(10);             // Заполнение массива
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //}                                           // 

            //Console.Write("\nКакое число ищём: ");      // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());      // Ввод искомого числа с клавиатуры

            //int find = 0;                               // Результат поиска


            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    if (numbs[i] == n) find++;              // Поиск искомого элемента
            //}

            //Console.WriteLine($"\nЭлемент '{n}' найден: {find} р. ");

            //Console.ReadKey();

            #endregion

            #region Задача 4

            Console.Clear();
            Console.WriteLine("Массив из N элементов состоит из нулей и единиц.\nПоставить нули в начало, а единицы – в конец.");

            // Решение

            Console.Write("\nКоличество элементов: ");  // Приглашение ко вводу числа
            int n = int.Parse(Console.ReadLine());      // Ввод искомого числа с клавиатуры
            int[] numbs = new int[n];                   // Объявление и инициализация массива

            Console.Write("\nИсходный массив: ");       // 

            for (int i = 0; i < numbs.Length; i++)      //
            {                                           //
                numbs[i] = random.Next(0, 2);           // Заполнение массива
                Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            }                                           // 

            //     0  0  0  0  0  0  0  1  1  1
            //                       ^  ^     
            //                                  

            int head = 0;                               // Указатель головного элемента
            int tail = numbs.Length - 1;                // Указатель хвостового элемента

            bool flag = true;                           // Флаг, показывающий увеличивать позицию головного - flag = true
                                                        // или уменьшать позицию хвостового - flag = false

            while (head < tail)                         // Пока "голова" меньше "хвоста"
            {
                if (flag)                                // flag = true
                {                                       //
                    if (numbs[head] == 1)
                    {
                        flag = false; // Работаем с головным элементом
                    }
                    else
                    {
                        head++;                        //
                    }
                }
                else                                    // иначе flag = false
                {                                       //
                    if (numbs[tail] == 0)
                    {
                        flag = true;  // Работаем с хвостовым элементом
                    }
                    else
                    {
                        tail--;                        // 
                    }
                }

                if (numbs[head] == 1 && numbs[tail] == 0)  // Если головной элемент = 1 и хвостовой = 0
                {
                    (numbs[tail], numbs[head]) = (numbs[head], numbs[tail]);             //

                    head++;                             // Сдвигаем голову 
                    tail--;                             // и хвост
                }
            }

            Console.Write("\nПолучившийся массив: ");

            for (int i = 0; i < numbs.Length; i++)      //
            {                                           //
                Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            }

            Console.ReadKey();

            #endregion
        }

        private static void DoWhileLoop()
        {
            // Цикл do-while продолжает выполнение блока кода, только если условие продолжение истинно.
            // Условие проверяется только в конце каждой итерации.
            // В следствии чего, при использовании do-while, тело цикла быдет выполнено хотя бы один раз


            bool condition = false;
            do
            {
                // Тело цикла
            } while (condition);


            Console.WriteLine("Вывод чисел от 0 до 9");
            int i = 0;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i < 10);


            Console.WriteLine("\n\nВывод чисел от -5 до 5");
            i = -5;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <= 5);


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 1");
            int j = 0;
            do
            {
                Console.Write($"{10 - j} ");
                j++;
            } while (j < 10);


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 2");
            int k = 10;
            do
            {
                Console.Write($"{k} ");
                k--;
            } while (k >= 1);


            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            int counter = 1;
            do
            {
                Console.Write($"{counter} ");
                counter += 3;
            } while (counter <= 22);


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            double step = -1;
            do
            {
                Console.Write($"{step}  ");
                step += 0.25;
            } while (step <= 1);


            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            double interval = 1;
            do
            {
                Console.Write($"{interval}  ");
                interval -= 0.5;
            } while (interval >= -1);





            #region Замечание 1

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\nЗамечание 1");

            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            counter = 28;
            do
            {
                Console.Write($"{counter} ");
                counter += 3;
            } while (counter <= 22);


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            step = 9;
            do
            {
                Console.Write($"{step}  ");
                step += 0.25;
            } while (step <= 1);


            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            interval = -90;
            do
            {
                Console.Write($"{interval}  ");
                interval -= 0.5;
            } while (interval >= -1);

            #endregion

            #region Замечание 2

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\nЗамечание 2");

            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            counter = 28;
            if (counter < 22)
            {
                do
                {
                    Console.Write($"{counter} ");
                    counter += 3;
                } while (counter <= 22);
            }

            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            step = 9;
            if (step == 1)
            {
                do
                {
                    Console.Write($"{step}  ");
                    step += 0.25;
                } while (step <= 1);
            }

            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            interval = -90;
            if (interval == 1)
            {
                do
                {
                    Console.Write($"{interval}  ");
                    interval -= 0.5;
                } while (interval >= -1);
            }
            #endregion

            Console.ReadKey();

            // Пример 1. Сгенерировать 10 случайных чисел от -8 до 9

            Random r = new Random();
            do
            {
                Console.Write($"{r.Next(-8, 10)} ");
                i++;
            } while (i < 10);

            Console.ReadKey();

            // Пример 2. Заказчик просит вас написать прогрмму, в которой 
            // пользователь вводит целое число start.
            // Программа должна вывести таблицу квадратов чисел от start до start+10

            Console.Write("\nВведите start:");
            int start = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
                i++;
            } while (i <= start + 10);

            // Пример 3. Заказчик просит вас написать прогрмму, в которой 
            // пользователь может ввести два целых числа start и end.
            // Программа должна вывести таблицу квадратов чисел от start до end
            //  (!) Разница между start и end не может превышать 20

            Console.Write("\nВведите start:");
            _ = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите end:");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start <= end)
            {
                do
                {
                    Console.WriteLine($"{start,4}^2 = {start * start}");
                    start++;
                } while (start <= end);
            }

            // Пример 5. Пользователь вводит два целых числа numerator и denominator, 
            // которые являются числителем и знаменателем соответственно
            // Нужно выяснить, можно ли сократить эту дробь
            // и если можно, то на какое число
            //   50     25      5     1
            // ----- = ---- = ---- = ---
            //  100     50     10     2

            Console.Write("\nВведите numerator:");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите denominator:");
            double denominator = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Исходная дробь {numerator}/{denominator}");

            double a = numerator, b = denominator;

            #region for

            //for (int i = 0; i < 100000; i++)
            //{
            //    if (a != b) if (a > b) a = a - b; else b = b - a;
            //}

            #endregion
            if (a != b)
            {
                do
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }

                    Console.WriteLine($">>> {a} {b}");
                } while (a != b);
            }
            Console.WriteLine($"Можно сократить на {a}");

            Console.WriteLine($"Сокращённая дробь {numerator / a}/{denominator / a}");
        }

        private static void WhileLoop()
        {
            // Цикл while выполняет блок кода, только если его условие истинно и 
            // будет продолжаться до тех пор, пока условие остается верным.
            // Условие проверяется только в начале каждой итерации.

            bool condition = false;
            while (condition)
            {
                // Тело цикла
            }


            Console.WriteLine("Вывод чисел от 0 до 9");
            int i = 0;
            while (i < 10)
            {
                Console.Write($"{i} ");
                i++;
            }


            Console.WriteLine("\n\nВывод чисел от -5 до 5");
            i = -5;
            while (i <= 5)
            {
                Console.Write($"{i} ");
                i++;
            }


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 1");
            int j = 0;
            while (j < 10)
            {
                Console.Write($"{10 - j} ");
                j++;
            }


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 2");
            int k = 10;
            while (k >= 1)
            {
                Console.Write($"{k} ");
                k--;
            }


            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            int counter = 1;
            while (counter <= 22)
            {
                Console.Write($"{counter} ");
                counter += 3;
            }


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            double step = -1;
            while (step <= 1)
            {
                Console.Write($"{step}  ");
                step += 0.25;
            }


            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            double interval = 1;
            while (interval >= -1)
            {
                Console.Write($"{interval}  ");
                interval -= 0.5;
            }

            Console.ReadKey();

            // Пример 1. Сгенерировать 10 случайных чисел от -8 до 9

            Random r = new Random();
            while (i < 10)
            {
                Console.Write($"{r.Next(-8, 10)} ");
                i++;
            }

            Console.ReadKey();

            // Пример 2. Заказчик просит вас написать прогрмму, в которой 
            // пользователь вводит целое число start.
            // Программа должна вывести таблицу квадратов чисел от start до start+10

            Console.Write("\nВведите start:");
            int start = Convert.ToInt32(Console.ReadLine());
            while (i <= start + 10)
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
                i++;
            }

            // Пример 3. Заказчик просит вас написать прогрмму, в которой 
            // пользователь может ввести два целых числа start и end.
            // Программа должна вывести таблицу квадратов чисел от start до end
            //  (!) Разница между start и end не может превышать 20

            Console.Write("\nВведите start:");
            _ = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите end:");
            int end = Convert.ToInt32(Console.ReadLine());

            while (start <= end)
            {
                Console.WriteLine($"{start,4}^2 = {start * start}");
                start++;
            }

            // Пример 4. Заказчик прочит вас написать программу по подсчёту 
            // среднего балла полученных студентами на экзамене
            // (i) Пользователь с клавиатуры вводит 10 чисел 
            // Требуется найти среднее арифметическое этих чисел

            double value;
            double average = 0;
            while (i <= 10)
            {
                Console.Write($"Введите {i}-й результат вступительного испытания: ");
                value = double.Parse(Console.ReadLine());
                average += value;
                i++;
            }

            Console.WriteLine($"Среднее = {average / 10}");

            // Пример 5. Пользователь вводит два целых числа numerator и denominator, 
            // которые являются числителем и знаменателем соответственно
            // Нужно выяснить, можно ли сократить эту дробь
            // и если можно, то на какое число
            //   50     25      5     1
            // ----- = ---- = ---- = ---
            //  100     50     10     2

            Console.Write("\nВведите numerator:");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите denominator:");
            double denominator = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Исходная дробь {numerator}/{denominator}");

            double a = numerator, b = denominator;

            #region for

            //for (int i = 0; i < 100000; i++)
            //{
            //    if (a != b) if (a > b) a = a - b; else b = b - a;
            //}

            #endregion

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            Console.WriteLine($"Можно сократить на {a}");

            Console.WriteLine($"Сокращённая дробь {numerator / a}/{denominator / a}");
        }

        private static void ForLoop()
        {
            // В C# есть три+одна циклическая конструкция (оператор). 
            // Они используются для выполнения определенной 
            // последовательности действий несколько раз.

            // Цикл — разновидность управляющей конструкции, 
            // предназначенная для организации многократного исполнения набора инструкций.

            // Блок исполняемых инструкций называется телом цикла
            // Одно исполнение набора инструкций называют итерацией цикла

            // Цикл for используется для прохождения через блок указанное число раз.
            // Он использует три параметра.
            // Первый параметр инициализирует счетчик и всегда выполняется один раз, перед циклом.
            // Второй параметр - условие для цикла, оно проверяется перед каждой итерацией.
            // Третий параметр содержит приращение счетчика и выполняется в конце каждой итерации.

            //   Первый   ; Второй; Третий
            for (int i = 0; i < 10; i++)
            {
                // Тело цикла
            }


            Console.WriteLine("Вывод чисел от 0 до 9");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nВывод чисел от -5 до 5");
            for (int i = -5; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 1");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{10 - j} ");
            }

            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 2");
            for (int k = 10; k >= 1; k--)
            {
                Console.Write($"{k} ");
            }


            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            for (int counter = 1; counter <= 22; counter += 3)
            {
                Console.Write($"{counter} ");
            }


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            for (double step = -1; step <= 1; step += 0.25)
            {
                Console.Write($"{step}  ");
            }

            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            for (double interval = 1; interval >= -1; interval -= 0.5)
            {
                Console.Write($"{interval}  ");
            }


            Console.ReadKey();

            // Пример 1. Сгенерировать 10 случайных чисел от -8 до 9

            Random r = new Random();

            for (int i = 0; i < 200; i++)
            {
                Console.Write($"{r.Next(-8, 10)} ");
            }

            Console.ReadKey();

            // Пример 2. Заказчик просит вас написать прогрмму, в которой 
            // пользователь вводит целое число start.
            // Программа должна вывести таблицу квадратов чисел от start до start+10

            Console.Write("\nВведите start:");
            int start = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= start + 10; i++)
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
            }

            // Пример 3. Заказчик просит вас написать прогрмму, в которой 
            // пользователь может ввести два целых числа start и end.
            // Программа должна вывести таблицу квадратов чисел от start до end
            //  (!) Разница между start и end не может превышать 20

            Console.Write("\nВведите start:");
            _ = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите end:");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
            }
            // Пример 4. Заказчик прочит вас написать программу по подсчёту 
            // среднего балла полученных студентами на экзамене
            // (i) Пользователь с клавиатуры вводит 10 чисел 
            // Требуется найти среднее арифметическое этих чисел

            double value;
            double average = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Введите {i}-й результат вступительного испытания: ");
                value = double.Parse(Console.ReadLine());
                average += value;
            }

            Console.WriteLine($"Среднее = {average / 10}");
        }

        private static void Reiteration()
        {
            // Пример 1. Сгенерировать 10 случайных чисел от -8 до 9

            Random rand = new Random();

            Console.WriteLine($"1-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"2-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"3-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"4-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"5-e случайное число {rand.Next(-8, 10)}");

            Console.WriteLine($"6-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"7-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"8-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"9-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"10-e случайное число {rand.Next(-8, 10)}");

            Console.WriteLine($"11-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"12-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"13-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"14-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"15-e случайное число {rand.Next(-8, 10)}");

            Console.WriteLine($"16-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"17-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"18-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"19-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"20-e случайное число {rand.Next(-8, 10)}");
            // Пример 2. Заказчик просит вас написать прогрмму, в которой 
            // пользователь вводит целое число start.
            // Программа должна вывести таблицу квадратов чисел от start до start+10

            Console.Write("\nВведите start:");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;

            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;

            Console.WriteLine($"{start,4}^2 = {start * start}");

            // Пример 3. Заказчик просит вас написать прогрмму, в которой 
            // пользователь может ввести два целых числа start и end.
            // Программа должна вывести таблицу квадратов чисел от start до end
            // Разница между start и end не может превышать 20

            Console.Write("\nВведите start:");
            _ = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите end:");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }

            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }

            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }

            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }
            if (start <= end) { Console.WriteLine($"{start,4}^2 = {start * start}"); start++; }

            // Пример 4. Заказчик прочит вас написать программу по подсчёту 
            // среднего балла полученных студентами на экзамене
            // Пользователь с клавиатуры вводит 10 чисел 
            // Требуется найти среднее арифметическое этих чисел



            Console.Write("Введите 1-й результат вступительного испытания: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Введите 2-й результат вступительного испытания: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.Write("Введите 3-й результат вступительного испытания: ");
            double value3 = double.Parse(Console.ReadLine());

            Console.Write("Введите 4-й результат вступительного испытания: ");
            double value4 = double.Parse(Console.ReadLine());

            Console.Write("Введите 5-й результат вступительного испытания: ");
            double value5 = double.Parse(Console.ReadLine());

            Console.Write("Введите 6-й результат вступительного испытания: ");
            double value6 = double.Parse(Console.ReadLine());

            Console.Write("Введите 7-й результат вступительного испытания: ");
            double value7 = double.Parse(Console.ReadLine());

            Console.Write("Введите 8-й результат вступительного испытания: ");
            double value8 = double.Parse(Console.ReadLine());

            Console.Write("Введите 9-й результат вступительного испытания: ");
            double value9 = double.Parse(Console.ReadLine());

            Console.Write("Введите 10-й результат вступительного испытания: ");
            double value10 = double.Parse(Console.ReadLine());

            double average = (value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10) / 10;
            Console.WriteLine($"Среднее = {average}");

            // Пример 5. Пользователь вводит два целых числа numerator и denominator, 
            // которые являются числителем и знаменателем соответственно
            // Нужно выяснить, можно ли сократить эту дробь
            // и если можно, то на какое число
            //   50     25      5     1
            // ----- = ---- = ---- = ---
            //  100     50     10     2

            Console.Write("\nВведите numerator:");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите denominator:");
            double denominator = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n Исходная дробь {numerator}/{denominator}");

            double a = numerator, b = denominator;

            if (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            if (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            if (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            if (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            Console.WriteLine($"Можно сократить на {a}");

            Console.WriteLine($"Сокращённая дробь {numerator / a}/{denominator / a}");
        }

        private static void Switch()
        {
            // Целое число может принимть множество вариантов
            // Применение if-else для всех значений может быть громоздко
            // поэтому в некоторых случаях выгоднее использовать оператор выбора Switch

            Console.Write("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            if (dayIndex == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (dayIndex == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (dayIndex == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (dayIndex == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (dayIndex == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (dayIndex == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (dayIndex == 7)
            {
                Console.WriteLine("Воскресенье");
            }
            else
            {
                Console.WriteLine("На планете Земля в неделе семь дней");
            }

            switch (dayIndex)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("На планете Земля в неделе семь дней");
                    break;
            }
            // Заказчик просит создать эмулятор игры, в которм у игрока есть возможность выбрать 
            // уровень сложности, в зависимости от которого будет генерироваться разный игровой мир

            Console.WriteLine("Введите уровень сложности. 1 - Простой, 2 - Средний, 3 - Сложный");
            int level;  // 1 - Простой
                        // 2 - Средний
                        // 3 - Сложный
                        // В зависимости от уровня определить количество генериуемых NPC
                        // Простой - Два NPC
                        // Средний - Четыре NPC
                        // Сложный - Пять NPC

            level = Convert.ToInt32(Console.ReadLine());

            #region if-else

            if (level == 1)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else if (level == 2)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else if (level == 3)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else
            {
                Console.WriteLine("Выбран неизвестный уровень сложности");
            }

            #endregion

            #region switch

            switch (level)
            {
                case 1:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                case 2:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                case 3:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                default:
                    Console.WriteLine("Выбран неизвестный уровень сложности");
                    break;
            }

            #endregion

            // Замечание.
            // При использовании оператора switch нет возможности указывать диапазоны значений

            Random r = new Random();

            int value = Convert.ToInt32(Console.ReadLine());

            if (value > 0 && value < 5)
            {
                Console.WriteLine("0 <= value < 5");
            }
            else if (value >= 5 && value < 10)
            {
                Console.WriteLine("5 <= value < 10");
            }


            #region switch вариант 1

            switch (value)
            {
                case 0: Console.WriteLine("0 <= value < 5"); break;
                case 1: Console.WriteLine("0 <= value < 5"); break;
                case 2: Console.WriteLine("0 <= value < 5"); break;
                case 3: Console.WriteLine("0 <= value < 5"); break;
                case 4: Console.WriteLine("0 <= value < 5"); break;
                case 5: Console.WriteLine("5 <= value < 10"); break;
                case 6: Console.WriteLine("5 <= value < 10"); break;
                case 7: Console.WriteLine("5 <= value < 10"); break;
                case 8: Console.WriteLine("5 <= value < 10"); break;
                case 9: Console.WriteLine("5 <= value < 10"); break;
            }

            #endregion

            #region switch вариант 1

            switch (value)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4: Console.WriteLine("0 <= value < 5"); break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Console.WriteLine("5 <= value < 10"); break;
            }

            #endregion

            #region switch ещё один вариант 

            switch (value)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4: Console.WriteLine("0 <= value < 5"); break;
                default: Console.WriteLine("5 <= value < 10"); break;
            }

            #endregion
        }

        private static void TernaryOperator()
        {
            // Тернарный оператор

            // В дополнение к оператору if есть, так называемый, тернарный оператор (?:).
            // Этот оператор может заменить одно предложение if-else, которое 
            // присваивает значение конкретной переменной. 
            // Оператор принимает три выражения. 
            // Если первый оценивается как true, будет возвращено второе выражение, 
            // и если оно false, то возвращается третий

            Random r = new Random();
            double x = r.NextDouble();       // Получение числа от 0.0 до 1.0, не включая 1.0

            int result = (x < 0.5) ? 0 : 1;  // Тернарный оператор (?:)
            Console.WriteLine($"result = {result}");

            result = x < 0.5 ? 0 : 1;

            Console.WriteLine($"result = {result}");

            #region Замечание

            Console.ReadKey();

            Console.WriteLine(x < 0.5 ? 0 : 1);

            if (x < 0.5)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }

            #endregion

            // Заказчик просит написать программу, которая должна генерировать три случайных числа
            // из диапазона от -21 до 22 после чего на экране должно быть выведено максимальное из чисел.
            // Если максимальных чисил несколько ( т.е. каких-то два или все три числа равны) 
            // на экране показать одно число без дополнительных сообщений

            #region Решение if-else

            Random rand = new Random();

            int firstNumber = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            int secondNumber = rand.Next(-21, 23);  // Выдаёт от -21 до 23
            int thirdNumber = rand.Next(-21, 23);   // Выдаёт от -21 до 23

            int maxValue;

            // Если первое число больше двух других, 
            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                maxValue = firstNumber; // то оно максимальное
            }
            else // Если первое число меньше второго или меньше третьего, то максимальное среди двух оставшихся
            {
                if (secondNumber > thirdNumber) // Сравниваем второе и третье число, если второе больше третьего
                {
                    maxValue = secondNumber;   // то максимальное - второе
                }
                else// иначе 
                {
                    maxValue = thirdNumber;// максимальное - третье
                }
            }

            Console.WriteLine($"Максимальное значение = {maxValue}");   // Выводим результат на экран

            #endregion

            #region Решение ?:

            Console.ReadKey();

            int a = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            int b = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            int c = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            maxValue = (a > b) && (a > c) ? a : (b > c) ? b : c;

            maxValue = (firstNumber > b) && (firstNumber > thirdNumber) ? firstNumber : (secondNumber > thirdNumber) ? secondNumber : thirdNumber;


            Console.WriteLine($"Максимальное значение = {maxValue}");   // Выводим результат на экран

            #endregion

            _ = new Random();
            _ = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            _ = rand.Next(-21, 23);   // Выдаёт от -21 до 23

            bool f = a > b;
            int outputInt = f ? a : b;
            Console.WriteLine(outputInt);

            string outputString = f ? "да" : "нет";
            _ = f ? "да" : "";

            Console.WriteLine(outputString);
        }

        private static void IfElse()
        {
            // Условные операторы используются для выполнения различных блоков кода на основе разных условий

            // Оператор if будет выполняться только в том случае, если условие в скобках будет "истина". 
            // Условие может включать в себя любое сравнение и логические операторы
            // т.е. bool результат

            Random rand = new Random();

            int x = rand.Next(3); // Выдаёт 0, 1 или 2
            Console.WriteLine($"Получено значение x = {x}");

            if (x < 2)
            {
                Console.WriteLine("x равен 0 или 1");
            }

            // Часто используемая форма записи

            if (x < 2)
            {
                Console.WriteLine("x равен 0 или 1");
            }
            // Чтобы проверить другие условия, оператор if может быть расширен любым количество if'ов.
            // Каждое дополнительное условие будет проверено, только если все предыдущие условия являются ложными.

            // Пример

            _ = new Random();
            _ = rand.Next(3); // Выдаёт 0, 1 или 2
            Console.WriteLine($"Получено значение x = {x}");

            //if (x == 1) Console.WriteLine("x == 1");
            //else Console.WriteLine("x != 1");

            //if (x==1)
            //{
            //    Console.WriteLine("x == 1");
            //}
            //else
            //{
            //    Console.WriteLine("x != 1");
            //}

            #region if-else-if

            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else if (x > 1)
            {
                Console.WriteLine("x > 1");
            }
            else
            {
                Console.WriteLine("x = 1");
            }

            #endregion

            #region Пример записи 1
            Console.ReadKey();

            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else if (x > 1)
            {
                Console.WriteLine("x > 1");
            }
            else
            {
                Console.WriteLine("x = 1");
            }

            #endregion

            #region Пример записи 2
            Console.ReadKey();

            //if (true)
            //{

            //}
            //else
            //{
            //    if (true)
            //    {

            //    }
            //    else
            //    {
            //        if (true)
            //        {

            //        }
            //        else
            //        {

            //        }
            //    }
            //}

            //if (x < 1)
            //{
            //    Console.WriteLine("x < 1");
            //}
            //else
            //{
            //    if (x > 1)
            //    {
            //        Console.WriteLine("x > 1");
            //    }
            //    else
            //    {
            //        Console.WriteLine("x = 1");
            //    }
            //}

            #endregion
            // Заказчик просит написать программу, которая определяет текущую температуру 
            // и даёт рекомендацию по выбору одежды для прогулки

            _ = new Random();

            int temperature = rand.Next(30);    // Выдаёт от 0 до 30
            Console.WriteLine($"Текущая температура = {temperature}°с");

            if (temperature < 18)
            {
                Console.WriteLine("На улице прохладно, рекомендую взять куртку потеплее");
            }
            else
            {
                Console.WriteLine("На улице тепло, теплая куртка не понадобится");
            }
            // Заказчик просит написать программу, которая должна генерировать два случайных числа
            // из диапазона от -10 до 10 после чего на экране должно быть выведено:
            // 1.1. Максимальное из чисел
            // 1.2. Минимальное из чисел
            // 2. Добавить в программу возможность определения равенства чисел 
            // и вывода соответствующего сообщения на экран
            // 3. Добавить возможность ввода данных с клавиатуры

            _ = new Random();

            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());

            #region Пункт 1 вариант 1

            Console.WriteLine("Пункт 1 вариант 1");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
            }

            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }

            #endregion

            #region Пункт 1 вариант 2

            Console.WriteLine("\nПункт 1 вариант 2");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }

            #endregion

            #region Пункт 1 вариант 3

            Console.WriteLine("\nПункт 1 вариант 3");

            bool flag = firstNumber > secondNumber;

            if (flag)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }

            #endregion

            #region Пункт 1 вариант 4

            Console.WriteLine("\nПункт 1 вариант 4");

            int maxValue, minValue;

            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else
            {
                maxValue = secondNumber;
                minValue = firstNumber;

            }

            Console.WriteLine($"Максимальное число = {maxValue}");
            Console.WriteLine($"Минимальное число = {minValue}");

            #endregion

            #region Пункт 2

            Console.WriteLine("\nПункт 2");

            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else if (firstNumber < secondNumber)
            {
                maxValue = secondNumber;
                minValue = firstNumber;
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

            Console.WriteLine($"Максимальное число = {maxValue}");
            Console.WriteLine($"Минимальное число = {minValue}");

            #endregion

            #region Пункт 3

            //Console.Write("Введите первое число: ");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int secondNumber = int.Parse(Console.ReadLine());

            #endregion

            // Заказчик просит написать приложение, которое по введённому номеру дня недели
            // выведет на экран название этого дня или сообщит, что введённое число не корректно

            Console.Write("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            #region Вариант 1

            if (dayIndex == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else
            {
                if (dayIndex == 2)
                {
                    Console.WriteLine("Вторник");
                }
                else
                {
                    if (dayIndex == 3)
                    {
                        Console.WriteLine("Среда");
                    }
                    else
                    {
                        if (dayIndex == 4)
                        {
                            Console.WriteLine("Четверг");
                        }
                        else
                        {
                            if (dayIndex == 5)
                            {
                                Console.WriteLine("Пятница");
                            }
                            else
                            {
                                if (dayIndex == 6)
                                {
                                    Console.WriteLine("Суббота");
                                }
                                else
                                {
                                    if (dayIndex == 7)
                                    {
                                        Console.WriteLine("Воскресенье");
                                    }
                                    else
                                    {
                                        Console.WriteLine("На планете Земля в неделе семь дней");
                                    }
                                }
                            }
                        }
                    }
                }
            }


            #endregion

            #region Вариант 2

            if (dayIndex == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (dayIndex == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (dayIndex == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (dayIndex == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (dayIndex == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (dayIndex == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (dayIndex == 7)
            {
                Console.WriteLine("Воскресенье");
            }
            else
            {
                Console.WriteLine("На планете Земля в неделе семь дней");
            }

            #endregion
        }

        private static void Random()
        {
            Random randomize = new Random();    // Создание переменной randomize для получения псевослучайных чисел

            Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            Console.WriteLine($"int.MinValue = {int.MinValue}\n");

            #region Замечание

            //Console.WriteLine($"byte.MaxValue = {byte.MaxValue}");
            //Console.WriteLine($"byte.MinValue = {byte.MinValue}\n");

            //Console.WriteLine($"uint.MaxValue = {uint.MaxValue}");
            //Console.WriteLine($"uint.MinValue = {uint.MinValue}\n");

            //Console.WriteLine($"long.MaxValue = {long.MaxValue}");
            //Console.WriteLine($"long.MinValue = {long.MinValue}\n");

            #endregion

            int randomIntResult = randomize.Next();     // Возвращает неотрицательное случайное целое число
                                                        // 32-разрядное целое число со знаком, 
                                                        // которое больше или равно 0 и меньше чем Int32.MaxValue.
            Console.WriteLine($"Пример 1. randomIntResult = {randomIntResult}");

            randomIntResult = randomize.Next(100);      // Возвращает неотрицательное случайное целое число, 
                                                        // которое меньше максимально допустимого значения
                                                        // от 0 до 100, не включая 100 
            Console.WriteLine($"Пример 2. randomIntResult = {randomIntResult}");

            randomIntResult = randomize.Next(10, 100);  // Возвращает неотрицательное случайное целое число, 
                                                        // которое больше минимально допустимого значения
                                                        // и меньше максимально допустимого значения
                                                        // от 10 до 100, не включая 100 

            Console.WriteLine($"Пример 3. randomIntResult = {randomIntResult}");

            double randomDoubleResult = randomize.NextDouble() + randomize.Next(100); // Возвращает случайное число с плавающей запятой, 
                                                                                      // которое больше или равно 0.0 и меньше 1.0
                                                                                      // не включая 1.0
            Console.WriteLine($"Пример 4. randomDoubleResult = {randomDoubleResult}");


        }

        private static void DataRead()
        {
            // Вывод данных
            string name = "Билл Гейтс";
            byte age = 63;
            ushort costs = 118;

            #region _
            //Ввод данных

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму ежемесячных трат: ");
            costs = Convert.ToUInt16(Console.ReadLine());

            #endregion

            Console.WriteLine("Имя: " + name + " Возраст: " + age + " Расходы: $" + costs); // конкатенация строк
            Console.WriteLine("Имя: {0} Возраст: {1} Расходы: ${2}", name, age, costs);     // форматированный вывод
            Console.WriteLine($"Имя: {name} Возраст: {age} Расходы: ${costs}");             // интерполяция строк

            Console.ReadKey();


        }

        private static void MathLogicalOperations()
        {
            int x1 = 30, x2 = 150,  // Координаты вершин прямоугольника
                y1 = 20, y2 = 90;

            int pA = 50, pB = 110;  // Координаты точки

            // Проверка условия принадлежности точки ограниченной области
            bool check = (pA >= x1) && (pA <= x2) && (pB >= y1) && (pB <= y2);
            Console.WriteLine(check);
            Console.ReadKey();
            #region _
            Console.ReadKey();

            pA = 50; pB = 110;
            check = (pA >= x1) && (pA <= x2) && (pB >= y1) && (pB <= y2);
            Console.WriteLine(check);

            #endregion


        }

        private static void LogicalOperations()
        {


            // Высказывание (в математической логике) - Высказывание — это грамматически правильное 
            // повествовательное предложени языка (естественного или искусственного), 
            // которое выражает некоторый смысл и является либо истинным,
            // либо ложным, но не тем и другим сразу.

            // Пример 1. Na — металл - истина
            // Пример 2: 2 + 2 = 5 - ложь
            // Пример 3: Проксима Центавра - ближайшая к Земле звезде - Ложь
            bool variable1 = true;      // 1
            bool variable2 = false;     // 0
            #region Инверсия / Отрицание / Логическое "Не" / !

            Console.WriteLine("Инверсия: ");
            // Определение. Отрицанием высказывания, будет являться Высказывание
            //              «противоположное» исходному

            Console.WriteLine($"variable1 = {variable1}   !variable1 = {!variable1}");
            Console.WriteLine($"variable2 = {variable2}   !variable2 = {!variable2}");

            #endregion

            #region Конъюнкция / Логическое умножение / Логическое "И" / &&

            Console.WriteLine("\nКонъюнкция: ");

            // Определение 2. Конъюнкцией двух высказываний, будет является высказывание
            //                истинное тогда и только тогда, когда оба исходных суждения истинны

            // Пример 4: Nа — металл И Проксима Центавра - ближайшая к солнечной системе звезде 
            // Пример 5: Компьютер работает с нулями и единицами И все люди пьют воду

            //variable1 = true;
            //variable2 = false;

            //bool result = variable1 && variable2;

            //Console.WriteLine($" {true} && {true}  = {true && true}");
            //Console.WriteLine($" {true} && {false} = {true && false}");
            //Console.WriteLine($"{false} && {true}  = {false && true}");
            //Console.WriteLine($"{false} && {false} = {false && false}");
            //Console.ReadKey();
            #endregion

            #region Дизъюнкция  / Логическое сложение / Логическое "ИЛИ" / ||

            //Console.WriteLine("\nДизъюнкция: ");

            // Определение 3. Дизъюнкцией двух высказываний, будет является высказывание
            //                ложное тогда и только тогда, когда оба исходных высказывания ложны

            // Пример 6: Nа — металл  ИЛИ 2 + 2 = 5 
            // Пример 7: Проксима Центавра - ближайшая к Земле звезде ИЛИ все люди пьют воду


            //variable1 = true;
            //variable2 = false;

            //bool result = variable1 || variable2;

            //Console.WriteLine($" {true} || {true}  = {true || true}");
            //Console.WriteLine($" {true} || {false} = {true || false}");
            //Console.WriteLine($"{false} || {true}  = {false || true}");
            //Console.WriteLine($"{false} || {false} = {false || false}");
            //Console.ReadKey();
            #endregion

            #region Разделительная дизъюнкция  / Строгая дизъюнкция / Исключающее «ИЛИ» / ^

            Console.WriteLine("\nРазделительная дизъюнкция: ");

            // Определение 4. Разделительной дизъюнкцией двух высказываний, будет является высказывание
            //                истинное тогда и только тогда, когда только одно из исходных суждения истинно

            //variable1 = true;
            //variable2 = false;

            //bool result = variable1 ^ variable2;

            //Console.WriteLine($" {true} ^ {true}  = {true ^ true}");
            //Console.WriteLine($" {true} ^ {false} = {true ^ false}");
            //Console.WriteLine($"{false} ^ {true}  = {false ^ true}");
            //Console.WriteLine($"{false} ^ {false} = {false | false}");

            #endregion

            #region Другие операции

            bool flag1 = 4 > 5; Console.WriteLine(flag1);
            bool flag2 = 1 < 3; Console.WriteLine(flag2);

            char c = 'f';

            bool flag3 = c == 'f'; Console.WriteLine(flag3);
            bool flag4 = 28 == 28; Console.WriteLine(flag4);
            bool flag5 = 28 >= 24; Console.WriteLine(flag5);
            bool flag6 = 9 <= 9; Console.WriteLine(flag6);
            bool flag7 = 28 != 90; Console.WriteLine(flag7);

            string s = "C#";
            bool flag8 = 28 != 90 && s == "C#"; Console.WriteLine(flag8);

            #endregion
        }

        private static void OperationsPriority()
        {

            // 
            // Унарные операции
            // Префиксный инкремент
            // %, /, * 
            // +, -
            // Постфиксный инкремент
            // () - скобки меняют приоритет операций
            //

            Console.WriteLine((2 + 2) * 2);


        }

        private static void IncrementAndDecrement()
        {

            #region +=
            //Console.ReadKey(); Console.WriteLine("\n+=");

            //int a = 2_000_000_000;
            //int b = 2_000_000_000;
            //int c = a + b;
            //Console.WriteLine(c);  // 25

            //a = a + b;
            //a += b;

            //Console.WriteLine(a);  // 25

            #endregion

            #region -=
            Console.ReadKey(); Console.WriteLine("\n-=");

            int a = 12;
            int b = 13;
            int c = a - b;

            Console.WriteLine(c);  // -1

            //a = a - b;
            a -= b;

            Console.WriteLine(a);  // -1

            #endregion

            #region *=
            Console.ReadKey(); Console.WriteLine("\n*=");

            a = 4;
            b = 5;
            c = a * b;

            Console.WriteLine(c);  // 20

            //a = a * b;
            a *= b;

            Console.WriteLine(a);  // 20

            #endregion

            #region /=
            Console.ReadKey(); Console.WriteLine("\n/=");

            a = 33;
            b = 11;
            c = a / b;

            Console.WriteLine(c);  // 3

            //a = a / b;
            a /= b;

            Console.WriteLine(a);  // 3

            a = 30;
            b = 11;
            c = a / b;
            Console.WriteLine(c); //2

            a /= b;
            Console.WriteLine(a); //2

            double d = 10;
            double e = 4;
            d /= e;
            Console.WriteLine(d); //2.5

            #endregion

            #region %=
            Console.ReadKey(); Console.WriteLine("\n%=");

            a = 14;
            b = 5;
            c = a % b;

            Console.WriteLine(c);  // 4

            //a = a % b;
            a %= b;

            Console.WriteLine(a);  // 4

            #endregion


            #region ++

            Console.ReadKey(); Console.WriteLine("\n++");

            a = 10;

            a += 20;
            Console.WriteLine(a); //30

            a += 1;
            Console.WriteLine(a); //31

            a++; // постфиксный инкремент
            Console.WriteLine(a); //32

            ++a;// префиксный инкремент
            Console.WriteLine(a); //33



            #endregion

            #region --
            Console.ReadKey(); Console.WriteLine("\n--");
            a = 50;

            a -= 20;
            Console.WriteLine(a); //30

            a -= 1;
            Console.WriteLine(a); //29

            a--; // постфиксный инкремент
            Console.WriteLine(a); //28

            --a;// префиксный инкремент
            Console.WriteLine(a); //27

            #endregion
        }

        private static void ArithmeticOperations()
        {
            // Арифметические операции -,*,/,+

            #region Сумма +

            //int valueA = 2_140_000_003; int valueB = 2_140_000_003;
            //double valueC = (double)valueA + (double)valueB;

            //Console.WriteLine(valueC);

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD + valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF + valueG;

            //long valueK = 32; byte valueL = 11;
            //var valueM = valueK + valueL;

            #endregion

            #region  Разность -

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA - valueB;

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD - valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF - valueG;

            //long valueK = 32; byte valueL = 11;
            //var valueM = valueK - valueL;

            #endregion

            #region  Произведение *

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA * valueB;

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD * valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF * valueG;

            //long valueK = 32; byte valueL = 11;
            //double valueM = valueK * valueL;

            #endregion

            #region Частное /

            //int valueA = 10; int valueB = 2;
            //int valueC = valueA / valueB;
            //Console.WriteLine(valueC); // 5

            //double valueA = 5; double valueB = 2;
            //double valueC = valueA / valueB;
            //Console.WriteLine(valueC); // Ожидание:   2.5
            ////                           // Реальность: 2

            //////// Деление в целых чисах [ byte, int, ulong и т.д.]
            ////////
            //////// 56 / 7 = 8
            //////// Делимое / Делитель = Частное
            //////// 56 = 7 * 8
            //////// 
            //////// 59 / 8 = 7 + 3
            ////////
            //////// a = b * q + r
            //////// Делимое / Делитель = Неполное частное + Остаток [ 0 ⩽ Остаток < |Делитель| ]
            //////// 59 = 7 * 8 + [остаток] 3
            //////// 21 = 4 * 5 + [остаток] 1
            //Console.WriteLine("Деление в целых числах");
            //Console.WriteLine($"5/2 = {5 / 2}");
            //Console.WriteLine($"59/8 = {59 / 8}");
            //Console.WriteLine($"21/4 = {21 / 4}");

            //Console.WriteLine("Деление в вещественных");

            //Console.WriteLine($"5.0/2.0 = {5.0 / 2.0}");
            //Console.WriteLine($"59.0/8.0 = {59.0 / 8.0}");
            //Console.WriteLine($"21.0/4.0 = {21.0 / 4.0}");

            #endregion

            #region Остаток от деления %

            //////// Деление в целых чисах [ byte, int, ulong и т.д.]
            ////////
            //////// 56 / 7 = 8
            //////// Делимое / Делитель = Частное
            //////// 56 = 7 * 8
            //////// 
            //////// 59 / 8 = 7 + 3
            ////////
            //////// a = b * q + r
            //////// Делимое / Делитель = Неполное частное + Остаток [ 0 ⩽ Остаток < |Делитель| ]
            //////// 59 = 7 * 8 + [остаток] 3
            //////// 21 = 4 * 5 + [остаток] 1
            //Console.WriteLine("Деление в целых числах. Остаток");
            //Console.WriteLine($"5 / 2 = {5 / 2}");  // 2
            //Console.WriteLine($"5 % 2 = {5 % 2}");  // 1
            //Console.WriteLine($"59 % 8 = {59 % 8}");
            //Console.WriteLine($"21 % 4 = {21 % 4}");


            #endregion
        }

        private static void ConvertTo()
        {
            string inputString = "2029";
            //int intValue = int.Parse(inputString);
            int intValue = Convert.ToInt32(inputString);
            Console.WriteLine(intValue);                // 2029

            long l = Convert.ToInt32(intValue);

            //double doubleValue = double.Parse(inputString);
            double doubleValue = Convert.ToDouble(inputString);
            Console.WriteLine(doubleValue);             // 2029

            //ulong ulongValue = ulong.Parse(inputString);
            ulong ulongValue = Convert.ToUInt64(inputString);
            Console.WriteLine(ulongValue);              // 2029

            //byte byteValue = byte.Parse(inputString);
            //byte byteValue = Convert.ToByte(inputString);
            //Console.WriteLine(byteValue);              // Необработанное исключение: 
            //                                           // System.OverflowException: Значение было недопустимо 
            //                                           // малым или недопустимо большим для беззнакового байта.

            #region Типы данных и их синонимы

            //Тип данных  Тип.NET
            //sbyte       System.SByte
            //short       System.Int16
            //int         System.Int32
            //long        System.Int64
            //byte        System.SByte
            //ushort      System.UInt16
            //uint        System.UInt32
            //ulong       System.UInt64
            //float       System.Single
            //double      System.Double
            //bool        System.Boolean

            #endregion

            #region Замечание

            //checked
            //{
            //    byte byteValue = (byte)intValue;
            //    Console.WriteLine(byteValue);
            //}

            //unchecked
            //{
            //    byte byteValue = (byte)intValue;
            //    Console.WriteLine(byteValue);
            //}

            #endregion

        }

        private static void ParseConversion()
        {
            //string inputString = "2029";
            //int intValue = (int)inputString;     // Ошибка CS0029  
            //                                // Не удается неявно преобразовать тип "string" в "int".


            string inputString = "2029";
            int intValue = int.Parse(inputString);
            Console.WriteLine(intValue);                // 2029

            double doubleValue = double.Parse(inputString);
            Console.WriteLine(doubleValue);             // 2029

            ulong ulongValue = ulong.Parse(inputString);
            Console.WriteLine(ulongValue);              // 2029

            //byte byteValue = byte.Parse(inputString);
            //Console.WriteLine(byteValue);              // Необработанное исключение: 
            // System.OverflowException: Значение было недопустимо 
            // малым или недопустимо большим для беззнакового байта.
        }

        private static void ImplicitTypeСonversion()
        {
            #region Тиды данных

            // byte от 0 до 255
            // ushort от 0 до 65535
            // uint от 0 до 2^32-1 >>> от 0 до 4 294 967 296
            // ulong от 0 до 2^64-1 >>> от 0 до 18 446 744 073 709 551 616


            // sbyte от -128 дo +127
            // short от -32768 дo +32767
            // int от -2^31 дo +2^31-1 >>> от -2 147 483 648 до +2 147 483 647
            // long от -2^63 дo +2^63-1 >>> от -9 223 372 036 854 775 808 до +9 223 372 036 854 775 807

            // Тип float принимает значения От от ±5,0 × 10^(−324) до ±1,7 × 10^308 точность - 15 цифр
            // Тип double принимает значения От ±1,5 x 10^(−45) до ±3,4 x 10^38 точность - 7 цифр
            // Тип decimal принимает значения от ±1,0 x 10^(-28) до ±7,9228 x 10^28 точность - 28 цифр

            #endregion

            byte byteValue = 1;                 // Задание значения переменной типа byte
            short shortValue = byteValue;       // Неявное приведение byte к short
            int intValue = shortValue;          // Неявное приведение short к int
            long longValue = intValue;          // Неявное приведение int к long
            double doubleValue = longValue;     // Неявное приведение long к double

            char c = 'я';
            int d = c;

            Console.WriteLine(d);
        }

        private static void ExplicitTypeConversion()
        {
            #region Тиды данных

            // byte от 0 до 255
            // ushort от 0 до 65535
            // uint от 0 до 2^32-1 >>> от 0 до 4 294 967 296
            // ulong от 0 до 2^64-1 >>> от 0 до 18 446 744 073 709 551 616


            // sbyte от -128 дo +127
            // short от -32768 дo +32767
            // int от -2^31 дo +2^31-1 >>> от -2 147 483 648 до +2 147 483 647
            // long от -2^63 дo +2^63-1 >>> от -9 223 372 036 854 775 808 до +9 223 372 036 854 775 807

            // Тип float принимает значения От от ±5,0 × 10^(−324) до ±1,7 × 10^308 точность - 15 цифр
            // Тип double принимает значения От ±1,5 x 10^(−45) до ±3,4 x 10^38 точность - 7 цифр
            // Тип decimal принимает значения от ±1,0 x 10^(-28) до ±7,9228 x 10^28 точность - 28 цифр

            #endregion

            //int i = 330;    //
            //byte j = i;     // Ошибка компилятора

            int i = 330;          //
            byte j = (byte)i;     // Ошибки компилятора не будет
            Console.WriteLine($"j = {j}");

            //double d = 1.2;     //
            //byte byteValue = d; // Ошибка компилятора

            double d = 1.2;             //
            byte byteValue = (byte)d;   // Ошибки компилятора не будет


            int h = (int)d;

            int q = (byte)d;

        }

        private static void DataTypeConversion()
        {
            #region Тиды данных

            // byte от 0 до 255
            // ushort от 0 до 65535
            // uint от 0 до 2^32-1 >>> от 0 до 4 294 967 296
            // ulong от 0 до 2^64-1 >>> от 0 до 18 446 744 073 709 551 616


            // sbyte от -128 дo +127
            // short от -32768 дo +32767
            // int от -2^31 дo +2^31-1 >>> от -2 147 483 648 до +2 147 483 647
            // long от -2^63 дo +2^63-1 >>> от -9 223 372 036 854 775 808 до +9 223 372 036 854 775 807

            // Тип float принимает значения От от ±5,0 × 10^(−324) до ±1,7 × 10^308 точность - 15 цифр
            // Тип double принимает значения От ±1,5 x 10^(−45) до ±3,4 x 10^38 точность - 7 цифр
            // Тип decimal принимает значения от ±1,0 x 10^(-28) до ±7,9228 x 10^28 точность - 28 цифр

            #endregion

            byte b = 100;   //
            int a = b;      // Всё хорошо

            //int i = 10;     //
            //byte j = i;     // Ошибка компилятора

            double d = a;   // Всё хорошо

            //int g = d;      // Ошибка компилятора



        }

        private static void NumbersAfterPoint()
        {
            //double d = 123456.654321;
            //Console.WriteLine(d);                       // 123456.654321

            //string dFormated = d.ToString("#.###");     
            //Console.WriteLine(dFormated);               // 123456,654

            //Console.WriteLine("{0:0.000}", d);          // 123456,654

            //Console.WriteLine(d.ToString("#.###"));     // 123456,654


            //dFormated = d.ToString("#.## ## ## ## ##"); 
            //Console.WriteLine(dFormated);               // 123456,65 43 21

            //dFormated = d.ToString("### ###.## ## ## ## ##"); 
            //Console.WriteLine(dFormated);               // 123 456,65 43 21   

            //Console.WriteLine("{0:000 000 000.000 000 000}", d); // 000 123 456,654 321 000


            #region Замечание

            // В зависимости от настроек языкового стандарта программы
            // выводимые символы могут отличаться. 
            Console.WriteLine();
            DateTime date = new DateTime(2025, 09, 28, 01, 30, 59);
            Console.WriteLine(date);                    // 
                                                        // 
                                                        //
            Console.ReadKey();
            Console.WriteLine($"{date:HH:mm}");
            Console.WriteLine($"{date:yyyy-MM-dd}");
            Console.WriteLine($"{date:yy.MM.dd}");
            Console.WriteLine($"{date:dd.MM.yyy}");



            #endregion



        }

        private static void StringInterpolation()
        {
            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2}";

            Console.WriteLine(pattern,
                              firstName,
                              lastName,
                              specialization);

            // Интерполяция строк
            Console.WriteLine($"Имя: {firstName} Фамилия: {lastName} Специализация: {specialization}");


            #region Калькулятор

            Console.ReadKey(); Console.Clear();

            int a = 100;
            int b = 11;
            int c = 111;
            Console.WriteLine($"{a} + {b} = {c}");

            #endregion

            #region База данных v 1.0

            Console.ReadKey(); Console.Clear();


            string name1 = "Агата", lastName1 = "Лебедева";
            string name2 = "Аделаида", lastName2 = "Виноградова";
            string name3 = "Алима", lastName3 = "Попова";
            string name4 = "Катя", lastName4 = "Калинина";
            string name5 = "Рената", lastName5 = "Иванова";

            Console.WriteLine($"{name1} {lastName1}");
            Console.WriteLine($"{name2} {lastName2}");
            Console.WriteLine($"{name3} {lastName3}");
            Console.WriteLine($"{name4} {lastName4}");
            Console.WriteLine($"{name5} {lastName5}");


            #endregion

            #region База данных v 2.0

            Console.ReadKey(); Console.Clear();

            Console.WriteLine($"{name1,10} {lastName1,11}");
            Console.WriteLine($"{name2,10} {lastName2,11}");
            Console.WriteLine($"{name3,10} {lastName3,11}");
            Console.WriteLine($"{name4,10} {lastName4,11}");
            Console.WriteLine($"{name5,10} {lastName5,11}");

            #endregion


        }

        private static void EscapeSequences()
        {

            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;

            #region newPattern

            string newPattern = "Имя: {0} \nФамилия: {1} \nСпециализация: {2} \nВозраст: {3} \nГод рождения: {4}";

            #endregion

            Console.WriteLine(newPattern,
                              firstName,
                              lastName,
                              specialization,
                              age,
                              yearOfBirth);

            Console.ReadKey();


            #region Вывод данных Escape-последовательности

            // \n Новая строка
            // \r Возврат каретки
            // \t Горизонтальная табуляция
            // \' Одиночная кавычка
            // \" Двойная кавычка
            // \\ Обратная косая черта
            // \? Литерал вопросительного знака

            #endregion


        }

        private static void FormattedOutput()
        {
            // Составное форматирование
            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;

            // АлександрПушкинПисатель371799
            Console.WriteLine(firstName + lastName + specialization + age + yearOfBirth);
            Console.ReadKey();


            // Александр Пушкин Писатель 37 1799
            Console.WriteLine(firstName + " " + lastName + " " + specialization + " " + age + " " + yearOfBirth);
            Console.ReadKey();

            // Имя: Александр Фамилия: Пушкин Специализация: Писатель Возраст: 37 Год рождения:1799
            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Специализация: " + specialization + " Возраст: " + age + " Год рождения: " + yearOfBirth);
            Console.ReadKey();

            // Имя: Александр Фамилия: Пушкин Специализация: Писатель Возраст: 37 Год рождения:1799
            Console.WriteLine("Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}",
                               firstName,
                               lastName,
                               specialization,
                               age,
                               yearOfBirth);
            Console.ReadKey();

            // Имя: Александр Фамилия: Пушкин Специализация: Писатель Возраст: 37 Год рождения:1799

            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}";
            Console.WriteLine(pattern,
                              firstName,
                              lastName,
                              specialization,
                              age,
                              yearOfBirth);


            #region переиспользование pattern

            string fName = "Ада";
            string lName = "Лавлейс";
            string profession = "Программист";

            byte years = 37;
            ulong birth = 1815;

            Console.WriteLine(pattern,
                              fName,
                              lName,
                              profession,
                              years,
                              birth);


            #endregion


        }

        private static void StringTypes()
        {
            // Тип данных string используется для хранения строковых констант.
            // Они обрамляются двойными кавычками. 

            string word = "Привет!";
            word = "Привет, мир!";
            Console.WriteLine(word);
        }

        private static void BoolTypes()
        {
        }

        private static void CharTypes()
        {
            // Тип char может содержать один Unicode-символ 
            char VarChar1 = 'a'; Console.WriteLine(VarChar1); // a
            char VarChar2 = 'ю'; Console.WriteLine(VarChar2); // ю
            char VarChar3 = '!'; Console.WriteLine(VarChar3); // !
            char VarChar4 = '&'; Console.WriteLine(VarChar4); // &
            char VarChar5 = '9'; Console.WriteLine(VarChar5); // 9
            char VarChar6 = '§'; Console.WriteLine(VarChar6); // 󠅒󠅒
        }

        private static void FloatPointTypes()
        {
            // Типы с плавающей точкой могут хранить действительные числа с разной точностью.


            // Постоянные числа с плавающей точкой в C# всегда сохраняются как переменные типа double,
            // Для использования типа float требуется в конце добавить символ F или f 
            // Аналогично для типа decimal  требуется в конце добавить символ M или m 
            // Аналогично для типа double добавление в конце символа D или d необязательно 

            // Пример
            float floatVariable = 3.14F;
            double doubleVariable = 3.14;
            decimal decimalVariable = 3.14M;


            // Тип float принимает значения От ±1,5 x 10^(−45) до ±3,4 x 10^38 точность - 7 цифр

            floatVariable = 1.12345678910f;
            Console.WriteLine(floatVariable); // 1.1234567

            // Тип double принимает значения  От от ±5,0 × 10^(−324) до ±1,7 × 10^308 точность - 15 цифр            doubleVariable = 1.1234567898765431d;

            doubleVariable = 1.1234567898765431d;
            Console.WriteLine(doubleVariable); // 1,12345678987654

            // Тип decimal принимает значения от ±1,0 x 10^(-28) до ±7,9228 x 10^28 точность - 28 цифр

            decimalVariable = 1.12345678912345678901234567891234m;
            Console.WriteLine(decimalVariable); // 1,1234567891234567890123456789


        }

        private static void IntegerTypes()
        {


            // Замечание 1 Работает с C# 7.0
            // В дополнение к стандартной десятичной записи, целые числа также могут быть
            // записаны с использованием шестнадцатеричная и двоичная формы записи.
            // Для шестнадцатеричной нужно использовать префикс 0x
            // Для двоичной нужно использовать префикс 0b

            // Пример
            int hexNumber = 0x7C6;          // 0x7C6 - это 1990 в десятичной форме записи
            Console.WriteLine(hexNumber);   // 1990

            int binNumber = 0b11100;        // 0b11100 - это 28 в десятичной форме записи
            Console.WriteLine(binNumber);   // 28


        }

        private static void Variable()
        {
            double asdf1234 = 20.19;

            Console.WriteLine(asdf1234);
            Console.ReadKey();
        }

        private static void Exceptions()
        {
            FileStream file = null;
            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                if (file != null)
                {
                    file.Dispose();
                }
            }
            Console.ReadLine();
            Console.WriteLine("Please input a number");

            string result = Console.ReadLine();
            int number = 0;
            try
            {
                number = int.Parse(result);
            }
            catch (OverflowException)
            {

            }
            catch (FormatException ex)
            {
                Console.WriteLine("A format exception has occured.");
                Console.WriteLine("Informations is below:");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(number);
            Console.ReadLine();
        }

        private static void MyyStack()
        {
            MyStack<int> ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(222);
            ms.Push(777);

            Console.WriteLine(ms.Peek());

            ms.Pop();

            Console.WriteLine(ms.Peek());

            ms.Push(111);
            ms.Push(333);
            ms.Push(999);
            Console.WriteLine(ms.Peek());
            Console.ReadLine();
        }

        private static void EvilInheritance()
        {
            Ishape rect = new Rect() { Height = 2, Width = 5 };
            Ishape square = new Square() { SideLength = 10 };
            Console.WriteLine($"Rect area = {rect.CalcSquare()}");
            Console.WriteLine($"Square area = {square.CalcSquare()}");
            //Rect rect = new Rect { Height = 2, Width = 5 };
            //int rectArea = AreaCalculator.CalcSquare(rect);
            //Console.WriteLine($"Rect area = {rectArea}");
            //Rect square = new Square { Height = 10, Width = 10 };
            //AreaCalculator.CalcSquare(square);
            Console.ReadLine();
        }

        private static void Interfaces()
        {
            List<object> list = new List<object> { 1, 2, 3 };
            IBaseCollection collection = new BaseList(4);
            collection.Add(1);
            collection.AddRange(list);
        }

        private static void Polymorphism()
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }
            Console.ReadLine();
        }

        private static void Inheritance()
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();
            Console.ReadLine();
        }

        private static void BoxingUnboxing()
        {
            int x = 1;
            object obj = x;

            int y = (int)obj;

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)(double)obj1;
            Console.WriteLine(number);
            Console.ReadKey();
        }

        private static void SwapExample()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"Original a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Swapped a = {a}, b = {b}");
            List<int> list = new List<int>();
            AddNumber(list);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a = {a}, b = {b}");
            (b, a) = (a, b);
            Console.WriteLine($"Swapped a = {a}, b = {b}");
        }

        private static void AddNumber(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        private static void calculating()
        {
            if (Calculator.TryDivide(456, 2, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }
            Console.ReadKey();
            Console.WriteLine("Enter a number, please");
            string line = Console.ReadLine();
            bool wasParsed = int.TryParse(line, out int number);
            if (wasParsed)
            {
                Console.WriteLine();
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Failed to parse");
            }
            Console.ReadKey();
        }

        private static void ArrayStartingIndexOne()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] { 5 }, new[] { 1 });
            myArray.SetValue(2020, 1);
            myArray.SetValue(2021, 2);
            myArray.SetValue(2022, 3);
            myArray.SetValue(2023, 4);
            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i < myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
            Console.ReadKey();
        }

        private static void JaggedArray1()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[3];
            jaggedArray[3] = new int[4];
            Console.WriteLine("Enter the number for a jagged array");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Printing the Elements");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void MultidimArrays()
        {
            int[,] r1 = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void StackQueue()
        {
            Queue<int> queque = new Queue<int>();
            queque.Enqueue(1);
            queque.Enqueue(2);
            queque.Enqueue(3);
            queque.Enqueue(4);
            queque.Enqueue(5);

            Console.WriteLine($"Should print out 1: {queque.Peek()}");

            queque.Dequeue();

            Console.WriteLine($"Should print out 2: {queque.Peek()}");

            Console.WriteLine("Iterate over the queue");

            foreach (int x in queque)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine($"Should print out 5: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            Console.WriteLine("Iterate over the stack");

            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }

        private static void Dictionary()
        {
            #region Создать частотный словарь 

            List<int> list = new List<int>();

            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(r.Next(20));
            }

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int e in list)
            {
                if (!dictionary.ContainsKey(e))
                {
                    dictionary.Add(e, 0);
                }

                dictionary[e]++;
            }

            foreach (KeyValuePair<int, int> e in dictionary)
            {
                Console.WriteLine($"{e.Key,3} встречается {e.Value,4} р.");
            }

            #endregion
            Dictionary<int, string> people = new Dictionary<int, string>
            {
                { 1, "John" },
                { 2, "Bob" },
                { 3, "Alice" }
            };

            people = new Dictionary<int, string>()
                            {
                                { 1, "John" },
                                { 2, "Bob" },
                                { 3, "Alice" },
                            };
            string name = people[1];
            Console.WriteLine(name);

            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (int x in keys)
            {
                Console.WriteLine(x);
            }
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (string x in values)
            {
                Console.WriteLine(x);
            }

            foreach (KeyValuePair<int, string> pair in people)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
            Console.WriteLine($"Count = {people.Count}");

            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("John");
            Console.WriteLine($"{containsKey} {containsValue}");

            people.Remove(1);

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val = {val}");

            }
            else
            {
                Console.WriteLine("Failed to get");
            }
            people.Clear();
            Console.ReadKey();
        }

        private static void ListDemo()
        {
            List<int> intList = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                777
            };

            int[] intArray = { -1, -2, -3 };
            intList.AddRange(intArray);

            if (intList.Remove(1)) // первую встречную удаляет
            {
                //do
            }
            else { }

            intList.RemoveAt(0);
            intList.Reverse();

            bool contains = intList.Contains(-1);
            int min = intList.Min();
            int max = intList.Max();
            Console.WriteLine($"Min = {min}. Max = {max}");

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(1);

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();

            foreach (int x in intList)
            {
                Console.Write($"{x} ");
            }
            Console.ReadKey();
        }

        private static void ArrayType()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //работает только с сортированным массивом
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);
            Console.WriteLine();
            int[] copy = new int[10];

            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);
            Array.Reverse(copy);
            foreach (int t in copy)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine();

            Array.Sort(copy);
            foreach (int t in copy)
            {
                Console.WriteLine(t);
            }
            Array.Clear(copy, 0, copy.Length);
            Console.WriteLine();

            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a4 = { 0, 1, 2, 3, 4 };

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(777, 0);
            Console.WriteLine(myArray2.GetValue(0));

            Console.ReadKey();
        }

        private static void Factorial()
        {
            Console.WriteLine("Enter n > 0");
            int n = int.Parse(Console.ReadLine());
            ulong factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= (ulong)i;
            }
            Console.WriteLine(factorial.ToString());
            Console.ReadKey();
        }

        private static void Average()
        {
            int[] numbers = new int[10];

            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;
                inputCount++;
                if (number == 0)
                {
                    break;
                }
            }
            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }
            double average = (double)sum / count;
            Console.WriteLine($"average = {average}");
            Console.ReadKey();
        }

        private static void Fibonacci()
        {
            Console.WriteLine("Enter the number of Fibonacci numbers you want to generate");
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];

            int a0 = 0;
            int a1 = 1;

            fibonacci[0] = a0;
            fibonacci[1] = a1;

            for (int i = 2; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;

                a0 = a1;
                a1 = a;
            }
            foreach (int cur in fibonacci)
            {
                Console.WriteLine(cur);
            }
            Console.ReadKey();
        }

        private static void SwitchCase()
        {
            Console.WriteLine("Введите порядковый номер месяца");
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";

                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);
            Console.ReadLine();
            Console.WriteLine("Введите код юбилея");
            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            name = weddingYears switch
            {
                5 => "Деревенная свадьба",
                10 => "Оловянная свадьба",
                15 => "Хрустальная свадьба",
                20 => "Фарфоровая свадьба",
                25 => "Серебряная свадьба",
                30 => "Жемчужная свадьба",
                _ => "Не знаем такого юбилея!",
            };
            Console.WriteLine(name);
            Console.ReadKey();
        }

        private static void BreakContinue()
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in a)
            {
                //if (n%2==0)
                //{
                //    Console.WriteLine(n);
                //}
                if (n % 2 != 0)
                {
                    continue;
                }

                Console.WriteLine(n);
            }
            int[] numbers1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine($"Number = {numbers1[i]}");
                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers1[i] == j)
                    {
                        break;
                    }

                    Console.Write($"{letters[j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18
                                             -1,-2,-3,-4,-5,-6,-7,-8,-9,-10,-11,-12,-13,-14,-15,-16,-17,-18};
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }

        private static void WhileDoWhile()
        {
            //int age = 0;
            //while(age < 18)
            //{
            //    Console.WriteLine("First while loop");
            //    Console.WriteLine("What is your age?");
            //    age = int.Parse(Console.ReadLine());
            //}

            //do
            //{
            //    Console.WriteLine("Do\\While");
            //    Console.WriteLine("What is your age?");
            //    age = int.Parse(Console.ReadLine());
            //}
            //while (age < 18);
            //
            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
            Console.ReadKey();
        }

        private static void NestedFor()
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18
                                             -1,-2,-3,-4,-5,-6,-7,-8,-9,-10,-11,-12,-13,-14,-15,-16,-17,-18};
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }

                }
            }
            Console.ReadKey();
        }

        private static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
            Console.ReadKey();
        }

        private static void HomeworkGetMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // 1 - st
            //int max = a;
            // if (b>a)
            //    max = b;

            //2nd
            //int max;
            //if (a>b)
            //    max = a;
            //else
            //    max = b;

            //3rd
            int max = a > b ? a : b;

            Console.WriteLine($"Max={max}");
            Console.ReadKey();
        }

        private static void DateTimeIntro()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");
            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt.ToString());
            TimeSpan ts = now - dt;
            //ts = now.Subtract(dt);
            Console.WriteLine(ts.Days.ToString());
            Console.ReadKey();
        }

        private static void IntroToArrays()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 8, -2, 5, 10 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 8;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length - 1]);
            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine(first);
            Console.WriteLine(last);

            //impossible
            //s1[0] = 'z';
            Console.ReadKey();
        }

        private static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.5));
            Console.ReadKey();
        }

        private static void Comment()
        {
            // a single-line comment
            /*
             * 
             * 
             * 
             * 
             * 
             */
            //describe hows and whys! not whats!
            int a = 1;

            //increment a by 1 - bad comment, this code is self-evident
            //we need to tweak the index to match the expected outcome
            a++;
        }

        private static void CastingAndParsing()
        {
            byte t = 3; // 0000 0011
            int i = t; // 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i;
            float f = i;
            Console.WriteLine(f);
            t = (byte)i;
            Console.WriteLine(t);
            i = (int)f;
            Console.WriteLine(i);
            f = 3.3f;
            i = (int)f;
            Console.WriteLine(i);
            string str = "1";
            i = int.Parse(str);
            Console.WriteLine(i);
            int x = 5;
            double result = (double)x / 2;
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void ConsoleBasics()
        {
            //Console.WriteLine("Hi, please tell me your name");
            //string name = Console.ReadLine();
            //string sentence =  $"Your name is {name}";
            //Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell me your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            string sentence = $"Your age is {age}";
            Console.WriteLine(sentence);
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("New style ");
            Console.Write("New style\n");
            Console.ReadKey();
        }

        private static void ComparingStrings()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            Console.WriteLine();
            Console.WriteLine("Equals:\n");
            string s1 = "Strasse";
            string s2 = "Straße";
            areEqual = string.Equals(s1, s2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
            Console.ReadKey();
        }

        private static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1} years old.", name, age);
            Console.WriteLine(str1);
            string str2 = $"My name is {name} and I'm {age} years old.";
            Console.WriteLine(str2);
            string str3 = "My name is \nMarat";
            Console.WriteLine(str3);
            string str4 = "I'm \t first";
            Console.WriteLine(str4);
            str3 = $"My name is {Environment.NewLine}John";
            Console.WriteLine(str3);
            string str5 = "I'm John and I'm a \"good\" programmer";
            Console.WriteLine(str5);
            string str6 = "C:\\Files\\file.txt";
            string str7 = @"C:\Files\file.txt";
            Console.WriteLine(str6);
            Console.WriteLine(str7);
            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            string result3 = string.Format("{0:f}", answer);
            string result4 = string.Format("{0:f4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double money = 22.2;
            result = string.Format("{0:C}", money);
            Console.WriteLine(result);
            Console.WriteLine(money.ToString("C2"));
            result = $"{money:C2}";
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");
            string str = sb.ToString();
            Console.WriteLine(str);
            Console.ReadKey();
        }

        private static void StringModifications()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "Marat");
            Console.WriteLine(nameConcat);
            nameConcat = string.Join(" ", "My", "name", "is", "Marat");
            Console.WriteLine(nameConcat);
            nameConcat = "My " + "name " + "is " + "Marat";
            Console.WriteLine(nameConcat);
            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);
            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);
            string replaced = nameConcat.Replace('M', 'T');
            Console.WriteLine(replaced);
            string data = "12;28;34;25;64";
            string[] spliData = data.Split(';');
            string first = spliData[0];
            Console.WriteLine(first);
            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);
            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);
            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);
            string john = "   My name is John   ";
            Console.WriteLine(john.Trim());
            Console.ReadKey();
        }

        private static void StringEmptiness()
        {
            string str = string.Empty;
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " Z";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool IsNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(IsNullOrEmpty);
            Console.WriteLine(" ");
            Console.WriteLine("IsNullOrWhiteSpace");

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace);
            Console.ReadKey();
        }

        private static void QueryingString()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsZ = name.Contains('Z');
            Console.WriteLine(containsA);
            Console.WriteLine(containsZ);
            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);
            bool startswithAbra = name.StartsWith("abra");
            Console.WriteLine(startswithAbra);
            //int indexOfA = name.IndexOf('a');
            //Console.WriteLine(indexOfA);
            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);
            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);
            Console.WriteLine(name.Length); //кол-во символов
            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 7);
            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFromTo);
            Console.ReadKey();
        }

        private static void StaticAndInstanceMembers()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsZ = name.Contains('Z');
            Console.WriteLine(containsA);
            Console.WriteLine(containsZ);
            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);
            Console.WriteLine(int.MinValue);
            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.ReadKey();
        }

        private static void ComparisonOperations()
        {
            int x = 1;
            int y = 2;
            bool areEqual = x == y;
            Console.WriteLine(areEqual);
            bool result = x > y;
            Console.WriteLine(result);
            result = x >= y;
            Console.WriteLine(result);
            result = x < y;
            Console.WriteLine(result);
            result = x <= y;
            Console.WriteLine(result);
            result = x != y;
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void MathOperations()
        {
            int x = 1;
            int y = 8;
            int z = x + y;
            int t = x - y;
            int a = z + t - x - y;
            int b = a * a * a;
            Console.WriteLine(a);
            Console.WriteLine(t);
            Console.WriteLine(z);
            int tt = z * 5;
            Console.WriteLine(tt);
            a = 4 % 2;
            b = 5 % 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        private static void OverFlow()
        {
            checked
            {
                ulong x = ulong.MaxValue;
                Console.WriteLine(x);
                //x++; //переполнение
                Console.WriteLine(x);
                x--;
                Console.WriteLine(x);
                Console.ReadKey();

            }
        }

        private static void VariablesScope()
        {
            int a = 1;
            {
                int b = 2;
                {
                    int c = 3;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            Console.ReadKey();
        }

        private static void Literals()
        {
            int x = 0b1010;
            int y = 0b1000;
            int z = 0b1001_1000;
            int t = 0b10011000;
            int o = 0xFFF;
            int i = 0xABC123;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(t);
            Console.WriteLine(o);
            Console.WriteLine(i);
            Console.WriteLine(4.5e2);
            Console.WriteLine(3.0E-1);
            Console.WriteLine('\x77');
            Console.WriteLine('\x5A');
            Console.WriteLine('\u0420');
            Console.ReadKey();
        }

        private static void Variables()
        {
            int x = -1;
            Dictionary<int, string> dict = new Dictionary<int, string>();
            Dictionary<int, string> dictt = new Dictionary<int, string>();
            object obj1 = 1;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}