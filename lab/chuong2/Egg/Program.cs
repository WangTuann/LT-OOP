using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg
{
    class Program
    {
        static void Main(string[] args)
        {
            double egg1, egg2, egg3, egg4, sum;
            const int dozen = 12;
            Console.WriteLine(" nhap vao so trung lan 1:");
            egg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" nhap vao so trung lan 2:");
            egg2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" nhap vao so trung lan 3:");
            egg3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" nhap vao so trung lan 4:");
            egg4 = Convert.ToDouble(Console.ReadLine());
            sum = egg1 + egg2 + egg3 + egg4;
            Console.WriteLine("Tong so trung la:{0} ta va {1} trung ",sum/dozen,sum%dozen);
            Console.ReadKey();
        }
    }
}
