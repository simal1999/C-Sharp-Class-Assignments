using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vide5_assignment_3_calculate_10__discount__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 50;
            double p2 = 60;
            double p3 = 70;
            double total = p1 + p2 + p3;
            double discountbill=total-(total*0.1);
            Console.WriteLine(discountbill);
            Console.ReadLine();
        }
    }
}
