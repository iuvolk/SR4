using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A, B, C");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int g = 0;
            int v = 0;
            int i1 = 0;
            int i2 = 0;

            while (a >= c)
            {
                a -= c;
                g++;
            }

            while (b >= c)
            {
                b -= c;
                v++;
            }
            while (i1 < g)
            {
                i2 += v;
                i1++;
            }

            Console.WriteLine("Количество квадратов = {0}" , i2);
            Console.ReadKey();
        }
    }

}
