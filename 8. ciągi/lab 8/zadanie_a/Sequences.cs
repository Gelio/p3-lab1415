using System;
using System.Collections;

namespace Lab8
{
    class Naturals : IEnumerable
    {
        private int startingNumber;

        public Naturals(int _startingNumber = 0)
        {
            startingNumber= _startingNumber;
        }
        public IEnumerator GetEnumerator()
        {
            int nextNumber = startingNumber;
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

        public Polynomial(int[] _coefficients)
        {
            coefficients = _coefficients;
        }

        public IEnumerator GetEnumerator()
        {
            Naturals naturalNumbers = new Naturals();
            foreach (int x in naturalNumbers)
            {
                int y = 0;
                for (int i = coefficients.Length - 1; i >= 0; --i)
                    y = y * x + coefficients[i];

                yield return y;
            }
        }
    }

    class MultiplicationTable : IEnumerable
    {
        private int n;
        public MultiplicationTable(int _n = 5)
        {
            n = _n;
        }

        public IEnumerator GetEnumerator()
        {
            IEnumerable baseNumbers = new FirstN(n).Modify(new Naturals(1));
            for (int i=1; i <= n; i++)
            {
                yield return new LinearTransform(i, 0).Modify(baseNumbers);
            }
        }
    }
}
