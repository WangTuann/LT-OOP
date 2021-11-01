using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLopDoiTuong2
{
    class Program
    {
        enum Menu
        {
            XuatDanhSach,
            DemSoLuongSinhVienNamTrongLop,
            DemSoLuongSinhVienNuTrongLop,
            HienThiDanhSachSinhVienTheoChieuTangGiamCuaDiemTrungBinh,
            TimDanhSachSinhVienCoDiemTrungBinhCaoNhat,
            TimLopCoSinhVienCoDiemTrungBinhCaoNhat,
            TimLopCoSinhVienKhongCoDiemTrungBinhCaoNhat,
            HienThiDanhSachSinhVienTheoLopVaTheoChieuDaiCuaDiemTrungBinh,
            XepHangSinhVienCuaLop,
            TimLopCoTongDiemTrungBinhCaoNhatThapNhat,
            TimLopCoNhieuHocSinhGioiNhat,
            TimLopCoNhieuHocSinhYeuTBKha,

            ThoatChuongTrinh =12
        }
        static void Main(string[] args)
        {
            DanhSachSinhVien ctk43 = new DanhSachSinhVien();
            ctk43.NhapTuFile();
            Console.WriteLine("====================================");
            Console.WriteLine("Danh Sach Sinh Vien: ");
            Console.WriteLine("====================================");
            Console.WriteLine(ctk43);
            Console.WriteLine("====================================");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("================HE THONG MENU TUY CHON=====================");
                Console.WriteLine("===========================================================");
                Console.WriteLine("Nhap {0} de Xuat Danh Sach: ", (int)Menu.XuatDanhSach);
                Console.WriteLine("Nhap {0} de Dem so luong sinh vien nam trong lop", (int)Menu.DemSoLuongSinhVienNamTrongLop);
                Console.WriteLine("Nhap {0} de Dem so luong sinh vien nu trong lop", (int)Menu.DemSoLuongSinhVienNuTrongLop);
                Console.WriteLine("Nhap {0} de Hien thi danh sach sinh vien theo chieu tang giam cua diem trung binh", (int)Menu.HienThiDanhSachSinhVienTheoChieuTangGiamCuaDiemTrungBinh);
                Console.WriteLine("Nhap {0} de Tim danh sach sinh vien co diem trung binh cao nhat", (int)Menu.TimDanhSachSinhVienCoDiemTrungBinhCaoNhat);
                Console.WriteLine("Nhap {0} de Tim lop co sinh vien co diem trung binh coa nhat", (int)Menu.TimLopCoSinhVienCoDiemTrungBinhCaoNhat);
                Console.WriteLine("Nhap {0} de Tim lop co sinh vien khong co diem trung binh cao nhat",(int)Menu.TimLopCoSinhVienKhongCoDiemTrungBinhCaoNhat);
                Console.WriteLine("Nhap {0} de Hien thi danh sach sinh vien theo lop va theo chieu dai cua diem trung binh", (int)Menu.HienThiDanhSachSinhVienTheoLopVaTheoChieuDaiCuaDiemTrungBinh);
                Console.WriteLine("Nhap {0} de Xep hang sinh vien cua lop", (int)Menu.XepHangSinhVienCuaLop);
                Console.WriteLine("Nhap {0} de Tim lop co tong diem tung binh cao nhat, thap nhat", (int)Menu.TimLopCoTongDiemTrungBinhCaoNhatThapNhat);
                Console.WriteLine("Nhap {0} de Tim lop co nhieu hoc sinh gioi nhat", (int)Menu.TimLopCoNhieuHocSinhGioiNhat);
                Console.WriteLine("Nhap {0} de Tim lop co nhieu hoc sinh yeu, trung binh, kha nhat", (int)Menu.TimLopCoNhieuHocSinhYeuTBKha);
                Console.WriteLine("Nhap {0} de Thoat chuong trinh", (int)Menu.ThoatChuongTrinh);
                Console.WriteLine("===============================================================");

                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case Menu.XuatDanhSach:
                        {
                            Console.WriteLine("Danh Sach Sinh Vien: ");
                            Console.WriteLine("====================================");
                            Console.WriteLine(ctk43);
                            Console.WriteLine("====================================");
                        }
                        break;
                    case Menu.DemSoLuongSinhVienNamTrongLop:
                        {
                            Console.WriteLine("====So luong sinh vien nam trong lop la {0}",ctk43.DemSoSinhVienNam());
                               
                        }
                        break;
                    case Menu.DemSoLuongSinhVienNuTrongLop:
                        {
                            Console.WriteLine("====So luong sinh vien nu co trong lop la {0}", ctk43.DemSoLuongSinhVienNu());
                        }
                        break;
                    case Menu.HienThiDanhSachSinhVienTheoChieuTangGiamCuaDiemTrungBinh:
                        {
                            Console.WriteLine("Hien Thi Danh sach sinh vien theo chieu tang giam cua diem trung binh:====== ");
                            Console.WriteLine("===DANH SACH SINH VIEN THEO CHIEU TANG: ");
                            Console.WriteLine(ctk43.SapXepTheoDiemTrungBinhTang());
                            Console.WriteLine("========================================");
                            Console.WriteLine("===DANH SACH SINH VIEN THEO CHIEU GIAM: ");
                            Console.WriteLine(ctk43.SapXepTheoDiemTrungBinhGiam());
                            Console.WriteLine("========================================");
                        }
                        break;
                    case Menu.TimDanhSachSinhVienCoDiemTrungBinhCaoNhat:
                        {
                            Console.WriteLine("====Danh sach sinh vien co diem trung binh cao nhat====");
                            Console.WriteLine(ctk43.TimDSSVCoDTBCaoNhat());
                        }
                        break;
                    case Menu.TimLopCoSinhVienCoDiemTrungBinhCaoNhat:
                        {
                            Console.WriteLine("===Tim Lop Co sinh vien co diem trung binh cao nhat: ");
                            Console.WriteLine(ctk43.LopCoSinhVienCoDiemTrungBinhCaoNhat());
                        }
                        break;
                    case Menu.TimLopCoSinhVienKhongCoDiemTrungBinhCaoNhat:
                        {
                            Console.WriteLine("===Tim lop co sinh vien khong co diem trung binh cao nhat: ");
                            Console.WriteLine(ctk43.LopCoSinhVienKhongCoDiemTrungBinhCaoNhat());
                        }
                        break;
                    case Menu.HienThiDanhSachSinhVienTheoLopVaTheoChieuDaiCuaDiemTrungBinh:
                        {
                            Console.WriteLine("===Hien thi danh sach sinh vien theo lop va diem trung binh giam dan: ");
                            Console.WriteLine(ctk43.HienThiDanhSachSinhVienTheoLopvaDtb());
                            Console.WriteLine("--------------");
                            
                            
                        }
                        break;
                    case Menu.XepHangSinhVienCuaLop:
                        {
                            Console.WriteLine("===Xep hang sinh vien cua lop! ");
                            Console.WriteLine(ctk43.XepHang());
                        }
                        break;
                    case Menu.TimLopCoTongDiemTrungBinhCaoNhatThapNhat:
                        {
                            Console.WriteLine("Tim lop co tong diem trung binh cao nhat: ");
                            double[] DTB = new double[3] { ctk43.Ctk43().TinhTongDTBLop(),
                            ctk43.Lhk43().TinhTongDTBLop(),
                            ctk43.Qtk43().TinhTongDTBLop()};
                            double max = 0;
                            foreach (var item in DTB)
                            {
                                if (item > max)
                                    max = item;  
                            }
                            for (int i = 0; i < DTB.Length;i++ )
                            {
                                string[] vt=new string[] {"CTK43","LHK43","QTK43"};
                                if (DTB[i] == max)
                                    Console.WriteLine("Lop co tong diem trung binh cao nhat la: {0} voi tong diem trung binh la: {1} ", vt[i],max);
                            }
                        }
                        break;
                    case Menu.TimLopCoNhieuHocSinhGioiNhat:
                        {
                            Console.WriteLine("Tim lop co nhieu hoc sinh gioi nhat: ");
                            int[] dem = new int[] {ctk43.Ctk43().DemSoHocSinhGioi(),
                            ctk43.Lhk43().DemSoHocSinhGioi(),
                            ctk43.Qtk43().DemSoHocSinhGioi()};
                            int max = 0;
                            foreach (var item in dem)
                            {
                                if (item > max)
                                    max = item;
                            }
                            for(int i=0;i<dem.Length;i++)
                            {
                                string[] vt = new string[] { "CTK43", "LHK43", "QTK43" };
                                if (dem[i] == max)
                                    Console.WriteLine("Lop co nhieu hoc sinh gioi nhat la: {0} voi so hoc sinh gioi la: {1}", vt[i], max);
                            }
                        }
                        break;
                    case Menu.TimLopCoNhieuHocSinhYeuTBKha:
                        {
                            Console.WriteLine("Tim lop co nhieu hoc sinh yeu, trung binh, kha: ");
                            int[] dem = new int[] {ctk43.Ctk43().DemSoHocSinhYTBk(),
                            ctk43.Lhk43().DemSoHocSinhYTBk(),
                            ctk43.Qtk43().DemSoHocSinhYTBk()};
                            int max = 0;
                            foreach (var item in dem)
                            {
                                if (item > max)
                                    max = item;
                               
                            }
                            for(int i=0;i<dem.Length;i++)
                            {
                                string[] vt = new string[] { "CTK43", "LHK43", "QTK43" };
                                if (dem[i] == max)
                                    Console.WriteLine("Lop co nhieu hoc sinh yeu, trung binh, kha nhat la: {0} ", vt[i]);
                            }
                        }
                        break;
                    case Menu.ThoatChuongTrinh:
                        return;
                    
                }
                Console.ReadLine();
            }
            
        }
    }
}
