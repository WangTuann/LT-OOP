using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuV2
{
    class Program
    {
        enum Menu
        {
            XuatDanhSach,
            TimSoNguyenXuatHienNhieuNhat,
            TimSoNguyenXuatHienItNhat,
            TimViTriCuaSoLonNhat,
            TimViTriCuaSoNhoNhat,
            TimTatCaSoChan,
            TimTatCaSoLe,
            KiemTraPhanTuXCoTrongMangKhong,
            XoaPhanTuTaiViTriXTrongDanhSach,
            SapXepMangTheoChieuTang,
            SapXepMangTheoChieuGiam,

            ThoatChuongTrinh=12
        }

        static List<int> a = new List<int>();
        static void Main(string[] args)
        {
            NhapTuFile();
            XuatMang();
            while (true)
            {
                Console.Clear();

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Nhap {0} de Xuat danh sach ", (int)Menu.XuatDanhSach);
                Console.WriteLine("Nhap {0} de That chuong trinh",(int)Menu.ThoatChuongTrinh);
                Console.WriteLine("Nhap {0} de tim so nguyen xuat hien nhieu nhat", (int)Menu.TimSoNguyenXuatHienNhieuNhat);
                Console.WriteLine("Nhap {0} de tim so nguyen xuat hien it nhat", (int)Menu.TimSoNguyenXuatHienItNhat);
                Console.WriteLine("Nhap {0} de tim vi tri cua so lon nhat", (int)Menu.TimViTriCuaSoLonNhat);
                Console.WriteLine("Nhap {0} de tim vi tri cua phan tu nho nhat", (int)Menu.TimViTriCuaSoNhoNhat);
                Console.WriteLine("Nhap {0} de Xuat tat ca cac so chan trong mang", (int)Menu.TimTatCaSoChan);
                Console.WriteLine("Nhap {0} de xuat tat ca cac so le reong mang", (int)Menu.TimTatCaSoLe);
                Console.WriteLine("Nhap {0} de kiem tra phan tu x co xuat hien trong mang hay khong",(int)Menu.KiemTraPhanTuXCoTrongMangKhong);
                Console.WriteLine("Nhap {0} de xoa phan tu tai vi tri x trong danh sach",(int)Menu.XoaPhanTuTaiViTriXTrongDanhSach);
                Console.WriteLine("Nhap {0} de sap day tang", (int)Menu.SapXepMangTheoChieuTang);
                Console.WriteLine("Nhap {0} de sap day giam", (int)Menu.SapXepMangTheoChieuGiam);
                Console.WriteLine("--------------------------------------------");
                
                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch(nhap)
                {
                   
                    case Menu.XuatDanhSach:
                        XuatMang();
                        break;
                    case Menu.TimSoNguyenXuatHienNhieuNhat:
                        {
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("So nguyen Xuat hien nhieu nhat la : {0} ",DemSoLanXuatHienNhieuNhat());
                            break;
                        }
                    case Menu.TimSoNguyenXuatHienItNhat:
                        {
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("So nguyen xuat hien it nhat la: {0} ", DemSoLanXuatHienItNhat());
                            break;
                        }
                    case Menu.TimViTriCuaSoLonNhat:
                        {
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("So lon nhat mang la {0} nam o vi tri so {1} ", TimMax(), TimViTriCuaPhanTuLonNhat());
                            break;
                        }
                    case Menu.TimViTriCuaSoNhoNhat:
                        {
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("So nho nhat mang la {0} nam o vi tri so {1} ", TimMin(), TimViTriCuaPhanTuNhoNHat());
                            break;
                        }
                    case Menu.TimTatCaSoChan:
                        {
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("co tat ca {0} so nguyen chan trong mang", TimSoChan());
                            break;
                        }
                    case Menu.TimTatCaSoLe:
                        {
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Co tat ca {0} so nguyen le trong mang", TimSoLe());
                            break;
                        }
                    case Menu.KiemTraPhanTuXCoTrongMangKhong:
                        {
                            
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Nhap x: ");
                            KiemTraX();
                            break;
                        }
                    case Menu.XoaPhanTuTaiViTriXTrongDanhSach:
                        {
                            int vt;
                            Console.WriteLine("Danh sach hien thi: ");
                            XuatMang();
                            Console.WriteLine("Nhap vi tri can xoa: ");
                            int.TryParse(Console.ReadLine(), out vt);
                            TimViTriCuaPhanTuX(vt);
                            XoaPhanTuX(vt);
                            break;
                        }
                    case Menu.SapXepMangTheoChieuTang:
                        {
                            Console.WriteLine("---------------------------------------");
                            SapDayTang();
                            break;
                        }
                    case Menu.SapXepMangTheoChieuGiam:
                        {
                            Console.WriteLine("----------------------------------------");
                            SapDayGiam();
                            break;
                        }
                    case Menu.ThoatChuongTrinh:
                        return;
                   
                }
                Console.ReadLine();
            }
        }
        static void NhapMang()
        {
            int length;
            Console.WriteLine("Nhap chieu dai mang ");
            int.TryParse(Console.ReadLine(), out length);
            for(int i=0;i<length;i++)
            {
                Console.WriteLine("a[{0}]",i);
                a.Add(int.Parse(Console.ReadLine()));
            }
        }
        static void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            string[] s = line.Split(' ');
            foreach (var c in s)
            {
                    a.Add(int.Parse(c));
            }
        }
        static void XuatMang()
        {
            Console.WriteLine("Danh sach cac phan tu: ");
            foreach (var i in a)
            {
                Console.Write(" {0} ", i + " ");
            }
        }
        static void XuatMang(List<int> a)
        {
            Console.WriteLine("\nDanh sach cac phan tu ");
            foreach (var i in a)
            {
                Console.WriteLine(" {0} ", i);
            }
        }
        static int DemSoLanXuatHien(int x)
        {
            int dem=0;
            foreach (var item in a)
            {
                if (item == x)
                    dem++;
            }
            return dem;
        }
        static int DemSoLanXuatHienNhieuNhat()
        {
            int max = 0, m = 0;
           foreach (var item in a)
           {
               if (DemSoLanXuatHien(item)>max)
               {
                   max = DemSoLanXuatHien(item);
                   m = item;
               }
           }
           return m;
            
        }
        static int DemSoLanXuatHienItNhat()
        {
            int min = int.MaxValue, m = 0;
            foreach (var item in a)
            {
                if (DemSoLanXuatHien(item)<min)
                {
                    min = DemSoLanXuatHien(item);
                    m = item;
                }
            }
            return m;
        }
        static int TimViTriCuaPhanTuLonNhat()
        {
            int x = TimMax();
            for (int i = 0; i < a.Count; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        static int TimViTriCuaPhanTuNhoNHat()
        {
            int x = TimMin();
            for (int i = 0; i < a.Count; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        static int TimMax()
        {
            int max = int.MinValue;
            foreach (var item in a)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        static int TimMin()
        {
            int min = int.MaxValue;
            foreach (var item in a)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }
        static int TimSoChan()
        {
            int i,dem=0;
            for ( i = 0; i < a.Count; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                    dem++;
                }
            }
            return dem;
        }
        static int TimSoLe()
        {
            int i, dem = 0;
            for(i=0;i<a.Count;i++)
            {
                if(a[i]%2!=0)
                {
                    Console.WriteLine(a[i]);
                    dem++;
                }
            }
            return dem;
        }
        static int KiemTraX()
        {
            int x , kq = 0;
            int.TryParse(Console.ReadLine(),out x);
            foreach (var item in a)
            {
                if (item == x)
                {
                  kq = item;
                  Console.WriteLine("Phan tu vua nhap co trong mang!");
                }
                else
                {
                    Console.WriteLine("Phan tu vua nhap khong co torng mang!");
                    break;
                }
            }
            return kq;
        }
        static void XoaTaiViTri(int vt)
        {
            a.RemoveAt(vt);
        }
        static int TimViTriCuaPhanTuX(int x)
        {
            for (int i = 0; i < a.Count; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        static void XoaPhanTuX(int x)
        {
            int vt = 0;
           
            while (vt != -1)
            {
                vt = -1;
                for (int i = 0; i < a.Count; i++)
                    if (a[i] == x)
                    {
                        vt = i;
                        break;
                    }
                if (vt >= 0)
                    XoaTaiViTri(vt);
            }
            Console.WriteLine("Mang sua khi xoa phan tu la");
            XuatMang();
        }
        static void SapDayTang()
        {
            
            int i, j;
            for(i=0;i<a.Count;i++)
                for(j=i+1;j<a.Count;j++)
                    if(a[i]>a[j])
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
            XuatMang();
        }
        static void SapDayGiam()
        {
            int i, j;
            for (i = 0; i < a.Count; i++)
                for (j = i + 1; j < a.Count; j++)
                    if (a[i] < a[j])
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
            XuatMang();
        }
    }
}