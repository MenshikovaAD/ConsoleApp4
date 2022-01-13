using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N, при условие N > 0" + Environment.NewLine);
            int N = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int i = 1;
            for (; i <= N; i++)
            {
                n += 2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", N, n);
            }
            Console.ReadKey();
        }
    }
}
