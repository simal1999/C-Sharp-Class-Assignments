using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__10__discount_bill_by_using_type_casting_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10% discount on total bill
            Console.WriteLine("Enter customer name: ");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter C1 cost: ");
            float C1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter C2 cast: ");
            float C2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter C3 cast: ");
            float C3 = float.Parse(Console.ReadLine());
            float total = C1 + C2 + C3;
            float discount_bill = total - (total * 0.1f);
            Console.WriteLine($"{cname} total bill is: {discount_bill}");
            Console.ReadLine();
        }
    }
}
