using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanso_WF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap tu so phan so dau tien:  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so phan so dau tien: ");
            int b = int.Parse(Console.ReadLine());
            Phanso ps1 = new Phanso(a, b);
            Console.WriteLine("Nhap tu so phan so thu hai:  ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so phan so thu hai: ");
            int d = int.Parse(Console.ReadLine());
            Phanso ps2 = new Phanso(c, d);
            Phanso tong = ps1.Cong(ps2);
            Phanso tru = ps1.Tru(ps2);
            Phanso tich = ps1.Nhan(ps2);
            Phanso thuong = ps1.Chia(ps2);
            Console.WriteLine("Tong:{0} " , tong);
            Console.WriteLine("Hieu:{0} " , tru);
            Console.WriteLine("Tich: {0}" , tich);
            Console.WriteLine("Thuong: {0} " , thuong);
            Console.ReadKey();
        }
    }
}
