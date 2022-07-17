using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparisonOperations();
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
        }
    }
}