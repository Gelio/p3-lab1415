using System;

namespace lab10
{

    // klasa wielomianow
    class Pol
    {
        private double[] a;

        // uzupelnic

        public override string ToString()
        {
            string s = "";
            for (int i = a.Length-1; i > 0; --i)
                s += a[i] + "*x^" + i + " + ";
            return s + a[0];
        }

    }
}
