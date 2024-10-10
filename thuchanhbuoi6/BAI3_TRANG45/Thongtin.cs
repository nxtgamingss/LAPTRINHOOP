using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_TRANG45
{
   
    
    internal class Thongtin
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CongNhan congNhan = new CongNhan();
            congNhan.Nhap();
            congNhan.HienThi();
            Console.ReadKey();
       
        }
    }
}
