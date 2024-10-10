using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace thuchanhbuoi1
{
    internal class bai2
    {
        static void Main(string[] args)
        {
            Random Ramdom = new Random();
            int r = Ramdom.Next(1, 100);
            int n;
            Console.WriteLine("vui long nhap n");
            n= int.Parse(Console.ReadLine());
            if (r > n)
            {
                Console.WriteLine("ban da thua ");
            }
            else {
                Console.WriteLine(" ban thang,chuc mung ban ");
             }
            Console.ReadKey();  

        }
    }
}
