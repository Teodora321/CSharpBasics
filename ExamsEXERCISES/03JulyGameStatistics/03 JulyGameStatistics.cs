﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03JulyGameStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutes = double.Parse(Console.ReadLine());
            string playerName = Console.ReadLine();

            if (minutes == 0)
            {
                Console.WriteLine("Match has just began! ");
            }
            else if (minutes<45)
            {
                Console.WriteLine("First half time.");
            }
            else
            {
                Console.WriteLine("Second half time.");
            }

            if (minutes>1 && minutes<=10 && minutes%2==0) 
            {
                Console.WriteLine($"{playerName} missed a penalty.");
                Console.WriteLine($"{playerName} was injured after the penalty.");
            }
            else if (minutes > 10 && minutes <=35 && minutes%2!=0)
            {
                Console.WriteLine($"{playerName} received yellow card.");
                Console.WriteLine($"{playerName} got another yellow card.");
            }
            else if (minutes > 35 && minutes<45)
            {
                Console.WriteLine($"{playerName} SCORED A GOAL !!!");
            }
            else if (minutes >45 && minutes<=55 && minutes%2==0)
            {
                Console.WriteLine($"{playerName} got a freekick.");
                Console.WriteLine($"{playerName} missed the freekick.");
            }
            else if (minutes > 55 && minutes <=80 && minutes%2!=0)
            {
                Console.WriteLine($"{playerName} missed a shot from corner.");
                Console.WriteLine($"{playerName} has been changed with another player.");
            }
            else if (minutes >80 && minutes <=90)
            {
                Console.WriteLine($"{playerName} SCORED A GOAL FROM PENALTY !!!");
            }
            
        }
    }
}
