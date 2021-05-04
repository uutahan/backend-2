using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeStackOneArray
{
    public class StackNode<T>
    {
        private int _prevNodeLocation;
        private T _value;

        public StackNode(T value, int prevNodeLocation)
        {
            this._prevNodeLocation = prevNodeLocation;
            this._value = value;
        }

        public int PrevNodeLocation
        {
            get { return _prevNodeLocation; }
            set { _prevNodeLocation = value; }
        }

        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
