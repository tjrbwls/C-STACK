using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_05_4
{
    internal class Program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            return stack;
        }
        static void Main()
        {
            var stack = GetStack();

            while(stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
