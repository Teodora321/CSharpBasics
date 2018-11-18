using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ExHoreografiq
{
    class Ex08Horeografiq
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsPerDay = ((steps / days) / steps) * 100;
            stepsPerDay = Math.Ceiling(stepsPerDay);
            double percentagePerDancer = stepsPerDay / dancers;

            if (stepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentagePerDancer:F2}%.");
            }
            else if (stepsPerDay > 13)
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentagePerDancer:F2}% steps to be learned per day.");
            }


        }
    }
}
