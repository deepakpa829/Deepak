using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp52
{
    class Program
    {
        ArrayList alist = new ArrayList();
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList()
             { "Sanket","Ram","Guru","Kartik"};
            foreach(string a in ar)
            {
                Console.WriteLine("The data="+a);
            }
            ar.Sort();
            foreach(string b in ar)
            {
                Console.WriteLine("The sort data="+b);
            }
            ar.Insert(3, "Shubham");
            foreach(string c in ar)
            {
                Console.WriteLine("The Insert data="+c);
            }
            ar.Add("Munna");
            foreach(string d in ar)
            {
                Console.WriteLine("The added data="+d);
            }
            ar.Reverse();
            foreach(string e in ar)
            {
                Console.WriteLine("The revesre data=" + e);
            }
            ar.Remove(3);
            foreach(string f in ar)
            {
                Console.WriteLine("The Remove keys are=" + f);
            }


            Console.WriteLine();

            Hashtable ht = new Hashtable();
           
            Console.WriteLine("The Hashtable Operations are=");
            ht.Add("Sanket", "12334");
            ht.Add("Ram", "12356");
            ht.Add("Shankar", "67895");
            foreach(string n in ht.Keys)
            {
                Console.WriteLine(n);
            }
            foreach(string t in ht.Values)
            {
                Console.WriteLine(t);
            }


            Console.WriteLine();

            Stack st = new Stack();
            Console.WriteLine("The stack operations are=");
            st.Push("Chocolate");
            st.Push("Buiscuit");
            st.Push("Cake");
           // st.Pop("Buiscuit");
            foreach(string m in st)
            {
                Console.WriteLine(m);
            }




            Console.WriteLine();
            Queue qu = new Queue();
            Console.WriteLine("The Queue Operations are=");
            qu.Enqueue(345);
            qu.Enqueue(346);
            qu.Enqueue(347);
            
            foreach(int x in qu)
            {
                Console.WriteLine(x);
            }

            qu.Dequeue();
            Console.WriteLine();
            foreach(int o in qu)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();
            SortedList slist = new SortedList();
            slist.Add("Shanku", 123);
            slist.Add("sonal", 124);
            slist.Add("Dabang", 456);
            foreach(string q in slist.Keys)
            {
                Console.WriteLine(q);
            }
            foreach(int r in slist.Values)
            {
                Console.WriteLine(r);
            }



        }
    }
}
