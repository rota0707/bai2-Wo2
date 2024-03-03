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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chữ số: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 10)
            {
                switch (num)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 10:
                        Console.Write("Ten");
                        break;
                }
            }
            if (num > 10 && num <= 20)
            {
                int hangdv = num % 10;
                if (num == 11)
                {
                    Console.WriteLine("Eleven");
                }
                else if (num == 12)
                {
                    Console.WriteLine("Twelve");
                }
                else if (num == 13)
                {
                    Console.WriteLine("Thirteen");
                }
                else if (num == 15)
                {
                    Console.WriteLine("Fifteen");
                }
                else if (num == 20)
                {
                    Console.WriteLine("Twenty");
                }
                else
                {
                    switch (hangdv)
                    {
                        case 4:
                            Console.Write("Fourt");
                            break;
                        case 6:
                            Console.Write("Six");
                            break;
                        case 7:
                            Console.Write("Seven");
                            break;
                        case 8:
                            Console.Write("Eight");
                            break;
                        case 9:
                            Console.Write("Nine");
                            break;
                    }
                    Console.WriteLine("-teen");
                }
            }
            if (num > 20 && num < 100)
            {
                int hangdonvi2 = num % 10;
                int hangchuc = num / 10;
                if (hangchuc == 2)
                {
                    Console.Write("Twenty");
                }
                else
                {
                    switch (hangchuc)
                    {
                        case 3:
                            Console.Write("Thirty");
                            break;
                        case 4:
                            Console.Write("Forty");
                            break;
                        case 5:
                            Console.Write("Fifty");
                            break;
                        case 6:
                            Console.Write("Sixty");
                            break;
                        case 7:
                            Console.Write("Seventy");
                            break;
                        case 8:
                            Console.Write("Eighty");
                            break;
                        case 9:
                            Console.Write("Ninety");
                            break;
                    }
                }
                if (hangdonvi2 != 0)
                {
                    switch (hangdonvi2)
                    {
                        case 1:
                            Console.WriteLine("-One");
                            break;
                        case 2:
                            Console.WriteLine("-Two");
                            break;
                        case 3:
                            Console.WriteLine("-Three");
                            break;
                        case 4:
                            Console.WriteLine("-Four");
                            break;
                        case 5:
                            Console.WriteLine("-Five");
                            break;
                        case 6:
                            Console.WriteLine("-Six");
                            break;
                        case 7:
                            Console.WriteLine("-Seven");
                            break;
                        case 8:
                            Console.WriteLine("-Eight");
                            break;
                        case 9:
                            Console.WriteLine("-Nine");
                            break;

                    }
                }
            }
            if (num >= 100 && num < 1000)
            {
                int hangtram = num / 100;
                int hangchuc = (num / 10) % 10;
                int hangdonvi3 = num % 10;
                switch (hangtram)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                }
                Console.Write("-Hundred ");
                if (hangdonvi3 != 0 && hangchuc == 0)
                {
                    switch (hangdonvi3)
                    {
                        case 1:
                            Console.Write("and One");
                            break;
                        case 2:
                            Console.Write("and Two");
                            break;
                        case 3:
                            Console.Write("and Three");
                            break;
                        case 4:
                            Console.Write("and Four");
                            break;
                        case 5:
                            Console.Write("and Five");
                            break;
                        case 6:
                            Console.Write("and Six");
                            break;
                        case 7:
                            Console.Write("and Seven");
                            break;
                        case 8:
                            Console.Write("and Eight");
                            break;
                        case 9:
                            Console.Write("and Nine");
                            break;
                    }

                }
                else if (hangdonvi3 == 0 && hangchuc != 0)
                {
                    switch (hangchuc)
                    {
                        case 1:
                            Console.Write("Ten");
                            break;
                        case 2:
                            Console.Write("Twenty");
                            break;
                        case 3:
                            Console.Write("Thirty");
                            break;
                        case 4:
                            Console.Write("Forty");
                            break;
                        case 5:
                            Console.Write("Fifty");
                            break;
                        case 6:
                            Console.Write("Sixty");
                            break;
                        case 7:
                            Console.Write("Seventy");
                            break;
                        case 8:
                            Console.Write("Eighty");
                            break;
                        case 9:
                            Console.Write("Ninety");
                            break;
                    }
                }
                else
                {
                    if (hangchuc == 1)
                    {
                        if (hangdonvi3 == 1)
                        {
                            Console.WriteLine("and Eleven");
                        }
                        else if (hangdonvi3 == 2)
                        {
                            Console.WriteLine("and Twelve");
                        }
                        else if (hangdonvi3 == 3)
                        {
                            Console.WriteLine("and Thirteen");
                        }
                        else if (hangdonvi3 == 5)
                        {
                            Console.WriteLine("and Fifteen");
                        }
                        else
                        {
                            switch (hangdonvi3)
                            {
                                case 4:
                                    Console.Write("and Fourt");
                                    break;
                                case 6:
                                    Console.Write("and Six");
                                    break;
                                case 7:
                                    Console.Write("and Seven");
                                    break;
                                case 8:
                                    Console.Write("and Eight");
                                    break;
                                case 9:
                                    Console.Write("and Nine");
                                    break;
                            }
                            Console.WriteLine("-teen");
                        }
                    }
                    else if (hangchuc >= 2)
                    {
                        if (hangchuc == 2)
                        {
                            Console.Write("and Twenty");
                        }
                        else
                        {
                            switch (hangchuc)
                            {
                                case 3:
                                    Console.Write("and Thirty");
                                    break;
                                case 4:
                                    Console.Write("and Forty");
                                    break;
                                case 5:
                                    Console.Write("and Fifty");
                                    break;
                                case 6:
                                    Console.Write("and Sixty");
                                    break;
                                case 7:
                                    Console.Write("and Seventy");
                                    break;
                                case 8:
                                    Console.Write("and Eighty");
                                    break;
                                case 9:
                                    Console.Write("and Ninety");
                                    break;
                            }
                        }
                        if (hangdonvi3 != 0)
                        {
                            switch (hangdonvi3)
                            {
                                case 1:
                                    Console.WriteLine("-One");
                                    break;
                                case 2:
                                    Console.WriteLine("-Two");
                                    break;
                                case 3:
                                    Console.WriteLine("-Three");
                                    break;
                                case 4:
                                    Console.WriteLine("-Four");
                                    break;
                                case 5:
                                    Console.WriteLine("-Five");
                                    break;
                                case 6:
                                    Console.WriteLine("-Six");
                                    break;
                                case 7:
                                    Console.WriteLine("-Seven");
                                    break;
                                case 8:
                                    Console.WriteLine("-Eight");
                                    break;
                                case 9:
                                    Console.WriteLine("-Nine");
                                    break;

                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
