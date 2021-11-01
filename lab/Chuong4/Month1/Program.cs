using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Month1
{
    class Program
    {
        enum MonthAndDay
        {
            January = 1

        }
        static void Main(string[] args)
        {
            byte Day, Month;
            string StrDay, StrMonth;
            byte Min = 1, Max = 12,
                Min1 = 1, Max1 = 31;
            Console.WriteLine("Enter your day");
            StrDay = Console.ReadLine();
            Day = Convert.ToByte(StrDay);
            Console.WriteLine("Enter your month");
            StrMonth = Console.ReadLine();
            Month = Convert.ToByte(StrMonth);
            if (Min <= Month && Month <= Max && Min1 <= Day && Day <= Max1)

            {
                Console.WriteLine("{0}/{1} is valid month",Day ,Month);
            }
            else
            {
                Console.WriteLine("{0}/{1} is invalid month", Day, Month);
            }

            Console.ReadKey();

        }
    }
}

