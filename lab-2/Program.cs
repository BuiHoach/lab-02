using System.Text;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Nhâp thông tin nhân viên :");
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // khai báo biến
            String id, name, Diachi;
            Double salary, bonus, totalSalary;
            DateTime birthday;

            Console.Write("Nhập mã số:");
            id = Console.ReadLine();
            //họ tên
            Console.Write("Nhập họ ten:");
            name = Console.ReadLine();
            // địa chỉ
            Console.Write("Nhập địa chỉ:");
            Diachi = Console.ReadLine();
            // birthday
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Lương cơ bản:");
            salary = Convert.ToDouble(Console.ReadLine());
            //thưởng
            Console.Write("Lương thưởng:");
            bonus = Convert.ToDouble(Console.ReadLine());
            // tổng lương
            totalSalary = salary + bonus;
            // hiển thị thông tin ra màn hình

            Console.WriteLine("\n Nhâp thông tin nhân viên :");
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Id: {0}", id);
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("Diachi: {0}", Diachi);
            Console.WriteLine("Ngày sinh (dd/MM/yyyy): {0}", birthday);
            Console.WriteLine("Lương cơ bản:{0}", salary);
            Console.WriteLine("Lương thưởng:{0}", bonus);
            Console.WriteLine("totalSalary: {0}", totalSalary);
            Console.WriteLine("----------------------------");
            // bài 2
            // Nhập năm và tháng từ người dùng
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding =Encoding.Unicode;

            Console.Write("Nhập năm: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int month = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra tính hợp lệ của tháng
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Tháng không hợp lệ! Vui lòng nhập từ 1 đến 12.");
            }
            else
            {
                // Tính số ngày trong tháng
                int daysInMonth = DateTime.DaysInMonth(year, month);

                // Hiển thị kết quả
                Console.WriteLine($"Tháng {month} năm {year} có {daysInMonth} ngày.");

            }
        }
    }
}
