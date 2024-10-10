using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4wdf
{
    internal class PhanSo
    {
        int Tu, Mau;

        public PhanSo()
        {
            Tu = 0;
            Mau = 1;
        }
        public PhanSo(PhanSo p)
        {
            this.Tu = p.Tu;
            this.Mau = p.Mau;
        }
        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau;
        }

        public string show()
        {
            string t;
            t = Convert.ToString(Tu) + "/" + Convert.ToString(Mau);
            return t;
        }

        public PhanSo Cong(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Mau + this.Mau * ps1.Tu);
            kq.Mau = ps1.Mau * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }

        public PhanSo Tru(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Mau - this.Mau * ps1.Tu);
            kq.Mau = ps1.Mau * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }

        public PhanSo Nhan(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Tu);
            kq.Mau = ps1.Mau * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }

        public PhanSo Chia(PhanSo ps1)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = (this.Tu * ps1.Mau);
            kq.Mau = ps1.Tu * this.Mau;
            int a = UCLN(kq.Tu, kq.Mau);
            kq.Tu /= a;
            kq.Mau /= a;
            return kq;
        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
    }
   }

