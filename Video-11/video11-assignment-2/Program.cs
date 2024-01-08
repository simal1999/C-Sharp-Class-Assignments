using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video11_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong cid = 113;
            string cname = "Simal";
            string cloc = "hyderabad";
            uint cpincode = 502032;
            ulong cphone = 9505445051;
            string cmail = "manikantasimal1999@gmai.com";
            double p1cost = 60;
            double p2cost = 70;
            double p3cost = 80;
            double totalbill=p1cost+p2cost+p3cost;
            Console.WriteLine("Custoner id is               : "+cid);
            Console.WriteLine("Custoner name is             : " + cname);
            Console.WriteLine("Custoner location is         : " + cloc);
            Console.WriteLine("Custoner pincode is          : " + cpincode);
            Console.WriteLine("Custoner phone number is     : " + cphone);
            Console.WriteLine("Custoner mail id is          : " + cmail);
            Console.WriteLine("Custoner total bill is       : " + totalbill);
            Console.ReadLine();

        }
    }
}
