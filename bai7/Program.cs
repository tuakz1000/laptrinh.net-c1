using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.Write("n phai > 0. Nhap lai n: ");
                n = int.Parse(Console.ReadLine());
            }

            int tong = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int demChan = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Nhap so nguyen thu {i}: ");
                int x = int.Parse(Console.ReadLine());

                tong += x;

                if (x > max)
                    max = x;

                if (x < min)
                    min = x;

                if (x % 2 == 0)
                    demChan++;
            }

            double trungBinh = (double)tong / n;

            Console.WriteLine($"Tong = {tong}");
            Console.WriteLine($"Trung binh = {trungBinh:F2}");
            Console.WriteLine($"So lon nhat = {max}");
            Console.WriteLine($"So nho nhat = {min}");
            Console.WriteLine($"So luong so chan = {demChan}");
        }
    }
}
