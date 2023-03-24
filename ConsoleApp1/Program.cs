using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string str;

            Console.Write("라인 수 입력 : ");
            str = Console.ReadLine();
            i = Convert.ToInt32(str);

            if(i == 1)
            {
                Console.WriteLine("   *");
            }

            else if(i == 2)
            {
                Console.WriteLine("   *");
                Console.WriteLine("  ***");
                Console.WriteLine("   *");
            }

            else if(i == 3)
            {
                Console.WriteLine("   *");
                Console.WriteLine("  ***");
                Console.WriteLine(" *****");
                Console.WriteLine("  ***");
                Console.WriteLine("   *");
            }

            else if(i  == 4)
            {
                Console.WriteLine("   *");
                Console.WriteLine("  ***");
                Console.WriteLine(" *****");
                Console.WriteLine("*******");
                Console.WriteLine(" *****");
                Console.WriteLine("  ***");
                Console.WriteLine("   *");
            }

            else
            {
                Console.WriteLine("정해진 범위를 벗어났습니다!");
            }

        }
    }
}
