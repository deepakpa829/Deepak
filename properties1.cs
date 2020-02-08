using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st = new Student();
            st.Firstname = "Deepak";
            st.Lastname = "patil";
            st.Idno = 856780;
            st.Course = "C++";
            Console.WriteLine("firstname is={0}\n lastname is={1} ID is={2}\n Course is= {3}", st.Firstname, st.Lastname,st.Idno, st.Course);


            
        }
    }
}
