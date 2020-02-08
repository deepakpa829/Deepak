using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            getobj();
            
        }

        private static void getobj()
        {
            Trainee tr = new Trainee();
            tr.getdata("Deepak", "Pune", 21, 354555);
            tr.showdata();

            Trainee tr1 = new Trainee();
            tr.getdata("Sanket", "Ahmadnagar", 22, 565457);
            tr.showdata();
        }
    }
}
