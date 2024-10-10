using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Phanso_WF
{
     class Phanso
    {
        int tu;
        int mau;
        public Phanso()
        {
            tu = 0;
            mau = 1;
        }
        public Phanso(int a, int b)
        {
            tu = a;
            mau = b;
        }
        public Phanso(Phanso p)
        {
            this.tu = p.tu;
            this.mau = p.mau;
        }
        public void InPs()
        {
            Console.WriteLine($"{tu}/{mau}");
        }
        public override string ToString()
        {
            return $"{tu}/{mau}";
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
        public Phanso Cong(Phanso ps1)
        {
            Phanso kq = new Phanso();
            kq.tu = (this.tu * ps1.mau + this.mau * ps1.tu);
            kq.mau = ps1.mau * this.mau;
            int a = UCLN(kq.tu, kq.mau);
            kq.tu = kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;
        }
        public Phanso Tru(Phanso ps1)
        {
            Phanso kq = new Phanso();
            kq.tu = (this.tu * ps1.mau - this.mau * ps1.tu);
            kq.mau = ps1.mau * this.mau;
            int a = UCLN(kq.tu, kq.mau);
            kq.tu = kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;
        }
        public Phanso Nhan(Phanso ps1)
        {
            Phanso kq = new Phanso();
            kq.tu = this.tu * ps1.tu;
            kq.mau = ps1.mau * this.mau;
            int a = UCLN(kq.tu, kq.mau);
            kq.tu = kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;
        }
        public Phanso Chia(Phanso ps1)
        {
            Phanso kq = new Phanso();
            kq.tu = this.tu * ps1.mau;
            kq.mau = this.mau * ps1.tu;
            int a = UCLN(kq.tu, kq.mau);
            kq.tu = kq.tu / a;
            kq.mau = kq.mau / a;
            return kq;
        }
      
    }
    
}