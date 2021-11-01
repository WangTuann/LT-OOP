using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admissin
{
    class Program
    {
        static void Main(string[] args)
        {
            double PointAVR = 3.0;
            double TestScore = 60,
                   TestScore1 = 80;
            double User1, User2;
            string StringUser1, StringUser2;


            Console.WriteLine("Enter your Point Average");
            StringUser1 = Console.ReadLine();
            User1 = Convert.ToDouble(StringUser1);


            Console.WriteLine("Enter your Test Score");
            StringUser2 = Console.ReadLine();
            User2 = Convert.ToDouble(StringUser2);

            if (User1 >= PointAVR && User2 >= TestScore)

            {
                Console.WriteLine("Accept");

            }
            else if (User1 < PointAVR && User2 >= TestScore1)
            {
                Console.WriteLine("Accepted");

            }
            else
            {
                Console.WriteLine("Reject");

            }
            Console.ReadKey();
        }
    }
}
