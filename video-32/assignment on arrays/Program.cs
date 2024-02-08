using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_on_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {// declare and print 5 city names in 1d array
            string[] city = new string[5] { "Hyderabad", "Nellore", "Kakinada", "Delhi","Noida" };
            for (int i=0;i<city.Length;i++)
            {
                Console.WriteLine(city[i]);
            }
            Console.ReadLine();
        }
    }
}
