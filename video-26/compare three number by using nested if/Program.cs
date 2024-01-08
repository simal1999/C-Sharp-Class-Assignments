using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_three_number_by_using_nested_if
{
    internal class Program
    {
        static void Main(string[] args)
        {// compare three values by using nested if 
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int c=int.Parse(Console.ReadLine());
            if (a > b && a > c)//if this condition is false the controll will go to else block
                Console.WriteLine($"Biggest number is: {a}");
            else
            {
                if (b > a && b > c)
                    Console.WriteLine($"Biggest number is: {b}");
                else if (c > a && c > b)
                    Console.WriteLine($"Biggest number is: {c}");
                else
                    Console.WriteLine("All are equal numbers");
            }
            Console.ReadLine();
        }
    }
}
