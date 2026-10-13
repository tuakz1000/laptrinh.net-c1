using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
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
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Ve tam giac vuong dac");
                Console.WriteLine("2. Ve tam giac vuong rong");
                Console.WriteLine("3. Ve hinh vuong rong");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());

                if (chon >= 1 && chon <= 3)
                {
                    Console.Write("Nhap kich thuoc n: ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Kich thuoc phai > 0!");
                        continue;
                    }

                    switch (chon)
                    {
                        case 1:
                            // Tam giac vuong dac
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                    Console.Write("* ");

                                Console.WriteLine();
                            }
                            break;

                        case 2:
                            // Tam giac vuong rong
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    if (j == 1 || j == i || i == n)
                                        Console.Write("* ");
                                    else
                                        Console.Write("  ");
                                }

                                Console.WriteLine();
                            }
                            break;

                        case 3:
                            // Hinh vuong rong
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= n; j++)
                                {
                                    if (i == 1 || i == n ||
                                        j == 1 || j == n)
                                        Console.Write("* ");
                                    else
                                        Console.Write("  ");
                                }

                                Console.WriteLine();
                            }
                            break;
                    }
                }
                else if (chon != 0)
                {
                    Console.WriteLine("Lua chon khong hop le!");
                }

            } while (chon != 0);

            Console.WriteLine("Da thoat chuong trinh.");
        }
    }
}
