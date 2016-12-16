using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab12
{
    static class SlowIntExtender
    {
        async public static Task<SlowInt> Sum(this SlowInt[] array, bool showDebugInfo = false)
        {
            SlowInt result = new SlowInt(0, showDebugInfo);
            for (int i=0; i < array.Length; i++)
                result = await result.Add(array[i]);

            return result;
        }

        async public static Task<SlowInt> Max(this SlowInt[] array)
        {
            SlowInt[] elementsLeft = array;
            while (elementsLeft.Length > 1)
            {
                // Nie umiem użyć Math.Ceiling xD
                int newSize = elementsLeft.Length / 2;
                if (elementsLeft.Length % 2 == 1)
                    newSize++;

                Task<SlowInt>[] biggerElements = new Task<SlowInt>[newSize];
                for (int i=0; i < newSize; i++)
                {
                    if (elementsLeft.Length == 2 * i + 1)
                    {
                        // Trzeba zapisać jako oddzielna zmienna, w innym przypadku i nie będzie poprawne
                        int lastIndex = 2 * i;
                        biggerElements[i] = Task.Run(() => elementsLeft[lastIndex]);
                    }
                    else
                        biggerElements[i] = elementsLeft[2 * i].Max(elementsLeft[2 * i + 1]);
                }

                Task.WaitAll(biggerElements);
                elementsLeft = new SlowInt[newSize];
                for (int i = 0; i < newSize; i++)
                    elementsLeft[i] = biggerElements[i].Result;
            }

            return elementsLeft[0];
        }
    }
}
