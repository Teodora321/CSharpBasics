using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "square")

            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(side * side):f3}");
            }
            else if (type == "triangle")
            {
                double sideLenght = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (sideLenght * h) / 2;
                Console.WriteLine($"{area:f3}");
            }

            else if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                Console.WriteLine($"{(sideA * sideB):f3}");
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areacircle = Math.PI * radius * radius;
                Console.WriteLine($"{areacircle:f3}");
            }
        }
    }
}
