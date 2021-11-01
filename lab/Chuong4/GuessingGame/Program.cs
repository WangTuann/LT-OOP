using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string sNumber,sUserNumber;
            Console.WriteLine("Enter your guessing number");
            sUserNumber = Console.ReadLine();
            Random ranNumber = new Random();
            number = ranNumber.Next(1, 11);
            sNumber = ranNumber.Next(1, 11).ToString();
            if (sUserNumber==sNumber)
            {
                Console.WriteLine("you win\n the random number is {0}",sNumber);

            }
            else
            {
                Console.WriteLine("you lose the random number is {0}", sNumber);
            }
            Console.ReadKey();
        }
    }
}
