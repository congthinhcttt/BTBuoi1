using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTBuoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập hệ số a, b, c
            Console.Write("Nhap he so a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Kiểm tra phương trình có phải là bậc 2 không
            if (a == 0)
            {
                Console.WriteLine("Day khong phai la phuong trinh bac 2.");
            }
            else
            {
                // Tính delta (b^2 - 4ac)
                double delta = b * b - 4 * a * c;

                // Giải phương trình dựa vào delta
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep: x = {x}");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }

            // Dừng chương trình để xem kết quả
            Console.ReadLine();
        }
    }
}
