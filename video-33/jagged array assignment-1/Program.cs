using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[] { 10, 20, 30 };
            array[1] = new int[] { 40, 50 };
            array[2] = new int[] { 60 };
            for(int i=0;i<array.Length;i++) 
            {
                for (int j = 0; j < array[i].Length;j++)
                {
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
