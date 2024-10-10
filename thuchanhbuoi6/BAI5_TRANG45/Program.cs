using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5_TRANG45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số lượng phần tử cần sắp xếp:");
            n = int.Parse(Console.ReadLine());
            DaySo daySo = new InsertSort(n);
            daySo.Nhap();
            Console.WriteLine("Danh sách phần tử bạn vừa nhập là: ");
            daySo.Print();
            daySo.Sort();
            Console.WriteLine("Danh sách phần tử sau sắp xếp:");
            daySo.Print();
            Console.ReadKey();
        }
    }
}
