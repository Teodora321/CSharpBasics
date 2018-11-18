using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BeerAndChips
{
    class beerAndChips
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numBeer = int.Parse(Console.ReadLine());
            int numChips = int.Parse(Console.ReadLine());

            double totalBeerPrice = 1.20 * numBeer;
            double ChipsPrice = totalBeerPrice * 0.45;
            double totalChipsPrice = Math.Ceiling(ChipsPrice * numChips);

            double totalPrice = totalBeerPrice + totalChipsPrice;
            if (totalPrice <= budget)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine("{0} bought a snack and has {1:f2} leva left.", name, moneyLeft);
            }
            else if (totalPrice >= budget)
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine("{0} needs {1:f2} more leva!", name, moneyNeed);
            }

        }
    }
}
