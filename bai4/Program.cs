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
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int chon;
            do
            {
                Console.WriteLine("1. Tổng 1..n");
                Console.WriteLine("2. Bảng cửu chương");
                Console.WriteLine("0. Thoát");
                int.TryParse(Console.ReadLine(), out chon);
                switch (chon)
                {
                    case 1:
                        Console.Write("n = ");
                        int n = int.Parse(Console.ReadLine());
                        int tong = 0;
                        for (int i = 1; i <= n; i++) tong += i;
                        Console.WriteLine("Tổng = " + tong);
                        break;
                    case 2:
                        for (int i = 1; i <= 9; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                                Console.WriteLine("{0} x {1} = {2}", i,j, i * j);
                        }
                        break;
                }
            } while (chon != 0);
        }
    }
}
