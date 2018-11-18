using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double usdRate = 1.79549;
            double eurRate = 1.95583;
            double gbpRate = 2.53405;

            double result = 0;

            if (inputCurrency == "BGN")
                if (outputCurrency == "USD")

                {
                    result = money * usdRate;
                }
                else if (inputCurrency == "USD")
                {
                    result = money * eurRate;
                }
                else if (inputCurrency == "EUR")
                {
                    result = money * gbpRate;
                }
                else if (inputCurrency == "GBP")                            

            

                        }
        
        }
    }
}
