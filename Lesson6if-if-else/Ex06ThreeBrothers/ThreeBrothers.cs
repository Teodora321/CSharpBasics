using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06ThreeBrothers
{
    class ThreeBrothers
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / A + 1 / B + 1 / C);
            double totalTimeWithRest = totalTime * 0.15;
            totalTime += totalTimeWithRest;
            double timeLeft = D - totalTime;
           
            
            Console.WriteLine($"Cleaning time: {totalTime:f2}");

            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
             else 
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> { Math.Abs(Math.Floor(timeLeft))} hours.");
            }

            
        }
    }
}
