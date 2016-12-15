using System;
using System.Collections.Generic;

namespace PO_Events
{
    class SmartWatcher
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
            if (!(sender is IChangeNotifing))
                return;

            IChangeNotifing eventSource = sender as IChangeNotifing;
            Console.WriteLine("Object " + eventSource.Name + " changed property: " + e.PropertyName);
        }
    }
}
