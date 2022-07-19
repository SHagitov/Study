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
            DateTimeIntro();
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