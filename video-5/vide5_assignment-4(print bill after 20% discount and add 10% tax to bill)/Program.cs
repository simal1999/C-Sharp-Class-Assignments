using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace vide5_assignment_4_print_bill_after_20__discount_and_add_10__tax_to_bill_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 50;
            double p2 = 60;
            double p3 = 70;
            double total_bill = p1 + p2 + p3;
            double discountbill = total_bill - (total_bill * 0.2);
            double main_bill = discountbill + (discountbill * 0.1);
            Console.WriteLine(main_bill);
            Console.ReadLine();
        }
    }
}
