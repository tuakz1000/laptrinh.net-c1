using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap so nguyen tu 0 den 99: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 99)
            {
                Console.WriteLine("So khong hop le!");
                return;
            }

            string[] chuSo =
            {
            "khong", "mot", "hai", "ba", "bon",
            "nam", "sau", "bay", "tam", "chin"
        };

            if (n < 10)
            {
                Console.WriteLine(chuSo[n]);
                return;
            }

            int chuc = n / 10;
            int donVi = n % 10;
            string ketQua = "";

            switch (chuc)
            {
                case 1:
                    ketQua = "muoi";
                    break;
                case 2:
                    ketQua = "hai muoi";
                    break;
                case 3:
                    ketQua = "ba muoi";
                    break;
                case 4:
                    ketQua = "bon muoi";
                    break;
                case 5:
                    ketQua = "nam muoi";
                    break;
                case 6:
                    ketQua = "sau muoi";
                    break;
                case 7:
                    ketQua = "bay muoi";
                    break;
                case 8:
                    ketQua = "tam muoi";
                    break;
                case 9:
                    ketQua = "chin muoi";
                    break;
            }

            if (donVi != 0)
            {
                switch (donVi)
                {
                    case 1:
                        if (chuc > 1)
                            ketQua += " mot";
                        else
                            ketQua += " mot";
                        break;

                    case 4:
                        if (chuc > 1)
                            ketQua += " tu";
                        else
                            ketQua += " bon";
                        break;

                    case 5:
                        if (chuc > 1)
                            ketQua += " lam";
                        else
                            ketQua += " nam";
                        break;

                    default:
                        ketQua += " " + chuSo[donVi];
                        break;
                }
            }

            Console.WriteLine(ketQua);
        }
    }
}
