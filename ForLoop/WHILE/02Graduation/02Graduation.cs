using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 1;
            double sumGrades = 0;

            while (counter <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade >= 4.00)
                {
                    sumGrades += currentGrade;
                    counter++;
                }
            }
            double avg = sumGrades / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {avg:f2}");
        }
    }
}
