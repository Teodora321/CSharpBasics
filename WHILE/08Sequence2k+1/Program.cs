using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberToShow = 1;

            while (numberToShow<=number)
            {
                Console.WriteLine(numberToShow);
                numberToShow = numberToShow * 2 + 1;
            }
        }
    }
}
