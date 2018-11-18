using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double result = USD * 1.79549;
            Console.WriteLine(Math.Round(result,2) + " BGN ");
        }
    }
}
