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
            Console.WriteLine("--- Chương trình tính diện tích hình chữ nhật ---");
            Console.WriteLine("Xin mời nhập chiều dài của hình chữ nhật: ");
            double cd = double.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập chiều rộng của hình chữ nhật: ");
            double cr = double.Parse(Console.ReadLine());
            // ct tính S
            double S = cd * cr;
            Console.WriteLine("Diện tích của hình chữ nhật trên là : " + S);

            Console.ReadKey();

        }
    }
}
