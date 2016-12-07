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

    }
}
