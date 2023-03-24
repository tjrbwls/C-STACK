using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string str;

            Console.Write("라인수 입력 : ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            int b = 0;
            int c = 0;
            int d = 0;
            for(b = 1; b <= a; b++)
            {
                for(c = a - b; c > 0; c--)
                {
                    Console.Write(" ");
                }
                for(d = 1; d <= (2 * b) - 1; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(b = a - 1; b >= 0; b--)
            {
                for(c = a - b; c > 0; c--)
                {
                    Console.Write(" ");
                }
                for(d = 1; d <= (2 * b) - 1; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
