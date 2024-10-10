using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5_TRANG45
{
    public class InsertSort : DaySo
    {
        public InsertSort(int n) : base(n) { }

        public override void Sort()
        {
            for (int i = 1; i < mangSo.Length; i++)
            {
                int key = mangSo[i];
                int j = i - 1;
                while (j >= 0 && mangSo[j] > key)
                {
                    mangSo[j + 1] = mangSo[j];
                    j--;
                }
                mangSo[j + 1] = key;
            }
        }
    }
}
