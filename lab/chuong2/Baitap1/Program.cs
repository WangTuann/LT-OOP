using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a, e, h;
            float b, c, d, f, g, i, j, k, l;
            a = 2 + 5 * 3;
            b = (float)9 / 4 + 10;
            c = (float)10 / 3;
            d = 21 % 10;
            e = (5 - 1) * 3;
            f = (float)37 / 5;
            g = 64 % 8;
            h = 5 + 2 * 4 - 3 * 4;
            i = (float)3 * (2 + 5) / 5;
            k = (float)19 / 2 / 2;
            l = (float)28 / (2 + 4);
            Console.WriteLine("a={0} b={1} c={2} d={3} e={4} f={5} g={6} h={7} i={8} k={9} l={10}", a, b, c, d, e, f, g, h, i, k, l);
            Console.ReadKey();

        }
    }
}
