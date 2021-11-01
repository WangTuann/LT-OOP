using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopDoiTuong_DS_SinhVIen
{
    class QuanLySinhVien
    {
        List<SinhVien> ds = new List<SinhVien>();
        public void Them(SinhVien sv)
        {
            ds.Add(sv);
        }
         public void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine())!=null)
            {

                Them(new SinhVien(line));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MSSV".PadRight(6) + "Ho ten".PadRight(14) + "DTB".PadRight(2) +  "Lop".PadLeft(5) + "Gioi tinh \n".PadRight(10));
            foreach (var sv in ds)
            {
                sb.Append(sv + "\n");
            }
            return sb.ToString();
        }

        //1,2
        public int DemSoLuongSinhVien(bool gt)
        {
            return ds.Count(x => x.gioiTinh == gt);
        }
        public int DemSoLuongSVNam()
        {
            return DemSoLuongSinhVien(true);
        }
        public int DemSoLuongSVNu()
        {
            return DemSoLuongSinhVien(false);
        }

        //3,4
        public enum KieuSapXep
        {
            TangDTB,
            GiamDTB
        }
      public  void SapXep(KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangDTB)
                ds.Sort((sv1, sv2) => sv1.diemTB.CompareTo(sv2.diemTB));
            if (kieu == KieuSapXep.GiamDTB)
                ds.Sort((sv1, sv2) => -sv1.diemTB.CompareTo(sv2.diemTB));
        }
        public void SapXepTangTheoDTB()
        {
            SapXep(KieuSapXep.TangDTB);
       }
        public QuanLySinhVien SapTang()
        {
            QuanLySinhVien kq = new QuanLySinhVien();
            foreach (var item in ds)
            {
                kq.Them(item);
            }
            kq.SapXepTangTheoDTB();
            return kq;
        }
       
        public void SapXepGiamTheoDTB()
        {
            SapXep(KieuSapXep.GiamDTB);
        }

    public QuanLySinhVien SapGiam()
        {
            QuanLySinhVien kq = new QuanLySinhVien();
            foreach (var item in ds)
            {
                kq.Them(item);
            }
            kq.SapXepGiamTheoDTB();
            return kq;
        }
        public float TimDTBCaoNhat()
        {

        }

    }
}



  

