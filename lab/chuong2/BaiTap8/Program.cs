    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap8
{
    class Program
    {
        static void Main(string[] args)
        {
            double LuongNV1, LuongNV2, LuongNV3;
            const double LuongTangDuKien = 0.04;
            Console.WriteLine("nhap vao luong hien tai cua NV1:");
            LuongNV1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap vao luong hien tai cua NV2:");
            LuongNV2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap vao luong hien tai cua NV3:");
            LuongNV3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Luong sau tang du kien nam sau cua NV 1 la:{0}", (LuongNV1 + LuongNV1 * LuongTangDuKien));
            Console.WriteLine("Luong sau tang du kien nam sau cua NV 2 la:{0}", (LuongNV2 + LuongNV2 * LuongTangDuKien));
            Console.WriteLine("Luong sau tang du kien nam sau cua NV 3 la:{0}", (LuongNV3 + LuongNV3 * LuongTangDuKien));
            Console.ReadKey();
        }
    }
}
