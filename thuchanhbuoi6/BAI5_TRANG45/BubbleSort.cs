using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5_TRANG45
{
   public class BubbleSort : DaySo
    {
        public BubbleSort(int n) : base(n) { }

        public override void Sort()
        {
            for (int i = 0; i < mangSo.Length - 1; i++)
            {
                for (int j = 0; j < mangSo.Length - i - 1; j++)
                {
                    if (mangSo[j] > mangSo[j + 1])
                    {
                        Swap(mangSo, j, j + 1);
                    }
                }
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
