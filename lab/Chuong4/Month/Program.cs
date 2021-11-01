using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Month
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Month;
            string StrMonth;
            byte min = 1, max = 12;
            Console.WriteLine("Enter your month");
            StrMonth = Console.ReadLine();
            Month = Convert.ToByte(StrMonth);
            if (min<=Month&&Month<=max)

            {
                Console.WriteLine("{0} is valid month",Month);
            }
            Console.ReadKey();
        
        }
    }
}
