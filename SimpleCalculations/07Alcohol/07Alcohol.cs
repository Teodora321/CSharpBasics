using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Alcohol
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyRate = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskeyQ = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyRate / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);
            double rakiaSum = rakia * rakiaPrice;
            double wineSum = wine * winePrice;
            double beerSum = beer * beerPrice;
            double whiskeySum = whiskeyRate * whiskeyQ;

            double result = rakiaSum + wineSum + beerSum + whiskeySum;
            Console.WriteLine($"{result:f2}");



        }
    }
}
