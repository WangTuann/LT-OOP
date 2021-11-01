using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    class Program
    {
        static List<int> a = new List<int>();
        //static int lenght = 0;

        enum ThucDon
        {
            TimSoNguyenXuatHienNhieuNhat = 1,
            TimSoNguyenXuatHienItNhat,
            TimViTriSoLonNhat,
            TimViTriSoNhoNhat,
            TimTatCaSoChan,
            TImTatCaSoLe,
            KiemTraPhanTuXCoTrongMangKhong,
            XoaPhanTuTaiViTriX,
            SapXepMangTheoChieuTang,
            SapXepMangTheoChieuGiam,
            Thoat = 11
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("------------------------------HE THONG MENU TUY CHON------------------------------------");
                Console.WriteLine("Nhap {0} de tim so nguyen xuat hien nhieu nhat", (int)ThucDon.TimSoNguyenXuatHienNhieuNhat);
                Console.WriteLine("Nhap {0} de tim so nguyen xuat hien it nhat", (int)ThucDon.TimSoNguyenXuatHienItNhat);
                Console.WriteLine("Nhap {0} de tim vi tri so lon nhat", (int)ThucDon.TimViTriSoLonNhat);
                Console.WriteLine("Nhap {0} de tim vi tri so nho nhat", (int)ThucDon.TimViTriSoNhoNhat);
                Console.WriteLine("Nhap {0} de tim tat ca so chan", (int)ThucDon.TimTatCaSoChan);
                Console.WriteLine("Nhap {0} de tim tat ca so le", (int)ThucDon.TImTatCaSoLe);
                Console.WriteLine("Nhap {0} de kiem tra phan X co trong mang khong", (int)ThucDon.KiemTraPhanTuXCoTrongMangKhong);
                Console.WriteLine("Nhap {0} de xoa phan tu tai vi tri X", (int)ThucDon.XoaPhanTuTaiViTriX);
                Console.WriteLine("Nhap {0} de sap xep mang theo chieu tang", (int)ThucDon.SapXepMangTheoChieuTang);
                Console.WriteLine("Nhap {0} de sap xep mang theo chieu giam", (int)ThucDon.SapXepMangTheoChieuGiam);
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                ThucDon nhap = (ThucDon)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case ThucDon.TimSoNguyenXuatHienNhieuNhat:
                        NhapTufile();
                        XuatMang();
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("So nguyen xuat hien nhieu nhat la \n : {0}", DemSoLanXuatHienNhieuNhat());
                        break;
                    case ThucDon.TimSoNguyenXuatHienItNhat:
                        NhapTufile();
                        XuatMang();
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("So nguyen xuat hien it nhat la \n: {0}",DemSoLanXuatHienItNhat());
                        break;
                    case ThucDon.TimViTriSoLonNhat:
                        NhapTufile();
                        XuatMang();
                        break;
                    case ThucDon.TimViTriSoNhoNhat:
                        break;
                    case ThucDon.TimTatCaSoChan:
                        break;
                    case ThucDon.TImTatCaSoLe:
                        break;
                    case ThucDon.KiemTraPhanTuXCoTrongMangKhong:
                        break;
                    case ThucDon.XoaPhanTuTaiViTriX:
                        break;
                    case ThucDon.SapXepMangTheoChieuTang:
                        break;
                    case ThucDon.SapXepMangTheoChieuGiam:
                        break;
                    case ThucDon.Thoat:
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }



        }
        static void NhapTufile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            string[] s = line.Split(' ');
            foreach (var c in s)
            {
                a.Add(int.Parse(c));
            }
        }
        static void XuatMang()
        {
            Console.WriteLine("Danh sach cac phan tu");
            foreach (int i in a)
            {
                Console.WriteLine("{0}", i+" ");
            }
        }
        static int DemSoLanXuatHien(int x)
        {
            int dem = 0;
            foreach (var item in a)
            {
                if (item == x)
                    dem++;
            }
            return dem;
        }
        static int DemSoLanXuatHienNhieuNhat()
        {
            int max = 0;
            foreach (var item in a)
            {
                if (DemSoLanXuatHien(item) > max)
                {
                    max = DemSoLanXuatHien(item);
                }
            }
            return max;

        }
        static int DemSoLanXuatHienItNhat()
        {
            int min = int.MaxValue;
            foreach (var item in a)
            {
                if (DemSoLanXuatHien(item)<min)
                {
                    min = DemSoLanXuatHien(item);
                }
            }
            return min;
        }

    }
}
