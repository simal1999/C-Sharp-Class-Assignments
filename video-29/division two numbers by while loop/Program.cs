using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division_two_numbers_by_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b=int.Parse(Console.ReadLine()) ;
            while(b==0)
            {
                Console.WriteLine("Please enter other than zero:");
                Console.WriteLine("Enter second number: ");
                b = int.Parse(Console.ReadLine());
            }
            int result = a / b;
            Console.WriteLine($"Division result is: {result}.");
            Console.ReadLine();
        }
    }
}
