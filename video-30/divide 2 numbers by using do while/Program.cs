using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_2_numbers_by_using_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {//divide 2 numbers by using do while and handle divided by 0 error.
            Console.Write("Enter first number      :");
            float a=int.Parse(Console.ReadLine());
            Console.Write("Enter second number     :");
            float b;
            do 
            { 
             b = int.Parse(Console.ReadLine());
                if (b == 0) 
                {
                    Console.WriteLine("Enter other than zero.");
                    Console.Write("Enter second number     :");
                }
            }
            while(b==0);
            float result = a / b;
            Console.WriteLine($"Division result is :{result}");
            Console.ReadLine();
        }   
    }
}
