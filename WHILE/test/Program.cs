using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCountOfBadGrades = int.Parse(Console.ReadLine());
            int countOfBadGrades = 0;
            double sumGrades = 0;
            int counter = 0;
            string lastProblem = string.Empty;

            while (countOfBadGrades<maxCountOfBadGrades)
            {
                string nameExercise = Console.ReadLine();
                if (nameExercise== "Enough")
                {
                    double avgGrade = sumGrades / counter;
                    Console.WriteLine($"Average score: {avgGrade:f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    return;
                }

                lastProblem = nameExercise;
                int gradeExercise = int.Parse(Console.ReadLine());
                if (gradeExercise <=4)
                {
                    countOfBadGrades++;
                }
                sumGrades += gradeExercise;
                counter++;
                
            }

            Console.WriteLine($"You need a break, {maxCountOfBadGrades} poor grades.");

        }
    }
}
