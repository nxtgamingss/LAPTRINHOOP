using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_4
{
    internal class Diem
    {
        private double x, y;
        public Diem()
        {
            x = 0;
            y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Diem(Diem d)
        {
            this.x = d.x;
            this.y = d.y;
        }
        public void tinhTien(int dx)
        {
            this.x += dx;
        }
        public void tinhTien(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }
        public double khoangCach()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double khoangCach(Diem d1)
        {
            return Math.Sqrt(Math.Pow(this.x - d1.x, 2) + Math.Pow(this.y - d1.y, 2));
        }
        public string show()
        {
            return $"({x}, {y})";
        }
        public void hienThi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Điểm có tọa độ: {show()}");
        }
    }
}
