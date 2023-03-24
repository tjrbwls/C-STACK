using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_05_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("행 개수를 입력 : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("열 개수를 입력 : ");
            int col = int.Parse(Console.ReadLine());

            int[,] ary = new int[row, col];
            int num = 1;

            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int k = 0; k < ary.GetLength(1); k++)
                {
                    ary[i, k] = num;
                    num++;
                }
            }

            Console.WriteLine("ary[0,0]부터 ary[{0}, {1}]까지 출력", row, col);
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int k = 0; k < ary.GetLength(1); k++)
                {
                    Console.Write("{0, 3:D}", ary[i, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
