using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeStackOneArray
{
    public class ThreeStack<T> : IThreeStack<T>
    {
        private static int STACK_COUNT = 3;
        private static int CAPACITY = 15;

        private StackNode<T>[] arr;
        private int[] stackTopPointers; // first elem represent stack pointer that holds free positions.

        private int size = 0;

        public ThreeStack()
        {
            stackTopPointers = new int[STACK_COUNT + 1];
            arr = new StackNode<T>[CAPACITY];

            stackTopPointers[0] = 0; //only empty stack's pointer points to start of arr.
            for (int i = 0; i < STACK_COUNT; i++)
            {
                stackTopPointers[i + 1] = -1; //initially pointers are -1.
            }

            for (int i = 0; i < CAPACITY; i++)
            {
                //initilize array as all values 0 and 0th element is top of the arr and all
                //0,1,2.. elems are free at start so we connect all so that it represents our free stack
                arr[i] = new StackNode<T>(default(T), i + 1);
            }
        }

        public StackNode<T> peek(int stackNo)
        {
            if(stackNo <= 0 || stackNo > STACK_COUNT)
            {
                throw new Exception("Stack No can not be less then or equal to 0.");
            }

            int currentStackTop = stackTopPointers[stackNo];
            StackNode<T> node = arr[currentStackTop];

            return node;
        }

        public void push(int stackNo, T value) 
        {
            if (stackNo <= 0 || stackNo > STACK_COUNT)
            {
                throw new Exception("Stack No can not be less then or equal to 0.");
            }

            int currentStackTop = stackTopPointers[stackNo];
            
            int emptyPosition = getEmptyPostion();
            StackNode<T> node = arr[emptyPosition];
            
            node.PrevNodeLocation = currentStackTop;      
            node.Value = value;

            stackTopPointers[stackNo] = emptyPosition;
        }

        public StackNode<T> pop(int stackNo)
        {
            if (stackNo <= 0 || stackNo > STACK_COUNT)
            {
                throw new Exception("Stack No can not be less then or equal to 0.");
            }

            int currentStackTop = stackTopPointers[stackNo];
            
            if (currentStackTop == -1)
            {
                throw new Exception("Stack is already empty");
            }

            StackNode<T> node = arr[currentStackTop];
            stackTopPointers[stackNo] = node.PrevNodeLocation;

            //Make it empty position
            emptyPosition(currentStackTop);
            return node;
        }

        private void emptyPosition(int index)
        {
            arr[index].PrevNodeLocation = stackTopPointers[0];

            stackTopPointers[0] = index;

            size--;
        }

        private int getEmptyPostion()
        {
            int emptyPosition = stackTopPointers[0];
            
            if (size >= CAPACITY)
            {
                throw new Exception("MAX SIZE EXCEEDED");
            }

            stackTopPointers[0] = arr[emptyPosition].PrevNodeLocation;
            size++;

            return emptyPosition;
        }

    }
}
