using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3th2
{
    internal class Program
    {
        public class MaTran
        {
            private int[,] matrix;
            private int soHang;
            private int soCot;

            public MaTran(int sh, int sc)
            {
                soHang = sh;
                soCot = sc;
                matrix = new int[sh, sc];
            }

            public void Nhap()
            {
                Console.WriteLine("Nhap cac phan tu cua ma tran:");
                for (int i = 0; i < soHang; i++)
                {
                    for (int j = 0; j < soCot; j++)
                    {
                        Console.Write($"[{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine("Ma tran:");
                for (int i = 0; i < soHang; i++)
                {
                    for (int j = 0; j < soCot; j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }

            public MaTran Cong(MaTran mt)
            {
                if (soHang != mt.soHang || soCot != mt.soCot)
                {
                    Console.WriteLine("Hai ma tran khong cung kich thuoc");
                    return null;
                }

                MaTran ketQua = new MaTran(soHang, soCot);
                for (int i = 0; i < soHang; i++)
                {
                    for (int j = 0; j < soCot; j++)
                    {
                        ketQua.matrix[i, j] = matrix[i, j] + mt.matrix[i, j];
                    }
                }
                return ketQua;
            }

            public MaTran Hieu(MaTran mt)
            {
                if (soHang != mt.soHang || soCot != mt.soCot)
                {
                    Console.WriteLine("Hai ma tran khong cung kich thuoc");
                    return null;
                }

                MaTran ketQua = new MaTran(soHang, soCot);
                for (int i = 0; i < soHang; i++)
                {
                    for (int j = 0; j < soCot; j++)
                    {
                        ketQua.matrix[i, j] = matrix[i, j] - mt.matrix[i, j];
                    }
                }
                return ketQua;
            }

            public void DoiDau()
            {
                for (int i = 0; i < soHang; i++)
                {
                    for (int j = 0; j < soCot; j++)
                    {
                        matrix[i, j] = -matrix[i, j];
                    }
                }
            }

            static void Main(string[] args)
            {
                Console.Write("Nhap so hang cua ma tran: ");
                int sh = int.Parse(Console.ReadLine());
                Console.Write("Nhap so cot cua ma tran: ");
                int sc = int.Parse(Console.ReadLine());

                MaTran mt1 = new MaTran(sh, sc);
                mt1.Nhap();
                mt1.Print();

                MaTran mt2 = new MaTran(sh, sc);
                mt2.Nhap();
                mt2.Print();

                MaTran tong = mt1.Cong(mt2);
                if (tong != null)
                {
                    Console.WriteLine("Tong hai ma tran:");
                    tong.Print();
                }

                MaTran hieu = mt1.Hieu(mt2);
                if (hieu != null)
                {
                    Console.WriteLine("Hieu hai ma tran:");
                    hieu.Print();
                }

                Console.WriteLine("Ma tran mt1 sau khi doi dau:");
                mt1.DoiDau();
                mt1.Print();
            }
        }
    }
}
