using System;
using System.Threading.Tasks;

namespace Lab12
{
    static class SlowStringExtender
    {
        async public static Task<SlowString> Last(this SlowString[] array, bool debug = false)
        {
            if (array.Length == 0)
                return null;

            SlowString result = array[0];
            for (int i = 1; i < array.Length; i++)
                result = await result.Last(array[i]);

            return result;
        }

        async public static Task<SlowString> Concatenate(this SlowString[] array)
        {
            if (array.Length == 0)
                return null;

            SlowString[] elementsLeft = array;
            while (elementsLeft.Length > 1)
            {
                int newSize = (int)Math.Ceiling((decimal)elementsLeft.Length / 2);
                Task<SlowString>[] tasks = new Task<SlowString>[newSize];
                for (int i=0; i < newSize; i++)
                {
                    if (2 * i + 1 >= elementsLeft.Length)
                        tasks[i] = Task.Run<SlowString>(() => elementsLeft[2 * i - 2]);
                    else
                        tasks[i] = elementsLeft[2 * i].Concatenate(elementsLeft[2 * i + 1]);
                }

                Task.WaitAll(tasks);

                SlowString[] newElements = new SlowString[newSize];
                for (int i = 0; i < tasks.Length; i++)
                    newElements[i] = tasks[i].Result;
                elementsLeft = newElements;
            }

            return elementsLeft[0];
        }
    }
}
