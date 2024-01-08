using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_by_0_runtime_handle_by_using_simple_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            if (b==0)
            {
                Console.WriteLine("Please enter the value other than zero (0)");
                b = int.Parse(Console.ReadLine());
            }
            int c = a / b;
            Console.WriteLine("division result is:" + c);
            Console.ReadLine();
        }
    }
}
