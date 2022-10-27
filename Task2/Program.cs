using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел");
            int n;
            int i1 = 1;
            int i2 = 1;
            int s1 = 0;
            int s2 = 0;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                    s1 = i1++;
                else if (n > 0)
                    s2 = i2++;
                else continue;
            } while (n != 0);

            Console.WriteLine("Количество положительных {0}, количество отрицательных {1}", s2, s1);
            if (s2>s1)
                Console.WriteLine("Количество положительных чисел больше");
            else
                Console.WriteLine("Количество отрицательных чисел больше");
            Console.ReadKey();

        }
    }
}
