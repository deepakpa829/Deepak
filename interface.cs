using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{ 

    interface Ihello
    {
        void getit(int a,int b);
       
    }
    class Doit:Ihello
    {
       
    public void getit(int a,int b)
        {
            int c = a + b;

            Console.WriteLine("c="+c);
        }


    }
}
