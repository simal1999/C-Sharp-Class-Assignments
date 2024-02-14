using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2_Sum_of_squares_of_an_given_umber
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Printing sum of squares of an guven number
                            output
             ------------------------------------------------
             123
             the squares of an given number is 14 (1^2+2^2+3^2=14)*/
            Console.Write("Enter your numer:\t");
            int n=int.Parse(Console.ReadLine());
            int m = n;
            int rem=0;
            int square = 0;
            while (n != 0)
            {
                rem = n%10;
                square = square + (rem * rem);
                n = n / 10;
            }
            Console.Write($"The sum of squares of {m} is {square}");
            Console.ReadLine();
        }
    }
}
