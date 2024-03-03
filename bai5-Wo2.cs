using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_W01
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("--- Chương trình giải phương trình bậc nhất ---");
            Console.WriteLine(" Phương trình có dạng Ax+B=0 ");
            Console.WriteLine("Xin mời nhập giá trị của A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập giá trị của B:");
         
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("PT: "+a + ".x" + " + " + b + " =0");
            // pp giiar 
            if (a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");

                }
            }
            else
            {
                double x = -(b / a);
                Console.WriteLine("Phương trình trên có nghiệm là : x= " + x);
            }



            Console.ReadKey();

        }
    }
}
