using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopDoiTuong_DS_SinhVIen
{
    class SinhVien
    {
        public string maSV;
        public string tenSV;
        public Boolean gioiTinh;
        private string lop;

        public string Lop
        {
            get { return lop; }
            set { lop = value.Trim(); }
        }
        public float diemTB;

        public SinhVien(string ma, string ten, string l, float diem, bool gt)
        {
            maSV = ma;
            tenSV = ten;
            diemTB = diem;
            gioiTinh = gt;
            lop = l;

        }
        public SinhVien(string line)
        {
            string[] str = line.Split(',');
            maSV = str[0];
            tenSV = str[1];
            diemTB = float.Parse(str[2]);
            gioiTinh = str[3] == "Nam" ? true : false;
            lop = str[4];
        }




        public void Nhap()
        {
            Console.WriteLine("Nhap ma so sinh vien: ");
            maSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            tenSV = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh: ");
            float.TryParse(Console.ReadLine(), out diemTB);
            Console.WriteLine("Nhap lop: ");
            lop = Console.ReadLine();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2},{3},{4}", maSV, tenSV, diemTB, lop, gioiTinh);
        }
    }
}
