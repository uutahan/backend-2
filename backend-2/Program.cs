using System;
using ThreeStackOneArray;

namespace backend_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ThreeStack<string> threeStack = new ThreeStack<string>();

            threeStack.push(1, "a");
            threeStack.push(2, "b");
            
            threeStack.push(1, "c");
            threeStack.push(3, "d");
            threeStack.push(2, "e");

            StackNode<string> node = threeStack.peek(1);
            Console.WriteLine(node.Value);

            threeStack.pop(1);
            StackNode<string> node2 = threeStack.peek(1);
            Console.WriteLine(node2.Value);

            threeStack.push(1, "f");

            StackNode<string> node3 = threeStack.peek(1);
            Console.WriteLine(node3.Value);

            threeStack.pop(2);
            threeStack.pop(2);
            threeStack.pop(3);
        }
    }
}
