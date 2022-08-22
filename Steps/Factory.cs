using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    public class Factory
    {
        private int count;
        static private Random random;

        static Factory()
        {
            random = new Random();
        }

        public Factory(int Count)
        {
            this.count = Count;
            Car.CreateCar += Car_CreateCar;
        }

        private void Car_CreateCar(string Msg, int Number)
        {
            Console.WriteLine($"Фабрика: {Msg}. Итог {Number}");
        }

        public List<Car> ToProduce()
        {
            List<Car> cars = new List<Car>();

            for (int i = 0; i < this.count; i++)
            {
                cars.Add(new Car(
                    Mark: $"Марка_{random.Next(1, 6)}",
                    Model: $"Марка_{random.Next(1, 6)}",
                    Engine: random.Next(1, 3) + Math.Round(random.NextDouble(), 1)
                    ));
            }
            return cars;
        }


    }
}
