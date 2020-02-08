using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam ex = new Exam();
            ex.getdata("Final", 556565,"03/april/1997");
            ex.showdata();

            Exam ex1 = new Exam();
            ex.getdata("Semister", 87867, "02/march/1998");
            ex.showdata();
        }
    }
}
