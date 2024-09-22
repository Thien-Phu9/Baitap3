using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 1
            //    Console.Write("Nhap so nguyen: ");
            //    int soNguyen = int.Parse(Console.ReadLine());

            //    if (soNguyen % 3 == 0)
            //    {
            //        Console.WriteLine("So nguyen chia het cho 3.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("So nguyen khong chia cho 3.");
            //    }
            //    Console.ReadKey();

            // Bai 2
            //Console.Write("Nhap so nguyen duong: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n > 0)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.WriteLine($"\nBang cuu chuong cua {i}:");
            //        for (int j = 1; j <= 10; j++)
            //        {
            //            Console.WriteLine($"{i} x {j} = {i * j}");
            //        }
            //    }           
            //    Console.ReadKey();
            //}


            // Bai 3
            //Console.Write("Nhap so nguyen duong n: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n > 0)
            //{
            //    long tongGiaiThua = 0;

            //    for (int i = 1; i <= n; i++)
            //    {
            //        long giaiThua = 1;

            //        for (int j = 1; j <= i; j++)
            //        {
            //            giaiThua *= j;
            //        }

            //        tongGiaiThua += giaiThua;
            //    }

            //    Console.WriteLine($"Tong giai thua tu 1 den {n} la: {tongGiaiThua}");
            //}
            //Console.ReadKey();

            // Bai 4
            //Console.Write("Nhap so chinh phuong: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n >= 0)
            //{
            //    int canBacHai = (int)Math.Sqrt(n);  // Tính căn bậc hai của số n
            //    if (canBacHai * canBacHai == n)
            //    {
            //        Console.WriteLine($"{n} la so chinh phuong.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{n} khong phai la so chinh phuong");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("So da nhap khong phai la so nguyen duong");
            //}
            //Console.ReadKey();

            //Bai 5
            //Console.Write("Nhap vao mot thang (1-12): ");
            //int thang = int.Parse(Console.ReadLine());
            //if (thang >= 1 && thang <= 12)
            //{
            //    int soNgay;
            //    switch (thang)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            soNgay = 31;
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            soNgay = 30;
            //            break;
            //        case 2:
            //            Console.Write("Nhap vao nam: ");
            //            int nam = int.Parse(Console.ReadLine());
            //            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            //            {
            //                soNgay = 29;
            //            }
            //            else
            //            {
            //                soNgay = 28;
            //            }
            //            break;
            //        default:
            //            soNgay = 0;
            //            break;
            //    }

            //    Console.WriteLine($"Thang {thang} co {soNgay} ngay.");
            //}
            //Console.ReadKey();

            //Bai 6 
            //{
            //    Console.Write("Nhap vao so nguyen n: ");
            //    int n = int.Parse(Console.ReadLine());
            //    long S = 0;

            //    for (int i = 1; i <= n; i++)
            //    {
            //        S += (long)Math.Pow(i, i); 
            //    }
            //    Console.WriteLine($"Tong S = {S}");
            //}
            //Console.ReadKey();

            //Bai 7
            //Console.Write("Nhap mot so nguyen n: ");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("Tong cac so le tu 1 den " + n + " la: " + sum);
            //Console.ReadKey();

            //Bai 8
            //Console.Write("Nhap mot so nguyen duong n: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Cac so nguyen to tu 1 den " + n + " la:");

            //for (int i = 2; i <= n; i++)
            //{
            //    int j;
            //    for (j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            break;
            //        }
            //    }
            //    if (j > Math.Sqrt(i))
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.ReadKey();

            //Bai 9
            //Console.Write("Nhap so hang n: ");
            //int n = int.Parse(Console.ReadLine());

            //// Ve tam giac thong thuong
            //Console.WriteLine("Tam giac thong thuong:");
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Ve tam giac deu
            //Console.WriteLine("Tam giac deu:");
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = i; j < n; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // In dau *
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Ve tam giac xoay nguoc
            //Console.WriteLine("Tam giac xoay nguoc:");
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //Bai 10
            Console.Write("Nhap mot so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;

            Console.WriteLine("Day Fibonacci voi " + n + " so:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");   
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.ReadKey();
        }
    }
}
