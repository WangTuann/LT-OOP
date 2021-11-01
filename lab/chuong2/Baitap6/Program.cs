using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap6
{
    class Program
    {
        static void Main(string[] args)
        {
            double inche, cm;
            Console.WriteLine("nhap vao so inch");
            inche = Convert.ToDouble(Console.ReadLine());
            cm = inche * 2.54;
            Console.WriteLine("{1} inche bang {0} cm",cm,inche);
            Console.ReadKey();
        }
    }
}
