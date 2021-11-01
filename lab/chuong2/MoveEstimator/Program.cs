using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            double SoGio, SoDam;
            const double PhiCoBan= 200;
            const double DiChuyenMotGio = 150;
            const double DiChuyenMoiDam = 2;
            Console.WriteLine("Nhap vao so gio di chuyen:");
            SoGio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao so dam di chuyen");
            SoDam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tong chi phi = {0} $", PhiCoBan+(SoGio * DiChuyenMotGio)+(SoDam*DiChuyenMoiDam));
            Console.ReadKey();
        }
    }
}
