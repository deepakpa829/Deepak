using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Trainee
    {
        string name, address;
        int age, id;

        public void getdata(string nm, string addr, int ag, int id)
        {

            name = nm;
            address = addr;
            this.id = id;
            age = ag;

        }
        public void showdata()
        {
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(id);
            Console.WriteLine(age);


        }

    }
}
