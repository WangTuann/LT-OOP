using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLopDoiTuong2
{
    class SinhVien
    {
        public string maSV;
        public string hoTen;
        public double dTB;
        public string lop;
        public string gioiTinh;
        public bool gioiTinhNam=true;

        public SinhVien(string ma, string ho, double dtb,string lp,string gioit)
        {
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
            lop = lp;
            gioiTinh = gioit;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma so sinh vien: ");
            maSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh: ");
            double.TryParse(Console.ReadLine(), out dTB);
            Console.WriteLine("Nhap lop: ");
            lop = Console.ReadLine();
        }
        public override string ToString()
        {
            return string.Format("Ma so: {0}, Ho ten: {1}, Diem: {2}, Lop: {3}, Gioi tinh: {4}", maSV, hoTen, dTB, lop, gioiTinh);
        }
    }
}
