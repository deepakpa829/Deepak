using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {

            Demo dt = new Demo(60, 70);
            dt.Show();
            Demo dt1 = new Demo(60, 70);
            dt1.Show();
            Demo rel = new Demo();

            Console.WriteLine(" The Addition");
            rel = dt + dt1;
            rel.Show();
            Console.WriteLine(" The Substraction");
            rel = dt - dt1;
            rel.Show();
            Console.WriteLine("The Multiplication");
            rel = dt * dt1;
            rel.Show();
            Console.WriteLine("The Division");
            rel = dt / dt1;
            rel.Show();





        }
    }
}
