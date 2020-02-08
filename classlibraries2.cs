using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;

namespace ConsoleAppCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            c1.NO1 = 400;
            c1.NO2 = 230;
            Console.WriteLine(c1.Add());
            Console.WriteLine(c1.Sub());
            Console.WriteLine(c1.Mult());
            Console.WriteLine(c1.Div());


        }
    }
}
