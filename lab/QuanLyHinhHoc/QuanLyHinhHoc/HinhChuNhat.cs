using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhChuNhat
    {
        public float chieuDai;
        public float dai
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        public float chieuRong;
        public float rong
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        private float DienTich;
        public float DT
        {
            get { return DienTich; }
            set { DienTich = value; }
        }
        private float ChuVi;
        public float CV
        {
            get { return ChuVi; }
            set { ChuVi = value; }
        }
        public void TinhChuVi()
        {
            CV = (dai + rong) * 2;
        }
        public void TinhDienTich()
        {
            DT = dai * rong;
        }

        public HinhChuNhat(float dai, float rong)
        {
            chieuDai = dai;
            chieuRong = rong;
            TinhChuVi();
            TinhDienTich();
        }
        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap vao chieu dai cua HCN");
                dai = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao chieu rong cua HCN");
                rong = float.Parse(Console.ReadLine());
            } while (dai<0||rong<0);
            TinhChuVi();
            TinhDienTich();
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", chieuRong, chieuDai, ChuVi, DienTich);
        }
    }
}
