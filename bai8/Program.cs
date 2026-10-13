using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i <= x / i; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac so nguyen to khong vuot qua n:");

            for (int i = 2; i <= n; i++)
            {
                if (LaSoNguyenTo(i))
                    Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
