using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Program
    {
        enum Planet
        {
            MERCURY=1,
            VENUS=2,
            EARTH=3,
            MARS=4,
            JUPITER=5,
            SATURN=6,
            URANUS=7,
            NEPTUNE=8,
        }
        static void Main(string[] args)
        {
            byte choose;
            Console.WriteLine("Add the number of the planet");
            choose = Convert.ToByte(Console.ReadLine());
            switch (choose)
            {
                case (byte)Planet.MERCURY:
                    Console.WriteLine("this is Mercury");
                    break;
                case (byte)Planet.VENUS:
                    Console.WriteLine("this is Venus");
                    break;
                case (byte)Planet.EARTH:
                    Console.WriteLine("this is Earth");
                    break;
                case (byte)Planet.MARS:
                    Console.WriteLine("this is Mars");
                    break;
                case (byte)Planet.JUPITER:
                    Console.WriteLine("this is Jupiter");
                    break;
                case (byte)Planet.SATURN:
                    Console.WriteLine("this is Saturn");
                    break;
                case (byte)Planet.URANUS:
                    Console.WriteLine("this is Uranus");
                    break;
                case (byte)Planet.NEPTUNE:
                    Console.WriteLine("this is Neptune");
                    break;
            }
            Console.ReadKey();

        }
    }
}
