using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_TRANG45
{
    public class Person
    {
        public string HoTen;
        public DateTime NgaySinh;
        public string QueQuan;
        public Person() { }

        public Person(string hoTen, DateTime ngaySinh, string queQuan)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Họ Tên: {HoTen}");
            Console.WriteLine($"Ngày sinh: {NgaySinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Quê quán: {QueQuan}");
        }
    }
}
