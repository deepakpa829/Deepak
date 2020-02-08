using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml;
    
namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart tst = new ThreadStart(getnumbers);
            Thread th = new Thread(tst);
            //ThreadStart tst1 = new ThreadStart(Show);
            //Thread th1 = new Thread(tst1);
           // th1.Start();
            th.Start();
        }
        
        
        public static void getnumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(300);
            }
        }
    }
    }

