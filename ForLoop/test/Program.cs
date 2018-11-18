using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int middleSymbols = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|");
            }
            for (int i = 0; i < n * 2 + 1; i++)
            {
                if (i < n - 1)
                {
                    Console.WriteLine("|{0}\\", new string(' ', middleSymbols));
                    middleSymbols++;
                }
                else
                {
                    Console.WriteLine("|{0}\\", new string('*', middleSymbols));
                    middleSymbols++;
                }
            }

            middleSymbols--;
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("|{0}|", new string('*', middleSymbols));
            }
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}/", new string('*', middleSymbols));
                middleSymbols--;
            }

            Console.WriteLine("{0}", new string('-', n * 3));
        }
    }
}
