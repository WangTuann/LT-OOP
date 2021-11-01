using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int price;
            const int MAX= 8000;
            Console.WriteLine("enter a purchase");
            price = Convert.ToInt32(Console.ReadLine());
            if (price<=MAX)
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}
