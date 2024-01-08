using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1__accept_first_name_last_name_and_location__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First name: ");
            string fname= Console.ReadLine();
            Console.WriteLine("Enter your Last name: ");
            string lname=Console.ReadLine();
            Console.WriteLine("Enter your location: ");
            string location=Console.ReadLine();
            Console.WriteLine("Your First Name is :" + fname);
            Console.WriteLine("Your Last Name is  :" + lname);
            Console.WriteLine("Your Location is   :" +location);
            Console.ReadLine();

        }
    }
}
