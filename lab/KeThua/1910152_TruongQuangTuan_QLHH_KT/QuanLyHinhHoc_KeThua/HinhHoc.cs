using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHinhHoc_KeThua
{
    abstract class HinhHoc
    {
        public abstract float TinhChuVi();
        public abstract float TinhDienTich();

    }

    class HinhTron:HinhHoc
    {
        private float banKinh;

        public float BanKinh { get => banKinh; set => banKinh = value; }
        public HinhTron()
        {

        }
        public HinhTron(float banKinh)
        {
            this.banKinh=banKinh;
        }

        public override float TinhChuVi()
        {
            return (float)Math.PI * banKinh * 2;
        }

        public override float TinhDienTich()
        {
            return (float)Math.PI * banKinh * banKinh;
        }
        public override string ToString()
        {
            return string.Format("ban kinh hinh tron la :{0}\n Chi vi hinh tron la:{1}\n Dien tich hinh tron la:{2}", banKinh, TinhChuVi(), TinhDienTich());
        }
    }
    class HinhVuong : HinhHoc
    {
        private float canh;

        public HinhVuong()
        {

        }
        public float Canh { get => canh; set => canh = value; }

        public HinhVuong(float canh)
        {
            this.canh = canh;
        }
        public override float TinhChuVi()
        {
            return canh*4;
        }
        public override float TinhDienTich()
        {
            return canh * canh;
        }

        public override string ToString()
        {
            return string.Format("Do dai canh hinh vuong:{0}\n Chu vi hinh vuong:{1}\n Dien tich hinh vuong:{2} \n", canh, TinhChuVi(), TinhDienTich());
        }
    }
    class HinhChuNhat:HinhHoc
    {
        private float chieuDai, chieuRong;

        public  HinhChuNhat()
        {

        }
        public float ChieuDai { get => chieuDai; set => chieuDai = value; }
        public float ChieuRong { get => chieuRong; set => chieuRong = value; }

        public HinhChuNhat(float chieuDai, float chieuRong)
        {
            this.chieuRong = chieuRong;
            this.chieuDai = chieuDai;
        }

        public override float TinhChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }
        public override float TinhDienTich()
        {
            return chieuRong * chieuDai;
        }
        public override string ToString()
        {
            return string.Format("Chieu dai HCN:{0}\n Chieu rong HCN:{1}\n Chu vi HCN:{2}\n Dien tich HCN:{3}", chieuDai, chieuRong, TinhChuVi(), TinhDienTich());
        }
    }

}
