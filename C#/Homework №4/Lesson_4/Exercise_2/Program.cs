using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 200;
            do
            {
                if (num % 17 == 0)
                    {
                        Console.Write(num);
                    if (num <= 500-17) {
                        Console.Write(",");
                                    }
                    }
                num++;
               
            } while (num <= 500);
        }
    }
}
