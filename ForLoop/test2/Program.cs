﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class DiamontMain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");
                for (int j = 1; j < i; j++)
                {
                    Console.Write("_*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("*");
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write("_*");
                }
                Console.WriteLine();

            }
        }
    }
}