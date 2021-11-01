using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            uint SoTien;
            const int twenties = 20, ten = 10, five = 5, one = 1;
            Console.WriteLine("Nhap vao so tien cua ban");
            SoTien = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("So tien la: \n{0} twenties \n{1} ten \n{2} five \n{3} one",(SoTien / twenties), ((SoTien % twenties) / ten), ((((SoTien % twenties) % ten)) / five), (((((SoTien % twenties) % ten)) % five) / 1));
            Console.ReadKey();
        }
    }
}
