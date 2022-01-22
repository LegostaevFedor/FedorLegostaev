using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[6];
            int perezap;

            Console.WriteLine("Введите значения массива:\n");

            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write("{0} элемент массива: ", i + 1);
                massiv[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < massiv.Length-1; k++)
            {
                for (int h = k + 1; h < massiv.Length; h++)
                {
                    if (massiv[k] < massiv[h])
                    {
                        perezap = massiv[k];
                        massiv[k] = massiv[h];
                        massiv[h] = perezap;

                    }
                }
            }

            Console.WriteLine("\nМассив в порядке убывания:\n");

            for (int l = 0; l < massiv.Length; l++)
            {
                Console.Write(massiv[l] + " ");
            }

            Console.ReadKey();
            /*
            Array.Sort(massiv);
            Array.Reverse(massiv);
            */
        }
    }
}
