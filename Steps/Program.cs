using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayStartingIndexOne();
        }
        static void ArrayStartingIndexOne()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] {5}, new[] {1});
            myArray.SetValue(2020, 1);
            myArray.SetValue(2021, 2);
            myArray.SetValue(2022, 3);
            myArray.SetValue(2023, 4);
            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}");
            
            for(int i = myArray.GetLowerBound(0); i < myArray.GetUpperBound(0); i++)
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
            int[,] r1 = new int[3,3] { { 1,2,3}, { 2,3,4 }, { 3,4,5 } };
            int[,] r2 = { { 1,2,3}, {4,5,6 } };
            for(int i = 0; i < r2.GetLength(0); i++)
            {
                for(int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i,j]} ");
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

            foreach(var x in stack)
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
            foreach(var x in keys)
            {
                Console.WriteLine(x);
            }
            var values = people.Values;
            foreach(var x in values)
            {
                Console.WriteLine(x);
            }

            foreach(var pair in people)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
            Console.WriteLine($"Count = {people.Count}");

            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("John");
            Console.WriteLine($"{containsKey} {containsValue}");

            people.Remove(1);

            if(people.TryGetValue(2, out string val))
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
            var intList = new List<int>() {1,2,3,4,5,6,7,8};
            intList.Add(777);

            int[] intArray = {-1,-2,-3};
            intList.AddRange(intArray);
            
            if(intList.Remove(1)) // первую встречную удаляет
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

            foreach(var x in intList)
            {
                Console.Write($"{x} ");
            }    
            Console.ReadKey();
        }
        static void ArrayType()
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9};
            //работает только с сортированным массивом
            int index = Array.BinarySearch(numbers,7);
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

            int[] a3 = new int[5] {1,2,3,4,5};

            int[] a4 = {0,1,2,3,4};

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(777,0);
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
            while(inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;
                inputCount++;
                if(number == 0)
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

            for(int i=2; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;

                a0 = a1;
                a1 = a;
            }
            foreach(int cur in fibonacci)
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
            switch(month)
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
            int[] a = {0,1,2,3,4,5,6,7,8,9,10};
            foreach(int n in a)
            {
                //if (n%2==0)
                //{
                //    Console.WriteLine(n);
                //}
                if (n%2!=0)
                    continue;
                Console.WriteLine(n);
            }
            int[] numbers1 = {0,1,2,3,4,5,6,7,8,9};
            char[] letters = {'a','b','c','d','e','f','g','h','i','j'};

            for (int i = 0; i < numbers1.Length; i++)
            { 
                Console.WriteLine($"Number = {numbers1[i]}");
                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers1[i]==j)
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

                    if (atI+atJ == 0)
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
            int[] numbers = {1,2,3,4,5};
            int i = 0;
            while(i < numbers.Length)
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

                    if (atI+atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }

                }
            }
            Console.ReadKey();
        }
        static void ForForeach()
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = numbers.Length-1; i>=0; i--)
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
            foreach(int val in numbers)
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
            DateTime dt = new DateTime(2016,2,28);
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

            int[] a3 = new int[5] {1,8,-2,5,10};

            int[] a4 = {1,2,3,4,5};

            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 8;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length-1]);
            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length-1];
            Console.WriteLine(first);
            Console.WriteLine(last);

            //impossible
            //s1[0] = 'z';
            Console.ReadKey();
        }
        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2,3));
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
            string str1 = string.Format("My name is {0} and I'm {1} years old.",name,age);
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
            string result2 = string.Format("{0:d4}",answer);
            string result3 = string.Format("{0:f}",answer);
            string result4 = string.Format("{0:f4}",answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double money = 22.2;
            result = string.Format("{0:C}",money);
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
            string nameConcat = string.Concat("My ","name ","is ","Marat");
            Console.WriteLine(nameConcat);
            nameConcat = string.Join(" ","My","name","is","Marat");
            Console.WriteLine(nameConcat);
            nameConcat = "My " + "name " + "is " + "Marat";
            Console.WriteLine(nameConcat);
            nameConcat = nameConcat.Insert(0,"By the way, ");
            Console.WriteLine(nameConcat);
            nameConcat = nameConcat.Remove(0,1);
            Console.WriteLine(nameConcat);
            string replaced = nameConcat.Replace('M','T');
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
            string substrFromTo = name.Substring(0,7);
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
            string abc = string.Concat("a","b","c");
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
            int b = a*a*a;
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
                uint x = uint.MaxValue;
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