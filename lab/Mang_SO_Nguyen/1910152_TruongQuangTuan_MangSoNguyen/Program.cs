using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_danh_sach_ho_ten
{
    class Program
    {

        enum ThucDon
        {
            TimTenXuatHienNhieuNhat = 1,
            TimTenXuatHienItNhat,
            TimTenDaiNhat,
            TimTenNganNhat,
            TimTenBatDauBangKyTuX,
            TimDSTenCoHoDemDaiNhat,
            TimDSTenCoHoDemNganNhat,
            TimDSTenKhongCoHoDem,
            ThayTheTenXbangY,
            HienThiDanhSachTheoChieuTangCuaHo,
            HienThiDanhSachTheoTangChieuDaiCuaTen,
            TimHoCoTuanSuatXuatHienLaXLan,
            Thoat = 13
        }


        static void Main(string[] args)
        {
            string[] ds = new string[]
            {
                    "Nguyen Duc Anh",
                    "Hoang Thi Phuong",
                    "Bui Tien Dung",
                    "Nguyen Cong Binh",
                    "Nguyen Van Toan",
                    "Nguyen Van Huan",
                    "Mai Tien Quang",
                    "Pham Tuan",
                    "Truong Quang Tuan",
                    "Hoang Ha",
                    "Van Mai Dung",
                    "Tran Dinh Dung"
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Nhap {0} de tim ten xuat hien nhieu nhat ", (int)ThucDon.TimTenXuatHienNhieuNhat);
                Console.WriteLine("Nhap {0} de tim ten xuat hien it nhat", (int)ThucDon.TimTenXuatHienItNhat);
                Console.WriteLine("Nhap {0} de tim ten dai nhat ", (int)ThucDon.TimTenDaiNhat);
                Console.WriteLine("Nhap {0} de tim ten ngan nhat", (int)ThucDon.TimTenNganNhat);
                Console.WriteLine("Nhap {0} de tim ten bat dau bang ki tu X", (int)ThucDon.TimTenBatDauBangKyTuX);
                Console.WriteLine("Nhap {0} de tim DS ten co ho dem DAI nhat", (int)ThucDon.TimDSTenCoHoDemDaiNhat);
                Console.WriteLine("Nhap {0} de tim DS ten co ho dem NGAN nhat", (int)ThucDon.TimDSTenCoHoDemNganNhat);
                Console.WriteLine("Nhap {0} de tim DS ten khong co HO DEM", (int)ThucDon.TimDSTenKhongCoHoDem);
                Console.WriteLine("Nhap {0} de thay the ten X bang ten Y", (int)ThucDon.ThayTheTenXbangY);
                Console.WriteLine("Nhap {0} de hien thi danh sach theo chieu tang cua HO", (int)ThucDon.HienThiDanhSachTheoChieuTangCuaHo);
                Console.WriteLine("Nhap {0} de hien thi danh sach theo tang chieu dai cua TEN", (int)ThucDon.HienThiDanhSachTheoTangChieuDaiCuaTen);
                Console.WriteLine("Nhap {0} de tim ho co tuan suat xuat hien la X lan", (int)ThucDon.TimHoCoTuanSuatXuatHienLaXLan);
                Console.WriteLine("Nhap {0} de thoat chuong trinh", (int)ThucDon.Thoat);
                ThucDon nhap = (ThucDon)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case ThucDon.TimTenXuatHienNhieuNhat:
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        DemSoLanXuatHienNhieuNhatCuaTen(ds);
                        break;
                    case ThucDon.TimTenXuatHienItNhat:
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        DemSoLanXuatHienItNhatCuaTen(ds);
                        break;
                    case ThucDon.TimTenDaiNhat:
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("Ten dai nhat la {0}", TimTenDaiNhat(ds));
                        break;
                    case ThucDon.TimTenNganNhat:
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("ten ngan nhat la {0}", TimTenNganNhat(ds));
                        break;
                    case ThucDon.TimTenBatDauBangKyTuX:
                        string kytu;
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.Write("Ban muon tim ten bat dau bang ky tu: ");
                        kytu = Console.ReadLine();
                        TimTenBangKyTu(ds, kytu);
                        break;
                    case ThucDon.TimDSTenCoHoDemDaiNhat:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("\nDanh sach cac ten co ho dem dai nhat: ");
                        Console.WriteLine("===================================");
                        TimTenCoHoDemDaiNhat(ds);
                        Console.WriteLine("===================================");
                        break;
                    case ThucDon.TimDSTenCoHoDemNganNhat:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("\nDanh sach cac ten co ho dem ngan nhat: ");
                        Console.WriteLine("===================================");
                        TimTenCoHoDemNganNhat(ds);
                        Console.WriteLine("===================================");
                        break;
                    case ThucDon.TimDSTenKhongCoHoDem:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("\nDanh sach cac ten khong co ho dem: ");
                        Console.WriteLine("===================================");
                        TimTenKhongCoHoDem(ds);
                        Console.WriteLine("===================================");
                        break;
                    case ThucDon.ThayTheTenXbangY:
                        break;
                    case ThucDon.HienThiDanhSachTheoChieuTangCuaHo:
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        HienThiDSTheoChieuTangCuaHo(ds);
                        break;
                    case ThucDon.HienThiDanhSachTheoTangChieuDaiCuaTen:
                        break;
                    case ThucDon.TimHoCoTuanSuatXuatHienLaXLan:
                        break;
                    case ThucDon.Thoat:
                        return;

                }
                Console.ReadKey();
            }

        }
        static void XuatDanhSach(string[] ds)
        {
            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);
        }

        //10
        enum KieuSapXep
        {
            TangCuaHo,
            TangChieuDaiCuaTen,
            TangCuaTen,
            GiamCuaTen
        }
        static string LayHo(string hoVaTen)
        {
            hoVaTen = hoVaTen.Trim();
            int vt = hoVaTen.IndexOf(' ');
            return hoVaTen.Substring(0, vt);
        }
        static int SoSanh(string a, string b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangCuaHo)
            {
                return LayHo(a).CompareTo(LayHo(b));
            }
            return -LayHo(a).CompareTo(LayHo(b));
        }
        static void SapXep(string[] ds, KieuSapXep kieu)
        {
            for (int i = 0; i < ds.Length - 1; i++)
                for (int j = i + 1; j < ds.Length; j++)
                {
                    if (SoSanhTen(ds[i], ds[j], kieu) == 1)
                    {
                        string tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
        }

        static void HienThiDSTheoChieuTangCuaHo(string[] ds)
        {
            SapXep(ds, KieuSapXep.TangCuaHo);
            XuatDanhSach(ds);
        }

        static void GiamCuaTen(string[] ds)
        {
            SapXep(ds, KieuSapXep.GiamCuaTen);
            XuatDanhSach(ds);
        }



        //1
        static string LayTen(string hoVaTen)
        {
            hoVaTen = hoVaTen.Trim();
            int vt = hoVaTen.LastIndexOf(' ');
            vt++;
            return hoVaTen.Substring(vt, hoVaTen.Length - vt);
        }

        //sap xep ten
        static int SoSanhTen(string a, string b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangCuaTen)
            {
                return LayTen(a).CompareTo(LayTen(b));
            }
            return -LayTen(a).CompareTo(LayTen(b));
        }   


        static void TangTheoTen(string[] ds)
        {
            SapXep(ds, KieuSapXep.TangCuaTen);
            XuatDanhSach(ds);
        }



        static void DemSoLanXuatHienNhieuNhatCuaTen(string[] ds)
        {
            int dem = 1;
            int max = 0;
            TangTheoTen(ds);
            string a = "a";
            for (int i = 0; i < ds.Length - 1; i++)
                for (int j = i + 1; j < ds.Length; j++)
                {
                    if ((LayTen(ds[i])) == (LayTen(ds[j])))
                    {
                        dem = dem + 1;
                    }
                    if (dem >= max && LayTen(ds[i]) != LayTen(ds[j]))
                    {

                        max = dem;
                        dem = 1;
                        a = LayTen(ds[i]);
                    }
                }

            Console.WriteLine("Ten xuat hien nhieu nhat la {0}, so lan xuat hien la {1}", a, max);
        }


        //2

        static void DemSoLanXuatHienItNhatCuaTen(string[] ds)
        {
            int dem = 1;
            int min = 30;
            GiamCuaTen(ds);
            string a = "a";
            for (int i = 0; i < ds.Length - 1; i++)
                for (int j = i + 1; j < ds.Length; j++)
                {
                    if ((LayTen(ds[i])) == (LayTen(ds[j])))
                    {
                        dem = dem + 1;
                    }
                    if (dem <= min && LayTen(ds[i]) != LayTen(ds[j]))
                    {

                        min = dem;
                        dem = 1;
                        a = LayTen(ds[i]);
                    }
                }

            Console.WriteLine("Ten xuat hien nhieu nhat la {0}, so lan xuat hien la {1}", a, min);
        }

        //3,4

        static string TimTenDaiNhat(string[] ds)
        {
            string ten = LayTen(ds[0]);
            for (int i = 0; i < ds.Length - 1; i++)
            {
                if ((LayTen(ds[i]).Length) >= ten.Length)
                {
                    ten = LayTen(ds[i]);
                }
            }
            return ten;
        }
        static string TimTenNganNhat(string[] ds)
        {
            string ten = LayTen(ds[0]);
            for (int i = 0; i < ds.Length - 1; i++)
            {
                if ((LayTen(ds[i]).Length) <= ten.Length)
                {
                    ten = LayTen(ds[i]);
                }
            }
            return ten;
        }

        //5

        static void TimTenBangKyTu(string[] ds, string kytu)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                if ((LayTen(ds[i]).Substring(0, 2)) == kytu)
                {
                    Console.WriteLine("Ten bat dau bang ky tu {0} la: {1}", kytu, ds[i]);
                }
            }
        }
        //6,7,8

        static string LayHoDem(string hoVaTen)
        {
            hoVaTen.Trim();
            int vt = hoVaTen.IndexOf(' ');
            hoVaTen = hoVaTen.Remove(0, vt + 1);
            int vt2 = hoVaTen.LastIndexOf(' ');
            return hoVaTen = hoVaTen.Remove(vt2 + 1);
        }
        static void TimTenCoHoDemDaiNhat(string[] ds)
        {
            string hodem = LayHoDem(ds[0]);
            int dem = 1;
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length >= hodem.Length)
                {
                    dem = LayHoDem(ds[i]).Length;
                }
            }
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length == dem)
                    Console.WriteLine("{0}", ds[i]);
            }
        }
        static void TimTenCoHoDemNganNhat(string[] ds)
        {
            string hodem = LayHoDem(ds[0]);
            int dem = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length <= hodem.Length && LayHoDem(ds[i]).Length != 0)
                    dem = LayHoDem(ds[i]).Length;
            }
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length == dem)
                    Console.WriteLine("{0}", ds[i]);
            }
        }
        static void TimTenKhongCoHoDem(string[] ds)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length == 0)
                    Console.WriteLine("{0}", ds[i]);
            }
        }
    }
}