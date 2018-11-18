using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            
            double weekendSofia = 48 -h;
            double weekendSofiaGames = weekendSofia * 3.0 / 4;
            double feastSofia = p  * 2.0 /3;
            double totalGames = weekendSofiaGames + h + feastSofia;

            double gamesVolley = 0.15 * totalGames;
            double totalGamesLeap = totalGames + gamesVolley;

            if (year == "leap")
            {
                Console.WriteLine(Math.Floor(totalGamesLeap));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}
