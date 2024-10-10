using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI4_TRANG45
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số dòng và cột của Ma Trận Vuông");
            n=int.Parse(Console.ReadLine());
            MaTranVuong maTranVuong = new MaTranVuong(n);
            maTranVuong.NhapMaTran();
            maTranVuong.HienThiMaTran();
            Console.WriteLine("Định thức: " + maTranVuong.GetDeterminant());
            Console.WriteLine("Tổng đường chéo chính: " + maTranVuong.DuongCheoChinh());
            Console.ReadKey();
        }
    }
}
