using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1th2console
{
    internal class Program
    {
        float hd, td, cd;
        public void Nhap(float a, float b, float c)
        {
            hd = a;
            td = b;
            cd = c;

        }
        public void nhaptubanphim()
        {
            Console.Write("nhap hd ");
            hd = float.Parse(Console.ReadLine());
            Console.Write("nhap td");
            td = float.Parse(Console.ReadLine());
            Console.Write("nhap cd ");
            cd = float.Parse(Console.ReadLine());


        }
        public void In()
        {

            Console.WriteLine("(" + hd.ToString() + "," + td.ToString() + "," + cd.ToString() + ")");

        }
        static void Main(string[] args)
        {
            Program gt = new Program();
            Console.WriteLine("hay nhap  3 gia tri hoanh do,tung do,cao do cho diem d:");
            gt.nhaptubanphim();
            Console.WriteLine("diem ban vua nhap toa do la");
            gt.In();
            Console.ReadKey();


        }
    }
}


  
