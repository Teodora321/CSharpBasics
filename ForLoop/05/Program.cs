using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double firstCounter = 0;
            double secondCounter = 0;
            double thirdCounter = 0;
            double forthCounter = 0;
            double fifthCounter = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    firstCounter++;
                }
                else if (num < 400)
                {
                    secondCounter++;
                }
                else if (num < 600) 
                {
                    thirdCounter++;
                }
                else if (num < 800)
                {
                    forthCounter++;
                }
                else if (num >= 800)
                {
                    fifthCounter++;
                }

            }
            double p1 = (firstCounter / n) * 100;
            double p2 = (secondCounter / n) * 100;
            double p3 = (thirdCounter / n) * 100;
            double p4 = (forthCounter / n) * 100;
            double p5 = (fifthCounter / n) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
