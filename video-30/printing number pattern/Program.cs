using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printing_number_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        
       {
            /*output like below
            ----------------------------------------------
            10
            20
            30
            40 50 60
            70
            80
            90*/

            int i = 10;
            do
            {
                if (i <= 30)
                    Console.WriteLine(i + " ");
                else if (i <= 50)
                    Console.Write(i + " ");
                else
                    Console.WriteLine(i + " ");
                i +=10;
            }
            while (i <= 90);
            Console.ReadLine();
        }
    }
}
