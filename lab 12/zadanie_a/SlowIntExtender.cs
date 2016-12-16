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
    }
}
