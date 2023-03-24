using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Report_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10, 20, 30};
            Stack<int> stack = new Stack<int>(arr);

            while (stack.Count != 0)
            {
                Console.WriteLine("value : " + stack.Pop());
            }
        }
    }
}
