using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhVuong
    {
        public float doDaiCanh;
        public float canh
        {
            get
            { return canh; }
            set
            { canh = value; }
        }
        public float chuVi;
        public float CV
        {
            get { return chuVi; }
            set { chuVi = value; }
        }
        public float dienTich;
        public float DT
        {
            get { return dienTich; }
            set { dienTich = value; }
        }

        public HinhVuong(float a)
        {
            doDaiCanh = a;
            TinhChuVi();
            TinhDienTich();

        }

        public void Nhap()
        {
            do
            {
                Console.WriteLine("nhap do dai canh");
                doDaiCanh = float.Parse(Console.ReadLine());
            } while (doDaiCanh<0);
            TinhChuVi();
            TinhDienTich();

        }

        public float TinhDienTich()
        {
            return dienTich = doDaiCanh * doDaiCanh;
        }

        public float TinhChuVi()
        {
            return chuVi = doDaiCanh * 4;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1},{2}", doDaiCanh, chuVi, dienTich);
        }
    }
}
