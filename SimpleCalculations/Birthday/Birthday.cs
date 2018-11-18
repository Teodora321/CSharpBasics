using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Birthday
    {
        static void Main(string[] args)


        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height =int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double volume  = lenght*width*height;

            double liters = volume * 0.001;
            double percentage1 = percentage * 0.01;
            double litersneeded = liters - (liters * percentage1);

            Console.WriteLine($"{litersneeded:F3}");


        }
    }
}
