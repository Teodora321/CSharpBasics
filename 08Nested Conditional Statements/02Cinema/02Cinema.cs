using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            double numberRows = double.Parse(Console.ReadLine());
            double numberColumns = double.Parse(Console.ReadLine());
            double price = 0;

            switch (typeProjection)
            {
                case "Premiere":
                    price = 12.00;

                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
            }   
            Console.WriteLine($"{(numberColumns*numberRows*price) :f2}"+ " leva");

        }
    }
}
