using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    struct Demo
    {
        int no;
        int no1;
        
        public Demo(int x,int y)
        {
            no = x;
            no1 = y;
        }
        public void Show()
        {
            Console.WriteLine("no={0} no1={1}", no, no1);
        }


        public static Demo operator +(Demo x,Demo y)
        {
            Demo t = new Demo();
            t.no = x.no + y.no;
            t.no1 = x.no1 + y.no1;
            return t;
        }

        public static Demo operator -(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no - y.no;
            t.no1 = x.no1 - y.no1;
            return t;
        }

        public static Demo operator *(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no * y.no;
            t.no1 = x.no1 * y.no1;
            return t;
        }

        public static Demo operator /(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no / y.no;
            t.no1 = x.no1 / y.no1;
            return t;
        }


    }
}
