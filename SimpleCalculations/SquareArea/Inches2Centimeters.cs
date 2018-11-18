using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Inches2Centimeters
    {
        static void Main(string[] args)
        {
            Console.Write("Inches=");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters="+ a * 2.54);

        }
    }
}
