using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {   //nhap vao lua chon
            string userData;
            int r, p, s, number,sUserData;
            r = 1;
            p = 2;
            s = 3;
            Console.WriteLine("Welcome to the RockPaperGame");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter your choice r, p, or s");
            userData = Console.ReadLine();
            sUserData = Convert.ToInt32(userData);
            //ngau nhien cua may
            Random ranNumber = new Random();
            number = ranNumber.Next(1, 4);
            if (sUserData == number)
            {
                Console.WriteLine("tie");
            }
            else if (sUserData == 1 || number == 2)
            {
                Console.WriteLine("you lose, you choose {0} and the machine choose {1}",sUserData,number);
            }
            else if (sUserData == 1 || number == 3)
            {
                Console.WriteLine("you lose, you choose {0} and the machine choose {1}",sUserData,number);
            }
            else if (sUserData == 2 || number == 1)
            {
                Console.WriteLine("win");
            }
            else if (sUserData == 2 || number == 3)
            {
                Console.WriteLine("lose");
            }
            else if (sUserData == 3 || number == 1)
            {
                Console.WriteLine("lose");
            }
            else if (sUserData == 3 || number == 2)
            {
                Console.WriteLine("win");
            }
            Console.ReadKey();
        }
    }
}
