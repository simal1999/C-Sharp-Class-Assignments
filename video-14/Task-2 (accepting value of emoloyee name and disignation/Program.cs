using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__accepting_value_of_emoloyee_name_and_disignation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name: ");
            string ename=Console.ReadLine();
            Console.WriteLine("Enter Employee Disignation: ");
            String dis=Console.ReadLine();
            Console.WriteLine("Employee Name is :" + ename);
            Console.WriteLine("Employee Disignation is :"+dis);
            Console.ReadLine();
        }
    }
}
