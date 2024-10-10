using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class sophuc
    {
        public int thuc;
        public int ao;

        public void nhap()
        {
            thuc = int.Parse(Console.ReadLine());
            ao = int.Parse(Console.ReadLine());

        }
        public void xuat()
        {
            if (ao >= 0) {
                Console.WriteLine("z = {0}+{1}i", thuc, ao);
            }
            else
            {
                Console.WriteLine("z = {0}-{1}i", thuc, Math.Abs(ao));
            }
     
        }
        public void tong2sophuc(sophuc sp1, sophuc sp2)
        {
            thuc = sp1.thuc+sp2.thuc;
            ao = sp1.ao+sp2.ao ;
        }
        public void tong2sp(sophuc sp2)
        {
            sophuc tongsp = new sophuc();
            

            thuc = tongsp.thuc = this.thuc  + sp2.thuc;
            ao = tongsp.ao = this.ao + sp2.ao;

        }
    }
      
    internal class Program
    {
        
            static void Main(string[] args)
            {
               sophuc sp = new sophuc();
               sophuc sp1 = new sophuc();   
               sophuc sp2 = new sophuc();
            Console.WriteLine("nhap so phuc thu 1");
            sp1.nhap();
            Console.WriteLine("nhap so phuc thu 2");
            sp2.nhap();
            Console.WriteLine("so phuc thu 1");      
            sp1.xuat();
            Console.WriteLine("so phuc thu 2");
            sp2.xuat();
            //sp.tong2sophuc(sp1, sp2);
            //Console.WriteLine("Tong 2 so phuc la");
            //sp.xuat();


            Console.WriteLine("Tong 2 so phuc la");
            sp1.tong2sp(sp2);
            sp = sp1;
            sp.xuat();
            Console.ReadKey();
            
        }
        }
    }
