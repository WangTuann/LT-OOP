using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthName
{
    class Program
    {
           enum Month:byte
        {
            January=1,
            February=2,
            March=3,
            April=4,
            May=5,
            June=6,
            July=7,
            August=8,
            September=9,
            October=10,
            November=11,
            December=12,
        }
            
        static void Main()
        {
           byte choose;
            Console.WriteLine("nhap vao so thang:");
            choose = Convert.ToByte(Console.ReadLine());
            switch (choose)
            {
                case (byte)Month.January:
                     Console.WriteLine("January");
                    break;
                case (byte)Month.February:
                    Console.WriteLine("February");
                    break;
                case (byte)Month.March:
                    Console.WriteLine("March");
                    break;
                case (byte)Month.April:
                    Console.WriteLine("April");
                    break;
                case (byte)Month.May:
                    Console.WriteLine("May");
                    break;
                case (byte)Month.June:
                    Console.WriteLine("June");
                    break;
                case (byte)Month.July:
                    Console.WriteLine("July");
                    break;
                case (byte)Month.August:
                    Console.WriteLine("August");
                    break;
                case (byte)Month.September:
                    Console.WriteLine("September");
                    break;
                case (byte)Month.October:
                    Console.WriteLine("October");
                    break;
                case (byte)Month.November:
                    Console.WriteLine("November");
                    break;
                case (byte)Month.December:
                    Console.WriteLine("December");
                    break;

            }
            Console.ReadKey();
        }
    }
}
