using System;
using System.Text;

namespace lab_bài2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Nhập số giây từ người dùng
            Console.Write("Nhập số giây (số nguyên dương): ");
            int totalSeconds = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra số giây có phải số nguyên dương không
            if (totalSeconds < 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương.");
            }
            else
            {
                // Tính toán giờ, phút, giây
                int hours = totalSeconds / 3600; // 1 giờ = 3600 giây
                int minutes = (totalSeconds % 3600) / 60; // Tính số phút còn lại
                int seconds = totalSeconds % 60; // Phần giây còn lại

                // Hiển thị kết quả
                Console.WriteLine($"Định dạng hh:mm:ss là: {hours:D2}:{minutes:D2}:{seconds:D2}");
            }
            //bài 2.4
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Các số có tổng 3 chữ số là chẵn trong khoảng từ 100 đến 999:");

            // Duyệt qua tất cả các số từ 100 đến 999
            for (int i = 100; i <= 999; i++)
            {
                // Lấy từng chữ số của số i
                int hundreds = i / 100;       // Chữ số hàng trăm
                int tens = (i / 10) % 10;    // Chữ số hàng chục
                int units = i % 10;          // Chữ số hàng đơn vị

                // Tính tổng các chữ số
                int sum = hundreds + tens + units;

                // Kiểm tra tổng có chẵn không
                if (sum % 2 == 0)
                {
                    Console.WriteLine(i); // In số thỏa mãn
                }

            }
            // bài 2.4
            Console.WriteLine("----------------------------");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            // b
            Console.WriteLine("----------------------------");
            for (int i = 6; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();

            }
            // c

            //int rows = 6;
            //Console.WriteLine("----------------------------");
            //for (int i = 1; i <= rows; i++)
            //{
            //    // In khoảng trắng
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // In ký tự *
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            int n = 10; // Số dòng của hình

            for (int i = 1; i <= n; i++)
            {
                // In khoảng trắng
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // In dãy số tăng
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }

                // In dãy số giảm
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }

                // Xuống dòng
                Console.WriteLine();
            }
        }
    }
}
