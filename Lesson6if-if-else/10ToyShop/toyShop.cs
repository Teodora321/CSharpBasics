using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ToyShop
{
    class toyShop
    {
        static void Main(string[] args)
        {
            double priceOfPuzzle = 2.60;
            double priceOfDoll = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double priceOfTrip = double.Parse(Console.ReadLine());
            int countOfPuzzles = int.Parse(Console.ReadLine());
            int countOfDolls = int.Parse(Console.ReadLine());
            int countOfBears = int.Parse(Console.ReadLine());
            int countOfMinions = int.Parse(Console.ReadLine());
            int countOfTrucks = int.Parse(Console.ReadLine());
            int totalToysCount = countOfBears + countOfDolls + countOfMinions + countOfPuzzles + countOfTrucks;

            double priceOfPuzzles = countOfPuzzles * countOfPuzzles;
            double priceOfDolls = countOfDolls * countOfDolls;
            double priceOfBears = countOfBears * countOfBears;
            double priceOfMinions = countOfMinions * countOfMinions;
            double priceOfTrucks = countOfTrucks * countOfTrucks;

            double totalPrice = priceOfPuzzles +
                                priceOfDolls +
                                priceOfBears +
                                priceOfMinions +
                                priceOfTrucks; 

            if (totalToysCount >=50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);

            }
            totalPrice = totalPrice - (totalPrice * 0.1);
            double moneyLeft = Math.Abs(totalPrice - priceOfTrip);
            if (totalPrice < priceOfTrip)
            {
                Console.WriteLine($"Not enough money! {moneyLeft:F2} lv left.");
            }

            else
            {
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }




        }
    }
}
