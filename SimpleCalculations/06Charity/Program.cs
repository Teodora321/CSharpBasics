using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sweets = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesRate = cakes * 45;
            double wafflesRate = waffles * 5.80;
            double pancakesRate = pancakes * 3.20;
            double rateDay = (cakesRate + wafflesRate + pancakesRate) * sweets;
            double rateCharity = rateDay * days;
            double finalRate = rateCharity * 0.875;

            Console.WriteLine($"{finalRate:f2}");

        }
    }
}
