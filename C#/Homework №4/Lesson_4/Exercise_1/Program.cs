using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = float.Parse(Console.ReadLine());
            if (num >= 0.0 && num <= 30.9)
            {
                Console.WriteLine("Данное число находится в первом промежутке");
            }
            else if (num >= 31.0 && num <= 60.9) {
                Console.WriteLine("Данное число находится во втором промежутке");
            }
            else if (num >= 61.0 && num <= 100.0)
            {
                Console.WriteLine("Данное число находится в третьем промежутке");
            }
            else
                Console.WriteLine("Я такого числа не знаю");


        }
    }
}
