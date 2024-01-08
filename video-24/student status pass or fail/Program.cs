using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_status_pass_or_fail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter telugu marks :");
            float m1=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hindi marks  :");
            float m2=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter english marks:");
            float m3=float.Parse(Console.ReadLine());
            float total=m1+m2+m3;
            float avg = total / 3;
            if (m1 < 35 | m2 < 35 | m3 < 35)//in or operator any one condition is true it will execute that block otherwise it will not execute   
                Console.WriteLine($"{name} your result is:Fail");
            else if (avg >= 60)
                Console.WriteLine($"{name} your result is:First Class");
            else if (avg >= 50)
                Console.WriteLine($"{name} your result is:Second Class");
            else
                Console.WriteLine($"{name} your result is:Third Class");
            Console.ReadLine();

        }
    }
}
