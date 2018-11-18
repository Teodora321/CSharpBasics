using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02JulyFootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumNeeded = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double sneakersPrice = (tshirtPrice + shortsPrice) * 2;
            double totalPrice = tshirtPrice + shortsPrice + socksPrice + sneakersPrice;
            double priceWithDiscount = totalPrice * 0.85;
            double lackingMoney = sumNeeded - priceWithDiscount;

            if (priceWithDiscount >= sumNeeded) 
             {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {priceWithDiscount:f2} lv.");
            }
            else if (priceWithDiscount < sumNeeded)
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {lackingMoney:f2} lv. more."                    );
            }

        }
    }
}
