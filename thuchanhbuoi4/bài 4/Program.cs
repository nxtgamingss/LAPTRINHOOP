using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_4
{
    internal class Program
    {
   
            static void Main(string[] args)
            { 
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập tọa độ điểm thứ nhất: ");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Diem d1 = new Diem(a, b);
                Console.WriteLine("Nhập tọa độ điểm thứ hai: ");
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                Diem d2 = new Diem(c, d);

                d1.hienThi();
                d2.hienThi();

                Console.WriteLine($"Khoảng cách từ d1 đến gốc tọa độ: {d1.khoangCach()}");

                Console.WriteLine($"Khoảng cách giữa d1 và d2: {d1.khoangCach(d2)}");
                Console.ReadKey();
            }
        }
    }

