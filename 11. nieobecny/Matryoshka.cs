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
                if (Changed != null)
                    Changed(this, new NotifyEventArgs("Name"));
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
                if (Changed != null)
                    Changed(this, new NotifyEventArgs("Theme"));
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
                if (Changed != null)
                    Changed(this, new NotifyEventArgs("Color"));
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
                
                _innerDoll = value;
                if (Changed != null)
                    Changed(this, new NotifyEventArgs("InnerDoll"));
            }
        }

        public event EventHandler<NotifyEventArgs> Changed = null;
    }
}
