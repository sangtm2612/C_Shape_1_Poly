using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._3_NhapXuatGiaTriTuBanPhim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin chào : " + name);
            Console.WriteLine("Có phải bạn: " + GetAge(year) + " tuổi?");
        }

        public static int GetAge(int years)
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.Year - years;
        }



    }
}
