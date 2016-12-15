using System;
using System.Collections.Generic;

namespace PO_Events
{
    class SimpleWatcher
    {
        public void Watch(IChangeNotifing eventEmitter)
        {
            eventEmitter.Changed += NotifyObjectChanged;
        }

        public void StopWatching(IChangeNotifing eventEmitter)
        {
            eventEmitter.Changed -= NotifyObjectChanged;
        }

        private void NotifyObjectChanged(object sender, NotifyEventArgs e)
        {
            Console.WriteLine("Object changed");
        }
    }
}
