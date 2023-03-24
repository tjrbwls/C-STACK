using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double result;

            string str;

            Console.Write("첫 번째 숫자입력 : ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("두 번째 숫자입력 : ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            result = a + b;
            Console.WriteLine(a + "+" + b + " = " + result);
            result = a - b;
            Console.WriteLine(a + "-" + b + " = " + result);
            result = a * b;
            Console.WriteLine(a + "*" + b + " = " + result);
            result = (double)a / b;
            Console.WriteLine(a + "/" + b + " = " + result);
        }
    }
}
