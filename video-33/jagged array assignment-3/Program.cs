using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] a = new string[3][];
            a[0]=new string[] {"Dotnet"," Java","Php"};
            a[1] = new string[] {"Sap" };
            a[2] = new string[] { "C++", "C" };
            for (int i=0;i<a.Length;i++) 
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
