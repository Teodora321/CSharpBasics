using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GoingHome
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancekm = double.Parse(Console.ReadLine());
            double razhod = double.Parse(Console.ReadLine());
            double gasPrice = double.Parse(Console.ReadLine());
            double moneyEarned = double.Parse(Console.ReadLine());

            double expenseCar = distancekm * razhod / 100;
            double totalExpences = expenseCar * gasPrice;
            double money = moneyEarned - totalExpences;
            double moneyLeft = moneyEarned / 5;

            if (moneyEarned >= totalExpences)
            {
                Console.WriteLine($"You can go home. {money:f2} money left.");
            }
            else if (moneyEarned < totalExpences)

            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {moneyLeft:f02} money.");
            }





        }
    }
}
