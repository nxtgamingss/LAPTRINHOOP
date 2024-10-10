using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5_TRANG45
{
    public class QuickSort : DaySo
    {
        public QuickSort(int n) : base(n) { }

        public override void Sort()
        {
            QuickSortAlgorithm(mangSo, 0, mangSo.Length - 1);
        }

        private void QuickSortAlgorithm(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                QuickSortAlgorithm(arr, left, pivot - 1);
                QuickSortAlgorithm(arr, pivot + 1, right);
            }
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
