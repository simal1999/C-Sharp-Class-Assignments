using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video8_assignment_3
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
            double discount = p1d + p2d + p3d;
            double discount_bill = bill - discount;
            double extra_dis = discount_bill * 0.15;
            discount = discount + extra_dis;
            discount_bill=discount_bill - extra_dis;
            double tax = discount_bill * 0.2;
            double paid_bill = discount_bill +  tax;
            Console.WriteLine("P1 discount is: " + p1d);
            Console.WriteLine("P2 discount is: " + p2d);
            Console.WriteLine("P3 discount is: " + p3d);
            Console.WriteLine(cname + "total discount is: " + discount);
            Console.WriteLine(cname + "total paid tax is: " + tax);
            Console.WriteLine(cname + " actual bill is: " + bill);
            Console.WriteLine(cname + "paid bill is: " + paid_bill);
            Console.ReadLine();
        }
    }
}
