using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__Accept_student_details_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter student course: ");
            string course=Console.ReadLine();
            Console.WriteLine("Enter student college: ");
            string college=Console.ReadLine();
            Console.WriteLine("Student Name is      : "+name);
            Console.WriteLine("Student Course is    : " + course);
            Console.WriteLine("Student College is   : "+college);
            Console.ReadLine();
        }
    }
}
