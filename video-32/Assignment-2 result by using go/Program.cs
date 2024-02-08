using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_result_by_using_go
{
    internal class Program
    {
        static void Main(string[] args)
        {
        restart:
            Console.Write("Enter first subject marks :");
            double m1=double.Parse(Console.ReadLine());
            Console.Write("Enter second subject marks:");
            double m2=double.Parse(Console.ReadLine());
            Console.Write("Enter third subject marks :");
            double m3=double.Parse(Console.ReadLine());
            double total_avg = (m1 + m2 + m3)/3;
            if (m1 < 35 || m2 < 35 || m3 < 35)
                Console.WriteLine("Fail");
            else if (total_avg >= 60)
                Console.WriteLine("First Class");
            else if (total_avg >= 50)
                Console.WriteLine("Second Class");
            else if (total_avg >= 35)
                Console.WriteLine("Third Class");
            Console.WriteLine("Do you want to continue this process again?\nPress 'y' for yes.\nPress any key for exit");
            char option=char.ToLower(char.Parse(Console.ReadLine()));
            if (option == 'y')
            {
                goto restart;
            }
        }
    }
}
