using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_TRANG45
{
    public class CongNhan : Person
    {
        public double HeSoLuong;
        public double LuongCoBan;
        public double PhuCap;

        public CongNhan() : base() { }

        public CongNhan(string hoTen, DateTime ngaySinh, string queQuan, double heSoLuong, double luongCoBan, double phuCap)
            : base(hoTen, ngaySinh, queQuan)
        {
            HeSoLuong = heSoLuong;
            LuongCoBan = luongCoBan;
            PhuCap = phuCap;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập hệ số lương: ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhập lương cơ bản: ");
            LuongCoBan = double.Parse(Console.ReadLine());
            Console.Write("Nhập phụ cấp: ");
            PhuCap = double.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return HeSoLuong * LuongCoBan * (1 + PhuCap);
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lương: {TinhLuong():N0}");
        }
    }
}
