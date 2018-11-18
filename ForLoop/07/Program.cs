using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int moneyLeft = 0;
            

            for (int i = 1; i <= tabs; i++)
            {
                string nameTab = Console.ReadLine();

                if (nameTab=="Facebook")
                {
                    salary -= 150;
                }
                if (nameTab == "Instagram")
                {
                    salary -= 100;
                }
                if (nameTab=="Reddit")
                {
                    salary -= 50;
                                     
                }
                if (salary == 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
               
            }
            Console.WriteLine($"{salary-moneyLeft}");
        }
    }
}
