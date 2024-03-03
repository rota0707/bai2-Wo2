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
            Console.WriteLine("--- Chương trình tính chỉ số sưc khỏe BMI ---");
            Console.WriteLine("Xin mời nhập chiều cao của bạn <cm> :");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập số cận nặng của bạn <kg> :");
            double weight = double.Parse(Console.ReadLine());
            // ct tính bmi
            double bmi = weight / Math.Pow((height/100), 2);
            if (bmi >= 30)
            {
                Console.WriteLine("Chỉ số bmi của bạn là :" + bmi);
                Console.WriteLine("Obese");

            }else if(bmi>=25 && bmi < 30)
            {
                Console.WriteLine("Chỉ số bmi của bạn là :" + bmi);
                Console.WriteLine("Overweight");
            }else if(bmi>=18.5 && bmi < 25)
            {
                Console.WriteLine("Chỉ số bmi của bạn là :" + bmi);
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Chỉ số bmi của bạn là :" + bmi);
                Console.WriteLine("Underweight");
            }
            Console.ReadKey();


        }
    }
}
