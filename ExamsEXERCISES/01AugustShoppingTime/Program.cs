using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AugustShoppingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeForRest = double.Parse(Console.ReadLine());
            double pricePeriphery = double.Parse(Console.ReadLine());
            double priceProgram = double.Parse(Console.ReadLine());
            double priceFrappe = double.Parse(Console.ReadLine());

            double timeWithoutFrappe = timeForRest - 5;
            double timeForRelax = timeWithoutFrappe - (6 + 4);
            double totalPricePeriphery = 3 * pricePeriphery;
            double totalPriceProgram = 2 * priceProgram;
            double totalMoneySpent = totalPricePeriphery + totalPriceProgram + priceFrappe;


            Console.WriteLine($"{totalMoneySpent:f2}");
            Console.WriteLine(timeForRelax);

        }
    }
}
