using System;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTestsAsync().Wait();
        }

        private async static Task RunTestsAsync()
        {
            Console.WriteLine("=== ETAP 1 ===");
            var a = new SlowInt(10, true);
            var b = new SlowInt(5, true);

            var result1 = a.Equal(b);
            var result2 = b.Add(b);
            var result3 = b.LowerThen(a);

            result1.Wait();
            result2.Wait();
            result3.Wait();

            Console.WriteLine();
            Console.WriteLine("Results: {0},   {1},   {2}", result1.Result, result2.Result, result3.Result);
            Console.WriteLine();

            var result4 = await a.Equal(a);
            var result5 = await a.Add(b);
            var result6 = await a.LowerThen(a);

            Console.WriteLine();
            Console.WriteLine("Results: {0},   {1},   {2}", result4, result5, result6);
            Console.WriteLine();

            Console.WriteLine("=== ETAP 2 ===");

            var array1 = new SlowInt[]
            {
                new SlowInt(5), new SlowInt(4), new SlowInt(12), new SlowInt(2)
            };

            var sum1 = await array1.Sum(true);

            var array2 = new SlowInt[60];
            for (int i = 0; i < 60; ++i)
                array2[i] = new SlowInt(i, false, 1);

            var sum2 = await array2.Sum();

            Console.WriteLine();
            Console.WriteLine("Results: {0},   {1}", sum1, sum2);
            Console.WriteLine();

            Console.WriteLine("=== ETAP 3 ===");

            array1 = new SlowInt[]
            {
                new SlowInt(5, true), new SlowInt(4, true), new SlowInt(12, true), new SlowInt(2, true)
            };
            var max1 = array1.Max();
            var max2 = array2.Max();

            max1.Wait();
            max2.Wait();

            Console.WriteLine();
            Console.WriteLine("Results: {0},   {1}", max1.Result, max2.Result);
            Console.WriteLine();
        }
    }


}
