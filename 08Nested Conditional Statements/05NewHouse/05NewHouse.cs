using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05NewHouse
{
    using System;

    namespace _06.New_House
    {
        class Program
        {
            static void Main()
            {
                string flower = Console.ReadLine();
                int numFlower = int.Parse(Console.ReadLine());
                double budget = double.Parse(Console.ReadLine());

                double priceFlower = 0;

                switch (flower)
                {
                    case "Roses":
                        priceFlower = 5.0;
                        break;
                    case "Dahlias":
                        priceFlower = 3.80;
                        break;
                    case "Tulips":
                        priceFlower = 2.80;
                        break;
                    case "Narcissus":
                        priceFlower = 3;
                        break;
                    case "Gladiolus":
                        priceFlower = 2.50;
                        break;
                 }

                double totalPrice = numFlower * priceFlower;

                if ((flower == "Roses") && numFlower > 80)
                {
                    totalPrice = totalPrice * 0.90;
                }
                else if ((flower == "Dahlias") && numFlower > 90)
                {
                    totalPrice = totalPrice * 0.85;
                }
                else if ((flower == "Tulips") && numFlower > 80)
                {
                    totalPrice = totalPrice * 0.85;
                }
                else if ((flower == "Narcissus") && numFlower <120 )
                {
                    totalPrice = totalPrice + (totalPrice*0.15);
                }
                else if ((flower == "Gladiolus") && numFlower < 80)
                {
                    totalPrice = totalPrice + (totalPrice* 0.20);
                }


                if (totalPrice > budget) 
                {
                    Console.WriteLine(($"Not enough money, you need {totalPrice - budget:f2} leva more."));
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {numFlower} {flower} and {budget - totalPrice:f2} leva left.");
                }

            }
        }
    }  }