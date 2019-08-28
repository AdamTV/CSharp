using System;

namespace Inheritance
{
    internal class Program
    { 
        private static void Main()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
        }
    }
}
