using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_5_trang_36
{
    internal class MaTran
    {
        private int[,] matrix;
        private int sh;
        private int sc;

        public MaTran(int sh, int sc)
        {
            this.sh = sh;
            this.sc = sc;
            matrix = new int[sh, sc];
        }

        public void nhap()
        {
            Console.WriteLine($"Nhập ma trận {sh} x {sc}:");
            for (int i = 0; i < sh; i++)
            {
                for (int j = 0; j < sc; j++)
                {
                    Console.Write($"Nhập phần tử [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void hien()
        {
            Console.WriteLine("Ma tran la:");
            for (int i = 0; i < sh; i++)
            {
                for (int j = 0; j < sc; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

      

        public static MaTran operator +(MaTran mt1, MaTran mt2)
        {
            if (mt1.sh != mt2.sh || mt1.sc != mt2.sc)
            {
                Console.WriteLine("Hai ma tran phai co cung kich thuoc đe cong.");
                return null;
            }

            MaTran kq = new MaTran(mt1.sh, mt1.sc);
            for (int i = 0; i < mt1.sh; i++)
            {
                for (int j = 0; j < mt1.sc; j++)
                {
                    kq.matrix[i, j] = mt1.matrix[i, j] + mt2.matrix[i, j];
                }
            }
            return kq;
        }

        public static MaTran operator -(MaTran mt1, MaTran mt2)
        {
            if (mt1.sh != mt2.sh || mt1.sc != mt2.sc)
            {
                Console.WriteLine("Hai ma tran phai co cung kich thuoc đe tru.");
                return null;
            }

            MaTran kq = new MaTran(mt1.sh, mt1.sc);
            for (int i = 0; i < mt1.sh; i++)
            {
                for (int j = 0; j < mt1.sc; j++)
                {
                    kq.matrix[i, j] = mt1.matrix[i, j] - mt2.matrix[i, j];
                }
            }
            return kq;
        }



        public void DoiDau()
        {
            for (int i = 0; i < sh; i++)
            {
                for (int j = 0; j < sc; j++)
                {
                    matrix[i, j] = -matrix[i, j];
                }
            }
        }
    }
}
