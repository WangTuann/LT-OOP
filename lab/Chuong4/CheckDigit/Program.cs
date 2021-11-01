using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,a,b,c;
            string number_Str;
            Console.WriteLine("Enter the number");
            number_Str = Console.ReadLine();
            number = Convert.ToInt32(number_Str);
            a = number / 10;//tach 3 so
            b = a % 7;//lay 3 so chia lay phan du 
            c = a / 7;//lay 3 so chia lay phan nguyen
            if ((c*7)+b==a)
            {
                Console.WriteLine("The number {0} is valid", number);
            }
            else
            {
                Console.WriteLine("The number {0} is invalid",number);
            }
            Console.ReadKey();
        }
    }
}
