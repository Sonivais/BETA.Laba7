using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] g = new int[16];
            Random r = new Random();
            for (int i = 0; i < 16; i++)
            {
                g[i] = r.Next(0, 16);
            }
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"g[{i + 1}] = {g[i]}");
            }

            // 1 сумму элементов массива  ig , неравных 6, и количество таких элементов
            Console.WriteLine("Элементы массива gi, не равные 6, и их количество:");
            for (int i = 0; i < g.Length; i++)
            {
                if (g[i] < 6)
                {
                    int sum = 0;
                    foreach (int value in g)
                    {
                        sum += value;
                    }
                    Console.WriteLine($"Сумма элементов массива: " + sum);
                    Console.WriteLine($"Номер элемента: {g[i]}");
                }
            }
            // элементы массива  iv , i = 1..16 по формуле

            int[] v = new int[16];
            Random R = new Random();
            for (int i = 0; i < 16; i++)
            {
                v[i] = r.Next(0, 16);
            }
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"v[{i + 1}] = {v[i]}");
            }

            for (int i = 0; i < g.Length; i++)
            {
                if (g[i] > 8)
                {
                    v[i] = 100;
                    Console.WriteLine($"v[i]");
                }
                while (g[i] <= 8)
                {
                    v[i] = 3 * g[i] - 5;
                    Console.WriteLine($"v[i]");
                }
            }

            


               
        }
    }
}
