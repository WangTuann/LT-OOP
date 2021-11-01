using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class phanso
    {
        public int tu;
        public int mau;
        public phanso()
        {

        }
        public phanso(int t,int m)
        {
            tu=t;
            mau = m;
        }
        private phanso cong(phanso a,phanso b)
        {
            phanso kq = new phanso();
            kq.tu = a.tu * b.mau + b.tu * a.mau;
            kq.mau = a.mau * b.mau;
            return kq;
        }

        public static implicit operator phanso(int x)
        {
            return new phanso(x, 1);
        }

        public static phanso operator +(phanso a,phanso b)
        {
            return a.cong(b);
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}",tu,mau);
        }

(   }
}
