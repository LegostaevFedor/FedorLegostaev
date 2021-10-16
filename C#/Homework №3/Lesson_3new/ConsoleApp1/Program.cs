using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float r = float.Parse(Console.ReadLine());
            float l = float.Parse(Console.ReadLine());
            const float pi = 3.14159265f;
            float S = pi * r * (r + l);
            Console.WriteLine(S);

        }
    }
}
