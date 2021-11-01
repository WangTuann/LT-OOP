using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,c,d,e,kq;
            e = "ay";
            Console.WriteLine("Nhap vao mot tu");
            a = Convert.ToString(Console.ReadLine());
            b= a.Substring(1);
            c = a.Substring(0, 1);
            d = b + c;
            kq = d + e;
            Console.WriteLine("Trong PigLattin tu {0} co nghia la {1}",a,kq);
            Console.ReadKey();
        }
    }
    
}
