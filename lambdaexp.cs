using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> Cube = a => a * a * a;
            Console.WriteLine("Enter the number=");
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(Cube(cr));
        }
    }
}
