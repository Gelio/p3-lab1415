using System;
using System.Collections;
namespace Lab8
{
    /// <summary>
    /// Interfejs klas modyfikujących sekwencje
    /// </summary>
    public interface IModifier
    {
        /// <summary>
        /// Nazwa modyfikatora
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Metoda modyfikuje kolekcje
        /// </summary>
        /// <param name="sequence">Sekwencja do modyfikacji</param>
        /// <returns>Zmodyfikowana sekwencja</returns>
        IEnumerable Modify(IEnumerable sequence);
    }

    class FirstN : IModifier
    {
        private int n;
        public string Name
        {
            get
            {
                return "FirstN";
            }
        }

        public FirstN(int _n)
        {
            n = _n;
        }

        public IEnumerable Modify(IEnumerable sequence)
        {
            int itemsLeft = n;
            foreach (int x in sequence)
            {
                if (itemsLeft <= 0)
                    yield break;

                itemsLeft--;
                yield return x;
            }
        }
    }

    class LinearTransform : IModifier
    {
        private int a;
        private int b;
        public string Name
        {
            get
            {
                return "LinearTransform";
            }
        }

        public LinearTransform(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public IEnumerable Modify(IEnumerable sequence)
        {
            foreach (int x in sequence)
                yield return (a * x + b);
        }
    }

    class Unique : IModifier
    {
        public string Name
        {
            get
            {
                return "Unique";
            }
        }

        public IEnumerable Modify(IEnumerable sequence)
        {
            dynamic lastItem = null;
            foreach (dynamic item in sequence)
            {
                if (item == lastItem)
                    continue;

                lastItem = item;
                yield return item;
            }
        }
    }

    class Prime : IModifier
    {
        public string Name
        {
            get
            {
                return "Prime";
            }
        }

        public IEnumerable Modify(IEnumerable sequence)
        {
            foreach (int x in sequence)
            {
                if (Prime.isPrime(x))
                    yield return x;
            }
        }

        public static bool isPrime(int number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }

    class LocalMax : IModifier
    {
        public string Name
        {
            get
            {
                return "LocalMax";
            }
        }

        public IEnumerable Modify(IEnumerable sequence)
        {
            int? previous = null;
            bool isRising = true;
            foreach (int x in sequence)
            {
                if (previous.HasValue && previous > x && isRising)
                    yield return previous;
                isRising = previous.HasValue ? x >= previous : true;
                previous = x;
            }
            if (isRising)
                yield return previous;
        }
    }

    class ComposedModifier : IModifier
    {
        public string Name
        {
            get
            {
                return "ComposedModifier";
            }
        }

        IModifier[] modifiers;
        public ComposedModifier(IModifier[] _modifiers)
        {
            modifiers = _modifiers;
        }

        public IEnumerable Modify(IEnumerable sequence)
        {
            IEnumerable outputSequence = sequence;
            for (int i = 0; i < modifiers.Length; i++)
                outputSequence = modifiers[i].Modify(outputSequence);

            return outputSequence;
        }
    }
}
