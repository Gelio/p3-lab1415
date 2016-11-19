using System;
using System.Collections;

namespace Lab8
{
    class Naturals : IEnumerable
    {
        private int nextNumber;

        public Naturals(int _nextNumber = 0)
        {
            nextNumber = _nextNumber;
        }
        public IEnumerator GetEnumerator()
        {
            while (true)
                yield return nextNumber++;
        }
    }

    class RandomNumbers : IEnumerable
    {
        private int maxNumber;
        private Random numberGenerator;

        public RandomNumbers(int seed, int _maxNumber)
        {
            numberGenerator = new Random(seed);
            maxNumber = _maxNumber;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
                yield return numberGenerator.Next(maxNumber);
        }
    }

    class Tribonacci : IEnumerable
    {
        private int a;
        private int b;
        private int c;

        public Tribonacci()
        {
            a = b = 0;
            c = 1;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                int next = a + b + c;
                a = b;
                b = c;
                c = next;
                yield return next;
            }
        }
    }

    class Catalan : IEnumerable
    {
        private int cn;
        private int n;

        public Catalan()
        {
            cn = 1;
            n = 0;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                yield return cn;
                cn = cn * 2 * (2 * n + 1) / (n + 2);
                n = n + 1;
            }
        }
    }

    class Polynomial : IEnumerable
    {
        private int[] coefficients;
        private IEnumerator x;

        public Polynomial(int[] _coefficients)
        {
            coefficients = _coefficients;
            Naturals naturalNumbers = new Naturals();
            x = naturalNumbers.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                x.MoveNext();
                int y = 0;
                for (int i = coefficients.Length-1; i >= 0; --i)
                    y = y * (int)x.Current + coefficients[i];

                yield return y;
            }
        }
    }
}
