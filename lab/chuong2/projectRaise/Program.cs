using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            double LuongNV1 = 5000000,
                LuongNV2=6000000,
                LuongNV3=5500000;
            const double LuongTangDuKien = 0.04;
            Console.WriteLine("Luong cua NV1 la {0} va du kien nam sau la {1}",LuongNV1,(LuongNV1+LuongNV1*LuongTangDuKien));
            Console.WriteLine("Luong cua NV2 la {0} va du kien nam sau la {1}", LuongNV2, (LuongNV2 + LuongNV2 * LuongTangDuKien));
            Console.WriteLine("Luong cua NV3 la {0} va du kien nam sau la {1}", LuongNV3, (LuongNV3 + LuongNV3 * LuongTangDuKien));
            Console.ReadKey();



        }
    }
}
