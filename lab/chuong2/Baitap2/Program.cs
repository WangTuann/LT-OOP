using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = 5 > 4,
                 b= 3 <= 3,
            c= 2 + 4 > 5,
            d= 6 == 7,
            e=2 + 4 <= 6,
            f=3 + 4 == 4 + 3,
            g=1 != 2,
            h=2 != 2,
            i=-5 == 7 - 2,
            j= 3 + 9 <= 0;

            Console.WriteLine("a is {0} \nb is {1} \nc is {2} \nd is {3} \ne is {4} \nf is {5} \ng is {6} \nh is {7} \ni is {8} \nj is {9}\n", a, b, c, d, e, f, g, h, i, j );
            Console.ReadKey();
        }
    }
}
