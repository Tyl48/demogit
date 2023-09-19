using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine("chuong trinh tim kiem ");
            Console.WriteLine("tim kiem theo ten ");
            Console.WriteLine("tim kiem theo tac gia ");
            Console.WriteLine("tim kiem theo nha xuat ban ");
            Console.WriteLine("tim kiem theo tieu de ");

            Console.ReadKey();
            */
            // jwdfgsjdhfgsjhd


            int n;
            Console.WriteLine("nhap vao 1 so ");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine(" ct tim kiem ten ");
                    break;
                case 2: Console.WriteLine(" ct tim kiem tac gia ");
                    break;
                case 3: Console.WriteLine("ct tim kiem nxb ");
                    break;
                default: Console.WriteLine(" khong hop le ");
                    break;
           }

            Console.ReadKey();  

        }
    }
}
