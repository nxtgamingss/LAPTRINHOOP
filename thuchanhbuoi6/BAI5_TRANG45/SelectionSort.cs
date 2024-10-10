using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5_TRANG45
{
    public class SelectionSort : DaySo
    {
        public SelectionSort(int n) : base(n) { }

        public override void Sort()
        {
            for (int i = 0; i < mangSo.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < mangSo.Length; j++)
                {
                    if (mangSo[j] < mangSo[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(mangSo, i, minIndex);
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
