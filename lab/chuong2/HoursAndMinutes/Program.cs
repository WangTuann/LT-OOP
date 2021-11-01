using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double Minute;
            const double Hour = 60;
            Console.WriteLine("nhap vao so phut");
            Minute = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} phut bang {1} gio",Minute,Minute/Hour);
            Console.ReadKey();
        }
    }
}
