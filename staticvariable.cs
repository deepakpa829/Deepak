using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Sample
    {

        int no;
        static int count;

        public Sample()
        {
            no++;
            count++;
            Console.WriteLine("no={0}\n count={1}", no, count);

        }

        public void Show()
        {
            Console.WriteLine("This is a static method");
        }


    }
}
