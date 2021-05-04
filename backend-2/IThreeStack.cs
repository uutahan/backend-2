using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeStackOneArray
{
    public interface IThreeStack<T>
    {
        StackNode<T> peek(int stackNo);
        void push(int stackNo, T value);
        StackNode<T> pop(int stackNo);
    }
}
