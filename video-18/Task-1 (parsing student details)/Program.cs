using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1__parsing_student_details_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter 1st subject marks: ");
            float m1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd subject marks: ");
            float m2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd subject marks: ");
            float m3 = float.Parse(Console.ReadLine());
            float total_marks = m1 + m2 + m3;
            float gracemarks = total_marks + (total_marks * 0.1f);
            float avgmarks = gracemarks / 3;
            Console.WriteLine($"{name} total marks are:{total_marks}");
            Console.WriteLine($"{name} average marks are: {avgmarks}");
            Console.ReadLine();
        }
    }
}
