using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_dimension_to_print_1_to_15_numbers_with_different_out_puts
{
    internal class Program
    {
        static void Main(string[] args)
        {//multi dimension to print 1 to 15 numbers with different out puts.
            int[,] a=new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 },{ 11,12,13,14,15} };
            for(int i=0;i<3;i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i==1||j==4)
                    Console.WriteLine(a[i, j]+" ");
                    else
                        Console.Write(a[i, j] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
