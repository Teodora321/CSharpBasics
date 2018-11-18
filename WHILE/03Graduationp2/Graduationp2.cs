using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Graduationp2
{
    class Graduationp2
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 1;
            double sumGrades = 0;
            double badGrade = 0;

            while (counter <= 12 && badGrade<2)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade>=4.00 && badGrade<2)
                {
                    sumGrades += currentGrade;
                    counter++;
                }
                else
                {
                    badGrade += 1;
                }
            }
            if (badGrade<2)
            {
                double avg = sumGrades / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {avg:F2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {counter} grade");
            }
           

        }

    }
}

