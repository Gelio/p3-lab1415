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
    }
}
