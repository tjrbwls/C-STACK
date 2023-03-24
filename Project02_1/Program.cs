using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int result;
            a = 1234;
            b = 456;

            result = a + b;
            Console.WriteLine(a + " + " + b + " = " + result);
            result = a - b;
            Console.WriteLine(a + " - " + b + " = " + result);
            result = a * b;
            Console.WriteLine(a + " * " + b + " = " + result);
            result = a / b;
            Console.WriteLine(a + " / " + b + " = " + result);
        }
    }
}
