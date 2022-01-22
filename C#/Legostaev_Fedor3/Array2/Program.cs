using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[3, 3] { { 155, 3, 21 }, { 6, 15, 4 }, { 78, 11, 9 } };
            
            for (int i = 0; i < 3; i++)
            {
                int max = massiv[i, 0];

                for (int j = 1; j < 3; j++)
                {
                    if (massiv[i, j] > max)
                    {
                        max = massiv[i, j];
                    }
                }

                Console.WriteLine("Максимальное значение {0} ряда чисел : {1}", i+1, max);
            }
            Console.ReadKey();
        }
    }
}
