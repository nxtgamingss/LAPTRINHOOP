using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5_trang_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang cho ma tran 1: ");
            int sh1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cho ma tran 1: ");
            int sc1 = Convert.ToInt32(Console.ReadLine());
            MaTran mt1 = new MaTran(sh1, sc1);
            mt1.nhap();


            Console.Write("Nhap so hang cho ma tran 2:");
            int sh2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cho ma tran 2: ");
            int sc2 = Convert.ToInt32(Console.ReadLine());
            MaTran mt2 = new MaTran(sh2, sc2);
            mt2.nhap();


            Console.WriteLine("Ma tran 1:");
            mt1.hien();
            Console.WriteLine("Ma tran 2:");
            mt2.hien();


            MaTran mtTong = mt1+mt2;
            if (mtTong != null)
            {
                Console.WriteLine("Tong hai ma tran:");
                mtTong.hien();
            }


            MaTran mtHieu = mt1-mt2;
            if (mtHieu != null)
            {
                Console.WriteLine("Hieu hai ma tran:");
                mtHieu.hien();
            }


            mt1.DoiDau();
            Console.WriteLine("Ma tran 1 sau khi đoi dau:");
            mt1.hien();

            Console.ReadKey();
        }
    }
   }

