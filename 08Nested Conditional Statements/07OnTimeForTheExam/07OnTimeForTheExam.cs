using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double examHour = double.Parse(Console.ReadLine());
            double examMinute = double.Parse(Console.ReadLine());
            double arrivalHour = double.Parse(Console.ReadLine());
            double arrivalMinute = double.Parse(Console.ReadLine());

            double examMinuteTime = examHour * 60 + examMinute;
            double studentArrivalTime = arrivalHour * 60 + arrivalMinute;
            double minutesDifference = studentArrivalTime - examMinuteTime;

            Console.WriteLine(minutesDifference);

            if (minutesDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (minutesDifference <= 0)
            {
                Console.WriteLine("On Time");
            }
            else 
            {
                Console.WriteLine("Late");
            }
            if (minutesDifference != 0)
            {
                double hours = Math.Abs(minutesDifference / 60);
                double minutes = Math.Abs(minutesDifference % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + "hours");
                    else
                        Console.Write(hours + ":" + minutes + "hours");
                }
                else
                    Console.Write(minutes + " minutes");
                if (minutesDifference < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");




            }
    }
}
