using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding= Encoding.Unicode;
        // Nhập vào 3 số nguyên a, b, c
        Console.WriteLine("Nhập vào 3 cạnh của tam giác:");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        // Kiểm tra điều kiện để a, b, c có tạo thành tam giác không
        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("a, b, c tạo thành một tam giác.");

            // Phân loại tam giác
            if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Đây là tam giác cân.");
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Đây là tam giác vuông.");
            }
            else
            {
                Console.WriteLine("Đây là tam giác thường.");
            }
        }
        else
        {
            Console.WriteLine("a, b, c không tạo thành một tam giác.");
            //

        }
    }
}
