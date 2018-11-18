using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01TripToWorldCup
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketForGo = double.Parse(Console.ReadLine());
            double ticketForReturn = double.Parse(Console.ReadLine());
            double priceMatch = double.Parse(Console.ReadLine());
            int numMatch = int.Parse(Console.ReadLine());
            int percentageDiscount = int.Parse(Console.ReadLine());

            double totalTicketsPrice = 6 * (ticketForGo + ticketForReturn);
            double ticketsWithDiscount = totalTicketsPrice*(100-percentageDiscount)/100;
            double totalPriceMatchTickets = 6 * numMatch * priceMatch;
            double totalSum = ticketsWithDiscount + totalPriceMatchTickets;
            double ratePerPerson = totalSum / 6;

            Console.WriteLine("Total sum: {0:f2} lv.", totalSum);
            Console.WriteLine("Each friend has to pay {0:f2} lv.", ratePerPerson);




        }
    }
}
