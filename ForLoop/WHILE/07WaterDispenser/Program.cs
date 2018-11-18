using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumOfGlass = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int times = 0;
            while (totalSum < volumOfGlass)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "easy")
                    totalSum += 50;
                if (input == "medium")
                    totalSum += 100;
                if (input == "hard")
                    totalSum += 200;
                times++;
            }
            if (totalSum > volumOfGlass)
            {
                Console.WriteLine($"{totalSum - volumOfGlass}ml has been spilled.");
            }
            else
            {
                Console.WriteLine($"The dispenser has been tapped {times} times.");
            }
        }
    }
}
