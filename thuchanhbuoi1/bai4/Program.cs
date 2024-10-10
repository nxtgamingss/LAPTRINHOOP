using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen n (0 < n <= 10): ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0 || n > 10);

            int S = 0;
            for (int i = 1; i <= n; i++)
            {
                S += i * i * i;
            }

            Console.WriteLine($"Tong S = 1^3 + 2^3 + ... + {n}^3 là: {S}");
            Console.ReadKey();  
        }
    }
}

