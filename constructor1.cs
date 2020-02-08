using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar1 = new Car();
            mycar1.showcar();
            Car mycar2 = new Car("JHJHHJ9977");
            mycar2.showcar();
            Car mycar = new Car("APKL789","Suzuki","red");
            mycar.showcar();
        }
    }
}
