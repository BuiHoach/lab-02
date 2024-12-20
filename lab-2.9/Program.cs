using System.Text;

namespace lab_2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // Nhập vào số tiền gửi, lãi suất năm và số tháng gửi
            Console.Write("Nhập số tiền gửi ban đầu (VND): ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Nhập lãi suất ngân hàng (tính theo năm - %): ");
            double annualInterestRate = double.Parse(Console.ReadLine());

            Console.Write("Nhập số tháng gửi: ");
            int months = int.Parse(Console.ReadLine());

            // Tính lãi suất tháng
            double monthlyInterestRate = (annualInterestRate / 12) / 100;

            // Biến lưu số tiền cuối kỳ
            double totalAmount = principal;

            // Tính lãi tích lũy
            for (int i = 1; i <= months; i++)
            {
                double interest = totalAmount * monthlyInterestRate;
                totalAmount += interest; // Cộng lãi vào gốc
            }

            // Xuất kết quả
            double totalInterest = totalAmount - principal; // Lãi tổng cộng
            Console.WriteLine("\nKết quả:");
            Console.WriteLine($"Số dư cuối kỳ: {totalAmount:F2} VND");
            Console.WriteLine($"Tổng tiền lãi: {totalInterest:F2} VND");
        }
    }
}
