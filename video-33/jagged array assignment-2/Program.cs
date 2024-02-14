using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0]=new int[] {10};
            a[1]=new int[] {20,30};
            a[2] = new int[] { 40, 50, 60 };
            for (int i =0;i<a.Length;i++) 
            {
                for(int j = 0; j < a[i].Length;j++)
                {
                    Console.Write(a[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
