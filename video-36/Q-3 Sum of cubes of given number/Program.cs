using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3_Sum_of_cubes_of_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {//Printing sum of cubes of a given number.
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            int m = n;
            int rem = 0;
            int cubes = 0;
            while(n!=0)
            {
                rem = n % 10;
                cubes= cubes + (rem * rem * rem);
                n =n / 10;
            }
            Console.Write($"The sum of cubes of an {m} is {cubes}");
            Console.ReadLine();
        }
    }
}
