using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double Ppokrivka = tables * (a + 2 * 0.30) * (b + 2 * 0.30);
            double Pkareta = tables * (a / 2) * (a / 2);
            double USD1 = Ppokrivka * 7 + Pkareta * 9;
            double BGN1 = USD1 * 1.85;
            Console.WriteLine($"{USD1:f2} USD");
            Console.WriteLine($"{BGN1:f2} BGN");

        }
    }
}
