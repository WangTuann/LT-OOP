using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopDoiTuong_DS_SinhVIen
{
    class Program
    {
     
        enum ThucDon
        {
            DemSoSinhVienNam = 1,
            DemSoSinhVienNu,
            HienThiDanhSachTheoChieuTangCuaDTB,
            HienThiDanhSachTHeoCHieuGiamCuaDTB,
            TimDSSVCoDTBCaoNhat,
            TimDSSVKhongCoDTBCaoNhat,
            HienThiDSSVTheoLopVaChieuGiamCuaDTB,
            XepHangSV,
            TimLopCoTongDiemTBCaoNhatThapNhat,
            TimLopCoNhieuHSGioiNhat,
            TimLopCoNhieuHSTheoLoaiYeu, TrungBinh, Kha,
            Thoat = 14
        }
        static void Main(string[] args)

        {
            QuanLySinhVien cntt = new QuanLySinhVien();
            cntt.NhapTuFile();
            Console.WriteLine("DANH SACH SINH VIEN");
            Console.WriteLine(cntt);
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Nhap {0} de dem so sinh vien nam ", (int)ThucDon.DemSoSinhVienNam);
                Console.WriteLine("Nhap {0} de dem so sinh vien nu ", (int)ThucDon.DemSoSinhVienNu);
                Console.WriteLine("Nhap {0} de hien thi danh sach theo chieu tang cua DTB", (int)ThucDon.HienThiDanhSachTheoChieuTangCuaDTB);
                Console.WriteLine("Nhap {0} de hien thi danh sach theo chieu giam cua DTB", (int)ThucDon.HienThiDSSVTheoLopVaChieuGiamCuaDTB);
                Console.WriteLine("Nhap {0} de tim DSSV co DTB cao nhat", (int)ThucDon.TimDSSVCoDTBCaoNhat);
                Console.WriteLine("Nhap {0} de tim DSSV co DTB thap nhat", (int)ThucDon.TimDSSVKhongCoDTBCaoNhat);
                Console.WriteLine("Nhap {0} de hien thi DSSV theo lop va chieu giam cau DTB", (int)ThucDon.HienThiDSSVTheoLopVaChieuGiamCuaDTB);
                Console.WriteLine("Nhap {0} de xep hang SV", (int)ThucDon.XepHangSV);
                Console.WriteLine("Nhap {0} de tim lop co tong diem TB cai nhat/thap nhat", (int)ThucDon.TimLopCoTongDiemTBCaoNhatThapNhat);
                Console.WriteLine("Nhap {0} de tim lop co nhieu hoc sinh gioi nhat", (int)ThucDon.TimLopCoNhieuHSGioiNhat);
                Console.WriteLine("Nhap {0} de tim lop co nhieu HS theo loai yeu", (int)ThucDon.TimLopCoNhieuHSTheoLoaiYeu);
                Console.WriteLine("Nhap {0} de tim lop co nhieu HS theo loai kha", (int)ThucDon.Kha);
                Console.WriteLine("Nhap {0} de tim lop co nhieu HS theo loai trung binh", (int)ThucDon.TrungBinh);
                Console.WriteLine("Nhap {0} de thoat", (int)ThucDon.Thoat);
                ThucDon nhap = (ThucDon)int.Parse(Console.ReadLine());

                switch (nhap)
                {
                    case ThucDon.DemSoSinhVienNam:
                        Console.WriteLine("So luong sinh vien nam la :{0}", cntt.DemSoLuongSVNam());
                        break;
                    case ThucDon.DemSoSinhVienNu:
                        Console.WriteLine("So luong sinh vien nu la: {0}", cntt.DemSoLuongSVNu());
                        break;
                    case ThucDon.HienThiDanhSachTheoChieuTangCuaDTB:
                        Console.WriteLine(cntt.SapTang());                     
                        break;
                    case ThucDon.HienThiDanhSachTHeoCHieuGiamCuaDTB:
                        Console.WriteLine("DS sau khi sap xep {0}",cntt.SapGiam());
                        break;
                    case ThucDon.TimDSSVCoDTBCaoNhat:
                        break;
                    case ThucDon.TimDSSVKhongCoDTBCaoNhat:
                        break;
                    case ThucDon.HienThiDSSVTheoLopVaChieuGiamCuaDTB:
                        break;
                    case ThucDon.XepHangSV:
                        break;
                    case ThucDon.TimLopCoTongDiemTBCaoNhatThapNhat:
                        break;
                    case ThucDon.TimLopCoNhieuHSGioiNhat:
                        break;
                    case ThucDon.TimLopCoNhieuHSTheoLoaiYeu:
                        break;
                    case ThucDon.TrungBinh:
                        break;
                    case ThucDon.Kha:
                        break;
                    case ThucDon.Thoat:
                        return;
                }
            }
            Console.ReadKey();
        }
    }
}
       