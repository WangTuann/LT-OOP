using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class DanhSachHinhVuong
    {
        List<HinhVuong> danhSachHinhVuong = new List<HinhVuong>();
        public HinhVuong this[int i]
        {
            get { return danhSachHinhVuong[i]; }
        }
        public void Them(HinhVuong hv)
        {
            danhSachHinhVuong.Add(hv);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in danhSachHinhVuong)
            {
                line += item + "\n";
            }
            return line;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        private float TimDienTichMax()
        {
            float max = float.MinValue;
            foreach (var item in danhSachHinhVuong)
            {
                if (item.dienTich>max)
                {
                    max = item.dienTich;
                }
            }
            return max;
        }
        public DanhSachHinhVuong TimDTMax()
        {
            DanhSachHinhVuong kq = new DanhSachHinhVuong();
            float max = TimDienTichMax();
            foreach (var item in danhSachHinhVuong)
            {
                if (item.dienTich==max)
                {
                    kq.Them(item);
                }
            }
            return kq;
        }
    }
}
