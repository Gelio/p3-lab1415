using System;
using System.Collections.Generic;

namespace PO_Events
{
    class Matryoshka : IChangeNotifing
    {
        public Matryoshka(string name)
        {
            Name = name;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (_changed != null)
                    _changed(this, new NotifyEventArgs("Name"));
            }
        }

        private string _theme;
        public string Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                if (_changed != null)
                    _changed(this, new NotifyEventArgs("Theme"));
            }
        }


        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                if (_changed != null)
                    _changed(this, new NotifyEventArgs("Color"));
            }
        }

        private Matryoshka _innerDoll;
        public Matryoshka InnerDoll
        {
            get
            {
                return _innerDoll;
            }
            set
            {
                if (_innerDoll != null)
                    _innerDoll.Changed -= _bubbleEvent;

                _innerDoll = value;
                if (_changed != null)
                    _changed(this, new NotifyEventArgs("InnerDoll"));
                if (_innerDoll != null)
                    _innerDoll.Changed += _bubbleEvent;
            }
        }

        private event EventHandler<NotifyEventArgs> _changed = null;
        public event EventHandler<NotifyEventArgs> Changed
        {
            add
            {
                _changed += value;
                if (_innerDoll != null)
                    _innerDoll.Changed += _bubbleEvent;
            }
            remove
            {
                _changed -= value;
                if (_innerDoll != null)
                    _innerDoll.Changed -= _bubbleEvent;
            }
        }

        private void _bubbleEvent(object sender, NotifyEventArgs e)
        {
            if (_changed != null)
                _changed(this, new NotifyEventArgs("InnerDoll." + e.PropertyName));
        }
    }
}
