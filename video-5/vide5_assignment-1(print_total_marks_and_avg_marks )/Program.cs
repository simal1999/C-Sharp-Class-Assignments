using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vide5_assignment_1_print_total_marks_and_avg_marks__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m1 = 20;
            double m2 = 30;
            double m3 = 50;
            double totalmarks=m1+m2+m3;
            double avgmarks=totalmarks/3;
            Console.WriteLine(totalmarks);
            Console.WriteLine(avgmarks);
            Console.ReadLine();
        }
    }
}
