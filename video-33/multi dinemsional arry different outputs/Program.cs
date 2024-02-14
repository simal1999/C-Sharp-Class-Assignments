using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_dinemsional_arry_different_outputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3, 4, 5 },
                                    { 6, 7, 8, 9, 10 }, 
                                    { 11, 12, 13, 14, 15 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || (i == 1 && j == a.GetLength(1) - 1))

                        Console.WriteLine(a[i, j] + " ");
                    else
                        Console.Write(a[i, j] + " ");
                        
                   
                }
                
            }
                Console.ReadLine();
        }
    }
}
