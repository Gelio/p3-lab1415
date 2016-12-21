using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Lab12
{
    class SlowString
    {
        string Value;
        bool Debug;
        int Delay;

        public SlowString(string value, bool debug = false, int delay = 30)
        {
            Value = value;
            Debug = debug;
            Delay = delay;
        }

        async public Task<bool> Equal(SlowString other)
        {
            if (Debug)
                Console.WriteLine("Początek Equal");
            bool result = await Task.Run<bool>(() =>
            {
                Thread.Sleep(Delay);
                return other.Value.Equals(Value);
            });
            if (Debug)
                Console.WriteLine("Koniec Equal");
            return result;
        }

        async public Task<bool> GreaterThan(SlowString other)
        {
            if (Debug)
                Console.WriteLine("Poczatek GreaterThan");
            bool result = await Task.Run<bool>(() =>
            {
                Thread.Sleep(Delay);
                return Value.CompareTo(other.Value) > 0;
            });

            if (Debug)
                Console.WriteLine("Koniec GreaterThan");

            return result;
        }

        async public Task<SlowString> Last(SlowString other)
        {
            if (Debug)
                Console.WriteLine("Poczatek Last");

            SlowString result = await Task.Run<SlowString>(() =>
            {
                Thread.Sleep(Delay);

                int comparison = Value.CompareTo(other.Value);

                if (comparison < 0)
                    return other;

                return this;
            });

            if (Debug)
                Console.WriteLine("Koniec Last");

            return result;
        }

        public override string ToString()
        {
            return Value;
        }

        async public Task<SlowString> Concatenate(SlowString other)
        {
            if (Debug)
                Console.WriteLine("Poczatek Concatenate");

            SlowString result = await Task.Run<SlowString>(() =>
            {
                Thread.Sleep(Delay);

                return new SlowString(Value + other.Value, Debug, Delay);
            });

            if (Debug)
                Console.WriteLine("Koniec Concatenate");
            return result;
        }
    }
}
