using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhTron
    {
        public float BanKinh;
        public float BK
        {
            get { return BanKinh; }
            set { BanKinh = value; }
        }
        private float chuVi;
        public float CV
        {
            get { return chuVi; }
            set { chuVi = value; }
        }
        private float dienTich;
        public float DT
        {
            get { return dienTich; }
            set { dienTich = value; }
        }
        public void TinhChuVi()
        {
            CV = BanKinh * 2 * (float)Math.PI;
        }
        public void TinhDienTich()
        {
            DT = BanKinh * BanKinh * (float)Math.PI;
        }

        public HinhTron(float d)
        {
            BK = BanKinh;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", BanKinh, chuVi, dienTich);
        }
    }
}
