using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video8_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cname = "rama";
            double p1 = 100;
            double p2 = 200;
            double p3 = 300;
            double p1d = p1 * 0.3;
            double p2d = p2 * 0.2;
            double p3d = p3 * 0.1;
            double bill = p1 + p2 + p3;
            double discount=p1d+p2d+p3d;
            bill = bill - discount;
            double billdis = bill * 0.15;
            discount = discount + billdis;
            bill = bill - billdis;
            double tax = bill * 0.2;
            bill = bill + tax;
            Console.WriteLine(cname + "total discount is: " + discount);
            Console.WriteLine(cname + "total tax paid is: " + tax);
            Console.WriteLine(cname + "total bill is: " + bill);
            Console.ReadLine();

        }
    }
}
