using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    public class Calculator
    {
        public bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
                return false;
            result = divisible / divisor;
            return true;
        }
        public double AverageT(params int[] numbers)
        {
            int sum = 0;
            foreach (int x in numbers)
            {
                sum += x;
            }
            return (double)sum / numbers.Length;
        }
        public double Average(int[] numbers)
        {
            int sum = 0;
            foreach (int x in numbers)
            {
                sum += x;
            }
            return (double)sum / numbers.Length;
        }
        public double CalculateTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;
            return (double)Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }
        public double CalculateTriangleSquare(double a, double h)
        {
            return 0.5 * a * h;
        }
    }
}
