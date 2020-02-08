using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculate cal = new Calculate();

            Console.WriteLine(cal.area(10));
            Console.WriteLine(cal.area(30, 50));
            Console.WriteLine(cal.area(40));



        }
    }
}
