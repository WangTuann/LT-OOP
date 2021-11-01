using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {

            double Speed;
            string StringSpeed;
            double lv5 = 157,
                   lv4 = 130,
                   lv3 = 111,
                   lv2 = 96,
                   lv1 = 74;

            Console.WriteLine("Enter the speed of wind");
            StringSpeed = Console.ReadLine();
            Speed = Convert.ToDouble(StringSpeed);
            if (Speed >= lv5)
            {
                Console.WriteLine("A hurricane is level 5");
            }
            else if (lv4 <= Speed)
            {
                Console.WriteLine("A hurricane is level 4");
            }
            else if (lv3 <= Speed)
            {
                Console.WriteLine("A hurricane is level 3");
            }
            else if (lv2 <= Speed)
            {
                Console.WriteLine("A hurricane is level 2");
            }
            else if (lv1 <= Speed)
            {
                Console.WriteLine("A hurricane is level 1");
            }
            else if (Speed < lv1)
            {
                Console.WriteLine("It is not a hurricane");

            }
            Console.ReadKey();
        }
    }
}
