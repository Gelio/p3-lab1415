using System;

namespace lab10
{

    // klasa wielomianow
    class Pol
    {
        private double[] a;

        public Pol(double[] _a)
        {
            a = (double[])_a.Clone();
        }

        public Pol Diff1()
        {
            if (a.Length == 1)
                return new Pol(new double[1] { 0 });

            int derivativeElements = a.Length - 1;
            double[] coefficients = new double[derivativeElements];
            for (int i = derivativeElements; i > 0; i--)
                coefficients[i-1] = a[i] * i;
            return new Pol(coefficients);
        }

        public Pol Diff2()
        {
            Pol derivative = Diff1();
            return derivative.Diff1();
        }

        public override string ToString()
        {
            string s = "";
            for (int i = a.Length-1; i > 0; --i)
                s += a[i] + "*x^" + i + " + ";
            return s + a[0];
        }

        public double Horner(double x)
        {
            double result = a[a.Length - 1];
            for (int i = a.Length - 2; i >= 0; i--)
                result = result * x + a[i];
            return result;
        }

        public static Pol operator +(Pol p1, Pol p2)
        {
            int deg1 = p1.a.Length,
                deg2 = p2.a.Length;
            double[] coefficients = new double[Math.Max(deg1, deg2)];
            int i;
            for (i = 0; i < Math.Min(deg1, deg2); i++)
                coefficients[i] = p1.a[i] + p2.a[i];
            for (; i < deg1; i++)
                coefficients[i] = p1.a[i];
            for (; i < deg2; i++)
                coefficients[i] = p2.a[i];

            return new Pol(coefficients);
        }
    }
}
