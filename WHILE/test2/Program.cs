using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int daysPassed = 0;
            int spendDays = 0;


            while (spendDays!=5)
            {
                string action = Console.ReadLine();
                double transaction = double.Parse(Console.ReadLine());
                daysPassed++;
                if (action == "spend")
                {
                    spendDays++;
                    if (transaction>currentMoney)
                    {
                        currentMoney = 0;
                    }
                    currentMoney -= transaction;
                }
                else if(action == "save")
                {
                    spendDays = 0;
                    currentMoney += transaction;
                }
                if (moneyNeeded<=currentMoney)
                {
                    Console.WriteLine($"You saved the money for {daysPassed} days.");
                }
            }
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysPassed);

        }
    }
}
