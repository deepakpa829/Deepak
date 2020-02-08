using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {

            Product pd = new Product { Id = 12, Name = "Deepak" };

            Console.WriteLine("Id={0}\n name={1}", pd.Id, pd.Name);


            Product pd1 = new Product { Id = 22, Name = "Sanket" };

            Console.WriteLine("Id={0}\n name={1}", pd1.Id, pd1.Name);
        }
    }
}
