using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace adding_2_one_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write("Enter your number of 1st array:");
                a[i] = int.Parse(Console.ReadLine());
                Console.Write("\n");
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("Enter your number of 2nd array:");
                b[i] = int.Parse(Console.ReadLine());
                Console.Write("\n");
            }
            Console.WriteLine("Addition of two arrays are: ");
            for(int i = 0;i < c.Length; i++)
            {
                c[i] = a[i] + b[i];
                Console.Write(c[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
