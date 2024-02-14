using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Q_1_Prime_numbers_with_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {// Printing prime numbers with in given range.
            Console.Write("Enter your number range to see the prime numbers:\t");
            int n = int.Parse(Console.ReadLine());
            for(int i=2; i<=n; i++)
            {
                byte count = 0;
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.Write(i+" ");
                }
            }
                Console.ReadLine();
        }
    }
}
