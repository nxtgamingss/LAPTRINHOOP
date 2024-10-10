using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random Ramdom = new Random();
            int r = Ramdom.Next(1, 100);
            int n;
            Console.WriteLine("vui long nhap n");
            n = int.Parse(Console.ReadLine());
            if (r > n)
            {
                Console.WriteLine("ban da thua ");
            }
            else
            {
                Console.WriteLine(" ban thang,chuc mung ban ");
            }
            Console.WriteLine("so R La "+r);
            Console.ReadKey();
        }
    }
}
