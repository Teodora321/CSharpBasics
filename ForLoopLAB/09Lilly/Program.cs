using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toyCounter = 0;
            int brotherCounter = 0;
            int moneyFromGifts = 0;


            for (int i = 1; i <=age; i++)
            {
                if (i % 2 == 0)
                {
                    brotherCounter++;
                    moneyFromGifts += 10 * brotherCounter;
                    
                }
                else
                {
                    toyCounter++;
                }
            }
            int moneyToys = toyCounter * toyPrice;
            int moneySaved = (moneyFromGifts + moneyToys) - brotherCounter;

            if (moneySaved >= washingMashine)
            {
                Console.WriteLine($"Yes! {(moneySaved - washingMashine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMashine-moneySaved):f2}");
            }

        }

    }
}
