using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a;
                int b;
                Console.WriteLine("Enter the a=");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the b=");
                b = int.Parse(Console.ReadLine());
                int c = a / b;
             }
            catch(Exception1 r)
            {
                Console.WriteLine(r);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                Console.WriteLine("The Code is rest");
            }



        }
    }
}
