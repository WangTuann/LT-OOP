using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLopDoiTuong2
{
    class DanhSachSinhVien
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
                string[] str = line.Split(',');
                ds.Add(new SinhVien(str[0],str[1],float.Parse(str[2]),str[3],str[4]));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var sv in ds)
            {
                sb.Append(sv + "\n");
            }
            return sb.ToString();
        }
        //
        public int DemSoSinhVienNam()
        {
            int dem = 0;
            foreach (var item in ds)
            {
                if (item.gioiTinh.Trim().CompareTo("NAM".Trim()) == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int DemSoLuongSinhVienNu()
        {
            int dem = 0;
            foreach (var item in ds)
            {
                if (item.gioiTinh.Trim().CompareTo("NU".Trim()) == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
        //
        public DanhSachSinhVien SapXepTheoDiemTrungBinhTang()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            SinhVien tam;
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                    if (ds[i].dTB >= ds[j].dTB)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;

                    }
                kq.Them(ds[i]);
            }
            return kq;
        }
        public DanhSachSinhVien SapXepTheoDiemTrungBinhGiam()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            SinhVien tam;
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                    if (ds[i].dTB <= ds[j].dTB)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;

                    }
                kq.Them(ds[i]);
            }
            return kq;
        }

        //
        public double TimDTBCaoNhat()
        {
            return ds.Max(x => x.dTB);
        }
        public DanhSachSinhVien TimDSSVCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            double max = TimDTBCaoNhat();
            foreach (var item in ds)
            {
                if (item.dTB == max)
                    kq.Them(item);
            }
            return kq;
        }
       
        public DanhSachSinhVien LopCoSinhVienCoDiemTrungBinhCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            double max = TimDTBCaoNhat();
            for (int i = 0; i < ds.Count;i++)
            {
                if(ds[i].dTB==max)
                {
                    Console.WriteLine("Sinh vien co diem trung binh cao nhat thuoc lop: {0} ", ds[i].lop);
                    kq.Them(ds[i]);
                }
            }
                return kq;
        }
        public double TimDTBThapNhat()
        {
            return ds.Min(x => x.dTB);
        }
        public DanhSachSinhVien LopCoSinhVienKhongCoDiemTrungBinhCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            double max = TimDTBThapNhat();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].dTB == max)
                {
                    Console.WriteLine("Sinh vien khong co diem trung binh cao nhat thuoc lop: {0} ", ds[i].lop);
                    kq.Them(ds[i]);
                }
            }
            return kq;
        }
       
        public DanhSachSinhVien HienThiDanhSachSinhVienTheoLopvaDtb()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            SinhVien tam;
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                {
                    if (ds[i].lop.CompareTo(ds[j].lop) > 0 )
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                        
                    }
                   
                }
                kq.Them(ds[i]);
            }
                    return kq;
        }
      
        public DanhSachSinhVien XepHang()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var item in ds)
            {
                if (item.dTB > 80)
                {
                    Console.WriteLine("Sinh vien {0} xep hang hoc luc Gioi! ", item.hoTen);
                }
                else if (item.dTB > 65)
                {
                    Console.WriteLine("Sinh vien {0} xep hang hoc luc Kha!", item.hoTen);
                }
                else if (item.dTB > 50)
                {
                    Console.WriteLine("Sinh vien {0} xep hang hoc luc Trung Binh!", item.hoTen);
                }
                else
                    Console.WriteLine("Sinh vien {0} xep hang hoc luc Yeu!", item.hoTen);
            }
            return kq;
        }
       

       
        public DanhSachSinhVien Ctk43()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var item in ds)
            {
                if (item.lop.Trim().CompareTo("CTK43".Trim()) == 0)
                    kq.Them(item);
               
            }
            return kq;
        }
        public DanhSachSinhVien Lhk43()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var item in ds)
            {
                if (item.lop.Trim().CompareTo("LHK43".Trim()) == 0)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachSinhVien Qtk43()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var item in ds)
            {
                if (item.lop.Trim().CompareTo("QTK43".Trim()) == 0)
                    kq.Them(item);
            }
            return kq;
        }
      public double TinhTongDTBLop()
        {
            double tong = 0;
            foreach (var item in ds)
            {
                tong += item.dTB;
            }
            return tong;
        }
        public int DemSoHocSinhGioi()
      {
          int dem = 0;
          foreach (var item in ds)
          {
              if (item.dTB > 80)
                  dem++;
          }
          return dem;
      }
        public int DemSoHocSinhYTBk()
        {
            int dem = 0;
            foreach(var item in ds)
            {
                if (item.dTB < 80)
                    dem++;
            }
            return dem;
        }
       
    }
}
