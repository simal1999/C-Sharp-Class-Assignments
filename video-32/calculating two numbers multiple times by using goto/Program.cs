using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculating_two_numbers_multiple_times_by_using_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {//calculating two numbers multiple times by using goto.
        restart:
            Console.WriteLine("Enter first number: ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            
            int b=int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"The addition result:{c}");
            Console.WriteLine("Do you want to continue?\nPress y for continue\nPress any key for exit");
            char option = char.ToLower(char.Parse(Console.ReadLine()));
            if (option == 'y')
            {
                goto restart;
            }
        }
    }
}
