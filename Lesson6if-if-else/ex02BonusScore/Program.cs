using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            double bonusScore = 0.0;

            if (score <= 100)
            {
                bonusScore += 5;
            }
            else if (score > 100 && score <= 1000) 
            {
                bonusScore+= 0.20 * score;
            }

            else if (score > 1000)
            {
                bonusScore += 0.10 * score;
            }

            if (score % 10 ==5)
            {
                bonusScore += 2;
            }
            else if (score % 2 ==0)
            {
                bonusScore += 1;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(score + bonusScore);
        }
    }
}
