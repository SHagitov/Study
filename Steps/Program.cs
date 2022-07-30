using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathLogicalOperations();
            Console.ReadLine();
        }
        static void MathLogicalOperations()
        {
            int x1 = 30, x2 = 150,  // Координаты вершин прямоугольника
                y1 = 20, y2 = 90;

            int pA = 50, pB = 110;  // Координаты точки

            // Проверка условия принадлежности точки ограниченной области
            bool check = ((pA >= x1) && (pA <= x2)) && ((pB >= y1) && (pB <= y2));
            Console.WriteLine(check);
            Console.ReadKey();
            #region _
            Console.ReadKey();

            pA = 50; pB = 110;
            check = ((pA >= x1) && (pA <= x2)) && ((pB >= y1) && (pB <= y2));
            Console.WriteLine(check);

            #endregion


        }
        static void LogicalOperations()
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
        static void OperationsPriority()
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
        static void IncrementAndDecrement()
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
        static void ArithmeticOperations()
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
        static void ConvertTo()
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
        static void ParseConversion()
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
        static void ImplicitTypeСonversion()
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
        static void ExplicitTypeConversion()
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

            int q = (int)((byte)d);

        }
        static void DataTypeConversion()
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
        static void NumbersAfterPoint()
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
            var date = new DateTime(2025, 09, 28, 01, 30, 59);
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
        static void StringInterpolation()
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
        static void EscapeSequences()
        {

            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;


            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}";

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
        static void FormattedOutput()
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
        static void StringTypes()
        {
            // Тип данных string используется для хранения строковых констант.
            // Они обрамляются двойными кавычками. 

            string word = "Привет!";
            word = "Привет, мир!";
            Console.WriteLine(word);
        }
        static void BoolTypes()
        {
            // Тип bool может хранить логическое значение, которое принимает значение 
            // правда или ложь. 
            // Эти значения указываются с ключевыми словами true и false

            bool flag = true;   // переменной flag присвоить истину
            flag = false;       // переменной flag присвоить ложь
        }
        static void CharTypes()
        {
            // Тип char может содержать один Unicode-символ 
            char VarChar1 = 'a'; Console.WriteLine(VarChar1); // a
            char VarChar2 = 'ю'; Console.WriteLine(VarChar2); // ю
            char VarChar3 = '!'; Console.WriteLine(VarChar3); // !
            char VarChar4 = '&'; Console.WriteLine(VarChar4); // &
            char VarChar5 = '9'; Console.WriteLine(VarChar5); // 9
            char VarChar6 = '§'; Console.WriteLine(VarChar6); // 󠅒󠅒
        }
        static void FloatPointTypes()
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
        static void IntegerTypes()
        {
            // Существует четыре типа целых чисел со знаком, 
            // которые можно использовать в зависимости от того,
            // насколько большое(или маленькое) число нужно хранить

            // Целые числа со знаком
            sbyte int8 = 2;   // от -128 дo +127
            short int16 = 1;  // от -32768 дo +32767
            int int32 = 0;    // от -2^31 дo +2^31-1 >>> от -2 147 483 648 до +2 147 483 647
            long int64 = -1;  // от -2^63 дo +2^63-1 >>> от -9 223 372 036 854 775 808 до +9 223 372 036 854 775 807

            // Типы без знака можно использовать, если нужно хранить только положительные значения

            // Целые числа без знака
            byte uInt8 = 0;     // от 0 дo 255
            ushort uInt16 = 1;  // от 0 дo 65535
            uint uInt32 = 2;    // от 0 дo 2^32-1 >>> от 0 до 4 294 967 296
            ulong uInt64 = 3;   // от 0 дo 2^64-1 >>> от 0 до 18 446 744 073 709 551 616


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

            // Замечание 2 Работает с C# 7.0
            // Добавлено использование разделителей цифр (_) для улучшения читабельности длинных чисел.
            // Этот разделитель цифр может появляться в любом месте числа
            int number = 1000000000;
            int _number = 1_000_000_______000;


        }
        static void Variable()
        {
            // Переменная - это "контейнер" для хранения данных

            //            ────────────────┐             
            // ┌──────────┐               │             
            // │   6174   │ Значение      │ Переменная  
            // └──────────┘               │             
            //      box     Идентификатор |             
            //            ────────────────┘             


            // Переменные используются для хранения данных в памяти во 
            // время выполнения программы

            // Переменная объявляется следующим образом:
            // Ключевое слово var за которым следует идетификатор переменной,
            // далее оператор присваивания и значение переменной, 
            // инструкция заканчивается точкой с запятой
            // 
            // Примеры
            var a = 28;
            var b = 84.5;
            var c = "Первая программа написанная на языке Visual C#";

            // Замечание
            // Имя (идентификатор переменной) может содержать
            // латинские строчные и прописные буквы
            // символ нижнего подчеркивание - "_"
            // цифры,
            // ! но цифра не может быть на первом месте

            // Пример того, как не нужно писать код
            var g = 1;
            var ab = 2;
            var qwerty = "Я программист!";
            var asdf1234 = 20.19;
            var zx_cv = 28;
            var ___gg777_oy19___ = "Сегодня отличный день";
            //var 799abcde = "упс..."; //- ошибка 

            // ! Важно 
            // Привыкать к осмысленному именованию переменных

            var age = 28;
            var weight = 84.5;
            var title = "Первая программа написанная на языке Visual C#";
            var month = "March";
            var schoolName = "SkillBox";
            var csharpCreater = "Anders Hejlsberg";

            Console.WriteLine(asdf1234);
            Console.ReadKey();
        }
        static void Exceptions()
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
                    file.Dispose();
            }
            Console.ReadLine();
            Console.WriteLine("Please input a number");

            string result = Console.ReadLine();
            int number = 0;
            try
            {
                number = int.Parse(result);
            }
            catch (OverflowException ex)
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

        static void MyyStack()
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
        static void EvilInheritance()
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
        static void Interfaces()
        {
            List<object> list = new List<object> { 1, 2, 3 };
            IBaseCollection collection = new BaseList(4);
            collection.Add(1);
            collection.AddRange(list);
        }
        static void Polymorphism()
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
        static void Inheritance()
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();
            Console.ReadLine();
        }
        static void BoxingUnboxing()
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
        static void SwapExample()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"Original a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Swapped a = {a}, b = {b}");
            var list = new List<int>();
            AddNumber(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a = {a}, b = {b}");
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Swapped a = {a}, b = {b}");
        }
        static void AddNumber(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        static void calculating()
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
            bool wasParsed = int.TryParse(line, out var number);
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
        static void ArrayStartingIndexOne()
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
        static void JaggedArray()
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
        static void MultidimArrays()
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
        static void StackQueue()
        {
            var queque = new Queue<int>();
            queque.Enqueue(1);
            queque.Enqueue(2);
            queque.Enqueue(3);
            queque.Enqueue(4);
            queque.Enqueue(5);

            Console.WriteLine($"Should print out 1: {queque.Peek()}");

            queque.Dequeue();

            Console.WriteLine($"Should print out 2: {queque.Peek()}");

            Console.WriteLine("Iterate over the queue");

            foreach (var x in queque)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine($"Should print out 5: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            Console.WriteLine("Iterate over the stack");

            foreach (var x in stack)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
        static void Dictionary()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            people = new Dictionary<int, string>()
                            {
                                { 1, "John" },
                                { 2, "Bob" },
                                { 3, "Alice" },
                            };
            string name = people[1];
            Console.WriteLine(name);

            var keys = people.Keys;
            foreach (var x in keys)
            {
                Console.WriteLine(x);
            }
            var values = people.Values;
            foreach (var x in values)
            {
                Console.WriteLine(x);
            }

            foreach (var pair in people)
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
        static void ListDemo()
        {
            var intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            intList.Add(777);

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

            foreach (var x in intList)
            {
                Console.Write($"{x} ");
            }
            Console.ReadKey();
        }
        static void ArrayType()
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
            foreach (var t in copy)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine();

            Array.Sort(copy);
            foreach (var t in copy)
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
        static void Factorial()
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
        static void Average()
        {
            int[] numbers = new int[10];

            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;
                inputCount++;
                if (number == 0)
                    break;
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
        static void Fibonacci()
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
        static void SwitchCase()
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

            switch (weddingYears)
            {
                case 5:
                    name = "Деревенная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебряная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаем такого юбилея!";
                    break;
            }
            Console.WriteLine(name);
            Console.ReadKey();
        }
        static void BreakContinue()
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in a)
            {
                //if (n%2==0)
                //{
                //    Console.WriteLine(n);
                //}
                if (n % 2 != 0)
                    continue;
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
                        break;
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
                        break;

                }
            }
            Console.ReadKey();
        }
        static void WhileDoWhile()
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
        static void NestedFor()
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
        static void ForForeach()
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
                    Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
            Console.ReadKey();
        }
        static void HomeworkGetMax()
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
        static void DateTimeIntro()
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
        static void IntroToArrays()
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
        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.5));
            Console.ReadKey();
        }
        static void Comment()
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
        static void CastingAndParsing()
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
        static void ConsoleBasics()
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
        static void ComparingStrings()
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
        static void StringFormat()
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
        static void StringBuilderDemo()
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
        static void StringModifications()
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
        static void StringEmptiness()
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
        static void QueryingString()
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
        static void StaticAndInstanceMembers()
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
        static void ComparisonOperations()
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
        static void MathOperations()
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
        static void OverFlow()
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
        static void VariablesScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;
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
        static void Literals()
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
        static void Variables()
        {
            int x = -1;
            int y;
            y = 8;
            Int32 x1 = -1;
            //uint z = -1;
            float f = 1.1f;
            double d = 2.3;
            int x8 = 0;
            int x88 = new int();
            var a = 1;
            var z = 1.2;
            Dictionary<int, string> dict = new Dictionary<int, string>();
            var dictt = new Dictionary<int, string>();
            decimal money = 3.0m;
            char character = 'A';
            string name = "John";
            bool canMove = true;
            bool canPlay = false;
            object obj1 = 1;
            char @char = 'Z';
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}