using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI4_TRANG45
{
    public class MaTran
    {
        protected int soDong;
        protected int soCot;
        protected double[,] maTran;


        public MaTran(int soDong, int soCot)
        {
            this.soDong = soDong;
            this.soCot = soCot;
            maTran = new double[soDong, soCot];
        }

        public void NhapMaTran()
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"Nhập phần tử [{i + 1},{j + 1}]: ");
                    maTran[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        public void HienThiMaTran()
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"{maTran[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
