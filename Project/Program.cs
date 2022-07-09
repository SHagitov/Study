using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, lower, larger;
            int tryCount = 5;
            Random rand = new Random();
            int userInput;
            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            larger = rand.Next(number + 1, number + 10);
            Console.WriteLine("Мы загадали число от 0 до 100, оно больше чем " + lower + ", но меньше чем " + larger);
            Console.WriteLine("Что это за число?");
            while (tryCount-- > 0)
            {
                Console.Write("Это число: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("Вы правы! Это было число - " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно, попробуйте ещё раз.");
                }
            }
            if (tryCount < 0)
            {
                Console.WriteLine("Вы проиграли, увы, но повезет в следующий раз. Это было число - " + number);
            }
            Console.ReadKey();
        }
    }
}
