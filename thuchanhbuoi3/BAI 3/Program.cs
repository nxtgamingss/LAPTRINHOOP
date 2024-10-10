using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class MaTran
    {   
        private int soHang;
        private int soCot;
        private int[,] a;
        public MaTran(int sh, int sc)
        {
            soHang = sh;
            soCot = sc;
            a = new int[soHang, soCot];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập các phần tử cho ma trận:");
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Ma trận :");
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public MaTran Cong(MaTran mt2)
        {
            if (this.soHang != mt2.soHang || this.soCot != mt2.soCot)
            {
                Console.WriteLine("không thể cộng hai ma trận có kích thước khác nhau.");
                return null; 
            }

            MaTran kq = new MaTran(soHang, soCot);
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    kq.a[i, j] = this.a[i, j] + mt2.a[i, j];
                }
            }

            return kq;
        }

        public MaTran Hieu(MaTran mt2)
        {
            if (this.soHang != mt2.soHang || this.soCot != mt2.soCot)
            {
                Console.WriteLine("không thể trừ hai ma trận có kích thước khác nhau.");
                return null;
            }

            MaTran kq = new MaTran(soHang, soCot);
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    kq.a[i, j] = this.a[i, j] - mt2.a[i, j];
                }
            }

            return kq;
        }
        public MaTran DoiDau()
        {
            MaTran kq = new MaTran(soHang, soCot);
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    kq.a[i, j] = -this.a[i, j];
                }
            }

            return kq;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập độ dài và rộng của ma trận 1: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            MaTran mt1 = new MaTran(a, b);
            Console.WriteLine("Nhập ma trận thứ nhất :");
            mt1.Nhap();
            Console.WriteLine("Nhập độ dài và rộng của ma trận 2: ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            MaTran mt2 = new MaTran(c, d);
            Console.WriteLine("Nhập ma trận thứ hai :");
            mt2.Nhap();

            Console.WriteLine("Ma trận thứ nhất là :");
            mt1.Print();
            Console.WriteLine("Ma trận thứ Hai là :");
            mt2.Print();

            MaTran mtCong = mt1.Cong(mt2);
            if (mtCong != null)
            {
                Console.WriteLine("Kết quả của phép cộng ma trận:");
                mtCong.Print();
            }

            MaTran mtHieu = mt1.Hieu(mt2);
            if (mtHieu != null)
            {
                Console.WriteLine("Kết quả của phép trừ ma trận:");
                mtHieu.Print();
            }

            MaTran mt1DoiDau = mt1.DoiDau();
            Console.WriteLine("Ma trận thứ nhất sau khi đổi dấu là:");
            mt1DoiDau.Print();

            MaTran mt2doidau = mt2.DoiDau();
            Console.WriteLine("Ma trận thứ hai  sau khi đổi dấu là:");
            mt2doidau.Print();

            Console.ReadKey();  
        }
    }
}