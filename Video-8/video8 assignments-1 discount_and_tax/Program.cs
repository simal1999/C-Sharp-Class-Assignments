using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_8_assignments_1_discount_and_tax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cname = "Rama";
            double p1 = 100;
            double p2 = 200;
            double p3 = 300;
            p1 = p1 - (p1 * 0.3);
            p2 = p2 - (p2 * 0.2);
            p3 = p3 - (p3 * 0.1);
            double bill=p1+p2+p3;
            double discount_bill = bill - (bill * 0.15);
            double tax_bill = discount_bill + (discount_bill * 0.2);
            Console.WriteLine(cname+" total bill is: "+tax_bill);
            Console.ReadLine();
        }
    }
}
