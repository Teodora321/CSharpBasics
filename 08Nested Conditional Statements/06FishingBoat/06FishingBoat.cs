using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fisherMan = int.Parse(Console.ReadLine());

            double rent = 0;
            switch (season)

            {
                case "Spring": rent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter": rent = 2600;
                    break;
            }
            if (fisherMan <= 6)
            {
                rent = rent - (rent * 0.10);
            }
            else if (fisherMan>7 && fisherMan <= 11)
            {
                rent = rent - (rent * 0.15);
            } 
            else 
            {
                rent = rent - (rent * 0.25);
            }


            if (fisherMan % 2 == 0 && season!= "Autumn")
            {
                rent = rent - (rent * 0.05);
            }
            if (budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {rent - budget:f2} leva.");

            }
            else
            {
                Console.WriteLine($"Yes! You have {Math.Abs(budget - rent):f2} leva left.");
            }
                    


        }
    }
}
