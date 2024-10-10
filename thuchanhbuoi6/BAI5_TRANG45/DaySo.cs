using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5_TRANG45
{
    public abstract class DaySo
    {
        protected int[] mangSo;

        public DaySo(int n)
        {
            mangSo = new int[n];
        }

        public void Nhap()
        {
            for (int i = 0; i < mangSo.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                mangSo[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Print()
        {
            for (int i = 0; i < mangSo.Length; i++)
            {
                Console.Write($"{mangSo[i]} ");
            }
            Console.WriteLine();
        }

        public abstract void Sort();
    }
}
