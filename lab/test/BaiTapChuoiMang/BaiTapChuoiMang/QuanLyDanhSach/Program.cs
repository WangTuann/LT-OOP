using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace QuanLyDanhSach
{
    class Program
    {
        enum ThucDon
        {
            DemHo,
            XuatDanhSach,
            HienThiTheoChieuTangCuaTen,
            HienThiTheoChieuGiamCuaTen,
            TenXuatHienNhieuNhat,
            TenXuatHienItNhat,
            TimTenDaiNhat,
            TimTenNganNhat,
            TimTenBangKyTu,
            DanhSachTenCoHoDemDaiNhat,
            DanhSachTenCoHoDemNganNhat,
            DanhSachTenKhongCoHoDem,
            ThayTheTen,
            HienThiTheoChieuTangCuaHo,
            Thoat = 14,
        }
        static void Main(string[] args)
        {
            string[] ds = new string[]
            {
                "Nguyen Duc Bao",
                "Hoang Thi Phuong",
                "Bui Tien Dung",
                "Nguyen Cong Binh",
                "Nguyen Van Toan",
                "Phan Duy Anh",
                "Nguyen Van Phuong Anh",
                "Dao Duy Phuong Anh",
                "Nguyen An",
                "Dao Hai",
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==========================================================");
                Console.WriteLine("Nhap {0} de dem so ho xuat hien.",(int)ThucDon.DemHo);
                Console.WriteLine("Nhap {0} de hien thi danh sach.",(int)ThucDon.XuatDanhSach);
                Console.WriteLine("Nhap {0} de hien thi theo chieu tang cua ten.",(int)ThucDon.HienThiTheoChieuTangCuaTen);
                Console.WriteLine("Nhap {0} de hien thi theo chieu giam cua ten.",(int)ThucDon.HienThiTheoChieuGiamCuaTen);
                Console.WriteLine("Nhap {0} de dem ten xuat hien nhieu nhat.", (int)ThucDon.TenXuatHienNhieuNhat);
                Console.WriteLine("Nhap {0} de dem ten xuat hien it nhat.", (int)ThucDon.TenXuatHienItNhat);
                Console.WriteLine("Nhap {0} de tim ten dai nhat.", (int)ThucDon.TimTenDaiNhat);
                Console.WriteLine("Nhap {0} de tim ten ngan nhat.", (int)ThucDon.TimTenNganNhat);
                Console.WriteLine("Nhap {0} de tim ten bang ky tu.", (int)ThucDon.TimTenBangKyTu);
                Console.WriteLine("Nhap {0} de hien thi danh sach ten co ho dem dai nhat.", (int)ThucDon.DanhSachTenCoHoDemDaiNhat);
                Console.WriteLine("Nhap {0} de hien thi danh sach ten co ho dem ngan nhat.", (int)ThucDon.DanhSachTenCoHoDemNganNhat);
                Console.WriteLine("Nhap {0} de hien thi danh sach ten khong co ho dem.", (int)ThucDon.DanhSachTenKhongCoHoDem);
                Console.WriteLine("Nhap {0} de thay the ten x bang ten y.", (int)ThucDon.ThayTheTen);
                Console.WriteLine("Nhap {0} de hien thi danh sach theo chieu tang cua ho.", (int)ThucDon.HienThiTheoChieuTangCuaHo);
                Console.WriteLine("Nhap {0} de thoat",(int)ThucDon.Thoat);
                Console.WriteLine("==========================================================");
                Console.Write("\n");
                Console.Write("Nhap vao chuc nang ban muon chon: ");
                ThucDon nhap = (ThucDon)int.Parse(Console.ReadLine());
                switch(nhap)
                {
                    case ThucDon.DemHo:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.Write("Nhap vao ho ban muon dem: ");
                        string ho = Console.ReadLine();
                        Console.WriteLine("Ho {0} xuat hien {1} lan.", ho,DemXuatHienHo(ds,ho));
                        break;
                    case ThucDon.XuatDanhSach:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        break;
                    case ThucDon.HienThiTheoChieuTangCuaTen:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Danh sach nhan vien da sap xep: ");
                        Console.WriteLine("===================================");
                        TangTheoTen(ds);
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        break;
                    case ThucDon.HienThiTheoChieuGiamCuaTen:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Danh sach nhan vien da sap xep: ");
                        Console.WriteLine("===================================");
                        GiamTheoTen(ds);
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        break;
                    case ThucDon.TenXuatHienNhieuNhat:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        DemTenXuatHienNhieuNhat(ds);
                        break;
                    case ThucDon.TenXuatHienItNhat:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        DemTenXuatHienItNhat(ds);
                        break;
                    case ThucDon.TimTenDaiNhat:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ten dai nhat la: {0}", TimTenDaiNhat(ds));
                        break;
                    case ThucDon.TimTenNganNhat:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ten ngan nhat la: {0}", TimTenNganNhat(ds));
                        break;
                    case ThucDon.TimTenBangKyTu:
                        string kytu;
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.Write("Ban muon tim ten bat dau bang ky tu: ");
                        kytu = Console.ReadLine();
                        TimTenBangKyTu(ds, kytu);
                        break;
                    case ThucDon.DanhSachTenCoHoDemDaiNhat:
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
                    case ThucDon.DanhSachTenCoHoDemNganNhat:
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
                    case ThucDon.DanhSachTenKhongCoHoDem:
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
                    case ThucDon.ThayTheTen:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.Write("Nhap vao ten can thay the: ");
                        string a = Console.ReadLine();
                        Console.Write("Nhap vao ten thay the: ");
                        string b = Console.ReadLine();
                        ThayThe(ds, a, b);
                        break;
                    case ThucDon.HienThiTheoChieuTangCuaHo:
                        Console.Clear();
                        Console.WriteLine("Danh sach nhan vien hien hanh: ");
                        Console.WriteLine("===================================");
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Danh sach nhan vien da sap xep: ");
                        Console.WriteLine("===================================");
                        TangTheoHo(ds);
                        XuatDanhSach(ds);
                        Console.WriteLine("===================================");
                        break;
                    case ThucDon.Thoat:
                        return;
                }
                Console.ReadKey();
            }
        }
        static void XuatDanhSach(string[] ds)
        {
            for (int i =0; i< ds.Length;i++)
                Console.WriteLine(ds[i]);
        }
        static string LayTen(string hoVaTen)
        {
            hoVaTen = hoVaTen.Trim();
            int vt = hoVaTen.LastIndexOf(' ');
            vt = vt + 1;
            return hoVaTen = hoVaTen.Substring(vt, hoVaTen.Length - vt);
        }
        enum KieuSapXep
        {
            TangTheoTen,
            GiamTheoTen,
            TangTheoHo,
            GiamTheoHo
        }
        static int SoSanh(string a, string b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoTen)
            {
                return LayTen(a).CompareTo(LayTen(b));
            }
            return -LayTen(a).CompareTo(LayTen(b));
        }
        static void SapXep(string[] ds,KieuSapXep kieu)
        {
            for (int i = 0; i < ds.Length - 1; i++)
                for (int j = i + 1; j < ds.Length; j++) 
                {
                    if (SoSanh(ds[i], ds[j], kieu) == 1) 
                    {
                        string tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
        }
        static void TangTheoTen(string[] ds)
        {
            SapXep(ds, KieuSapXep.TangTheoTen);
        }
        static void GiamTheoTen(string[] ds)
        {
            SapXep(ds, KieuSapXep.GiamTheoTen);
        }
        static string LayHo(string hoVaTen)
        {
            hoVaTen= hoVaTen.Trim();
            int vt = hoVaTen.IndexOf(' ');
            hoVaTen = hoVaTen.Substring(0, vt);
            return hoVaTen;
        }
        static int DemXuatHienHo(string[] ds, string a)
        {
            int dem = 0;
            for (int i=0; i<ds.Length;i++)
            {
                    if (LayHo(ds[i]) == a)
                            dem = dem + 1;
            }
            return dem;
        }
        static void DemTenXuatHienNhieuNhat(string[] ds)
        {
            int dem = 1, max = 0;
            string str = "a";
            TangTheoTen(ds);
            for (int i = 0; i <= ds.Length-1; i++)
                for (int j = i+1; j < ds.Length; j++) 
                {
                    if (LayTen(ds[i]) == LayTen(ds[j]))
                    {
                        dem = dem + 1;
                    }
                    if (dem >= max && LayTen(ds[i]) != LayTen(ds[j]))
                    {
                        max = dem;
                        dem = 1;
                        str = LayTen(ds[i]);
                    }
                }
            Console.WriteLine("Ten xuat hien nhieu nhat la: {0}, so lan xuat hien: {1}",str,  max);
        }
        static void DemTenXuatHienItNhat(string[] ds)
        {
            int dem = 1, min = 100;
            string str = "a";
            GiamTheoTen(ds);
            for (int i = 0; i <= ds.Length - 1; i++)
                for (int j = i + 1; j < ds.Length; j++)
                {
                    if (LayTen(ds[i]) == LayTen(ds[j]))
                    {
                        dem = dem + 1;
                    }
                    if (dem <= min && LayTen(ds[i]) != LayTen(ds[j]))
                    {
                        min = dem;
                        dem = 1;
                        str = LayTen(ds[i]);
                    }
                }
                Console.WriteLine("Ten xuat hien it nhat la: {0}, xuat hien {1} lan.", str, min);
        }
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
        static void TimTenBangKyTu(string [] ds, string kytu)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                if ((LayTen(ds[i]).Substring(0,1)) == kytu)
                {
                    Console.WriteLine("Ten bat dau bang ky tu {0} la: {1}",kytu, ds[i]);
                }
            }
        }
        static string LayHoDem(string hoVaTen)
        {
            hoVaTen.Trim();
            int vt = hoVaTen.IndexOf(' ');
            hoVaTen = hoVaTen.Remove(0,vt+1);
            int vt2 = hoVaTen.LastIndexOf(' ');
            return hoVaTen = hoVaTen.Remove(vt2+1);
        }
        static void TimTenCoHoDemDaiNhat(string [] ds)
        {
            string hodem = LayHoDem(ds[0]);
            int dem = 1;
            for (int i= 0;i<ds.Length;i++)
            {
                if (LayHoDem(ds[i]).Length>=hodem.Length)
                {
                    dem = LayHoDem(ds[i]).Length;
                }
            }
            for (int i = 0;i<ds.Length;i++)
            {
                if (LayHoDem(ds[i]).Length == dem)
                    Console.WriteLine("{0}",ds[i]);
            }
        }
        static void TimTenCoHoDemNganNhat(string [] ds)
        {
            string hodem = LayHoDem(ds[0]);
            int dem = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length <= hodem.Length && LayHoDem(ds[i]).Length !=0)
                    dem = LayHoDem(ds[i]).Length;
            }
            for (int i =0;i <ds.Length;i++)
            {
                if (LayHoDem(ds[i]).Length == dem)
                    Console.WriteLine("{0}",ds[i]);
            }
        }
        static void TimTenKhongCoHoDem(string [] ds)
        {
            for (int i = 0; i< ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length == 0)
                    Console.WriteLine("{0}",ds[i]);
            }
        }
        static void ThayThe(string [] ds, string a, string b)
        {
            string hoten = ds[0];
            for (int i = 0; i< ds.Length;i++)
            {
                if (LayTen(ds[i])== a)
                {
                    hoten = ds[i].Replace(LayTen(ds[i]), b);
                    Console.WriteLine("{0}",hoten);
                }
            }
        }
        static int SoSanhHo(string a, string b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoHo)
            {
                return LayHo(a).CompareTo(LayHo(b));
            }
            return -LayHo(a).CompareTo(LayHo(b));
        }
        static void SapXepHo(string[] ds, KieuSapXep kieu)
        {
            for (int i = 0; i < ds.Length - 1; i++)
                for (int j = i + 1; j < ds.Length; j++)
                {
                    if (SoSanhHo(ds[i], ds[j], kieu) == 1)
                    {
                        string tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
        }
        static void TangTheoHo(string [] ds)
        {
            SapXepHo(ds, KieuSapXep.TangTheoHo);
        }
    }
}
