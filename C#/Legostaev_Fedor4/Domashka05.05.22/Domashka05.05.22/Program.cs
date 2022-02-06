using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Domashka05._05._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList spisok0 = new ArrayList() { "Elevent0", "Element1" };
            List<int> spisok1 = new List<int>() { 0, 1 };
  
            void Vivod0()
            {
                foreach (string i in spisok0) { Console.Write(i + " "); }
                Console.WriteLine("\n");
            }
            void Vivod01()
            {
                foreach (string i in spisok0) { Console.Write(i + " "); }
                Console.WriteLine("");

                foreach (int i in spisok1) { Console.Write(i + " "); }
                Console.WriteLine("\n");
            }
       
            Vivod01();

            spisok0.Add("Element2");
            spisok0.Add("Element3");

            spisok1.Add(2);
            spisok1.Add(3);
            
            Vivod01();

            spisok0.RemoveAt(3);
            spisok1.RemoveAt(3);

            Vivod01();

            spisok0.RemoveAt(spisok0.Count - 1);

            Vivod0();

            spisok0.Sort();

            Vivod0();

            Console.ReadKey();
        }
    }
}
