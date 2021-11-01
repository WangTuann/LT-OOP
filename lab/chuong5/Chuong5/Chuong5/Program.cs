using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            while (number<5)
            {
                Console.WriteLine("Enter five interger ");
                sum += int.Parse(Console.ReadLine());
            }
        }
    }
}
