using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentCount = 1;
            double totalSum = 0;
            
            while (n>=currentCount)
            {
                double number = double.Parse(Console.ReadLine());
                
                if (number <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum += number;
                Console.WriteLine($"Increase: {number:f2}");
                currentCount++;
  
            }
            Console.WriteLine($"Total: {totalSum:f2}");
           
            
        }
    }
}
