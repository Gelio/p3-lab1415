using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lab12
{
    class SlowInt
    {
        private int _value;
        bool _showDebugInfo;
        private int _delay;

        public SlowInt(int value, bool showDebugInfo = false, int delay = 30)
        {
            _value = value;
            _showDebugInfo = showDebugInfo;
            _delay = delay;
        }

        async public Task<bool> Equal(SlowInt other)
        {
            if (_showDebugInfo)
                Console.WriteLine("SlowInt Equal started");
            bool result = await Task.Run<bool>(() => {
                Thread.Sleep(_delay);
                return other._value == _value;
            });

            if (_showDebugInfo)
                Console.WriteLine("SlowInt Equal finished");
            return result;
        }

        async public Task<bool> LowerThen(SlowInt other)
        {
            if (_showDebugInfo)
                Console.WriteLine("SlowInt LowerThen started");
            bool result = await Task.Run<bool>(() => {
                Thread.Sleep(_delay);
                return other._value >= _value;
            });

            if (_showDebugInfo)
                Console.WriteLine("SlowInt LowerThen finished");
            return result;
        }

        async public Task<SlowInt> Add(SlowInt other)
        {
            if (_showDebugInfo)
                Console.WriteLine("SlowInt Add started");
            SlowInt result = await Task.Run<SlowInt>(() => {
                Thread.Sleep(_delay);
                return new SlowInt(_value + other._value, _showDebugInfo, _delay); ;
            });

            if (_showDebugInfo)
                Console.WriteLine("SlowInt Add finished");
            return result;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
