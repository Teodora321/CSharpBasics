using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToySop
{
    class Program
    {
        static void Main(string[] args)
        {
            double sectorsStadium = double.Parse(Console.ReadLine());
            double capacityStadium = double.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double income = (capacityStadium * ticketPrice) / sectorsStadium;
            double profit = income * sectorsStadium;
            double moneyCharity = (profit - (income * 0.75)) / 8;

            Console.WriteLine("Total income - " + ($"{profit:f2}")+ " BGN");
            Console.WriteLine("Money for charity - " + ($"{moneyCharity:f2}")+ " BGN");
        }
    }
}