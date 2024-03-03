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
            Console.WriteLine("--- Chương trình quy đổi tỉ giá tiền tệ ---");
            Console.WriteLine("Nhập giá trị số tiền USD");
            double usd = double.Parse(Console.ReadLine());
            // ct quy đổi
            double vnd = usd * 23000;
            Console.WriteLine("Giá trị quy đổi từ "+usd+" usd sang vnd là : "+vnd+" vnd");


            Console.ReadKey();

        }
    }
}
