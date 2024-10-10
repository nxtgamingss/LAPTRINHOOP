using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanhbuoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("nhap vao chuoi s");
             s = Console.ReadLine();
            if (s.Length>25)
            {
                Console.WriteLine("chieu dai cua chuoi phai <25 ky tu");
            }
            else {
                Console.WriteLine("ban da nhap dung rui");
            }
            Console.ReadKey();
        }
    }
}
