using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhap vao a");
             a =int.Parse(Console.ReadLine());
            int x;
            Console.WriteLine("Nhap vao x");
            x = int.Parse(Console.ReadLine());
           
            Console.WriteLine( "gia tri cua {0} ^ {1}= {2}",a,x,Math.Pow(a,x));
            Console.ReadKey();

        }
    }
}
