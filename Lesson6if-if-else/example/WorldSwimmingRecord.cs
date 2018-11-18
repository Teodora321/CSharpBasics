using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord

{
    class Program
    {
        static void Main(string[] args)
        {
            double secRecord = double.Parse(Console.ReadLine());
            double mdistance = double.Parse(Console.ReadLine());
            double secTimeForMeter = double.Parse(Console.ReadLine());

            double secSwim = mdistance * secTimeForMeter;
            double timeFor15Meter = Math.Floor(mdistance / 15) * 12.5;
            double totalTime = secSwim + timeFor15Meter;

            double failTime = totalTime - secRecord;

            if (secRecord <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {failTime:f2} seconds slower.");
            }
            else if (secRecord >= totalTime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}