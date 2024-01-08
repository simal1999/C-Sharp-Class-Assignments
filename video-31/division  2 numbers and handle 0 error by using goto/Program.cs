using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division__2_numbers_and_handle_0_error_by_using_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //division  2 numbers and handle 0 error by using goto
            Console.Write("Enter first number     :");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Enter second number    :");
            int b=int.Parse(Console.ReadLine());
            restart:
            if(b==0)
            {
                Console.WriteLine("Please enter other than zero");
                b = int.Parse(Console.ReadLine());
                goto restart;
            }
            int result = a / b;
            Console.WriteLine($"Division result is     :{result}");
            Console.ReadLine();
        }
    }
}
