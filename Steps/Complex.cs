using System;

namespace Steps
{
    public class Complex
    {
        public int A { get; set; }
        public int B { get; set; }

        public override string ToString()
        {
            return $"{A} + {B}i";
        }

        #region  



        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex() { A = x.A + y.B, B = x.B + y.B };
        }

        public static bool operator >(Complex x, Complex y)
        {
            double m1 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);
            double m2 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);

            return m1 > m2;
        }

        public static bool operator <(Complex x, Complex y)
        {
            double m1 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);
            double m2 = Math.Pow(x.A, 2) + Math.Pow(x.B, 2);

            return m1 > m2;
        }

        #endregion

    }
}
