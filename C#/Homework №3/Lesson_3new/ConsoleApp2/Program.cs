using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            int y = 1;
            int z = 5;
            Console.WriteLine(x += y - x++ * z); // x=-55;
            Console.WriteLine(z = --x - y * 5); //  z=-61; x=-56 
            Console.WriteLine(y /= x + 5 % z); //  y=0; 
            Console.WriteLine(z = x++ + y * 5); // z=-56; x=-55
            Console.WriteLine(x = y - x++ * z);

        }
    }
}
