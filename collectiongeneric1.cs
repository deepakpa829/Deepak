using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Course
    {

        public int Cid { get; set; }

        public string Cname { get; set; }

        public DateTime startdate { get; set; }

        public int Fees{get; set;}



        static void Main(string[] args)
        {

            Console.WriteLine("The List generic Collection are as follws:");
            List<Course> Courselist = new List<Course>();

            Courselist.Add(new Course {Cid=11,Cname="C#",startdate=DateTime.Today,Fees=60000 });

            Courselist.Add(new Course { Cid = 12, Cname = "JAVA", startdate = DateTime.Parse("09-08-2020"), Fees = 70000 });
            Courselist.Add(new Course { Cid = 13, Cname = "C++", startdate = DateTime.Parse("04-03-1997"), Fees = 65000 });
            Courselist.Add(new Course { Cid = 14, Cname = "C", startdate = Convert.ToDateTime("23-03-2019"), Fees = 35000 });


            foreach (Course cr in Courselist)
            {
                Console.WriteLine("id={0}\t name={1}\t startdate={2}\t fees={3}",cr.Cid,cr.Cname,cr.startdate,cr.Fees);
            }




            Console.WriteLine();
            Console.WriteLine("The Hashset generic Collection are as follows:");
            HashSet<Course> hst = new HashSet<Course>();
            hst.Add(new Course { Cid = 21, Cname = "SAP", startdate = DateTime.Parse("03-08-2013"), Fees = 23000 });
            hst.Add(new Course { Cid = 22, Cname = "RUBY", startdate = DateTime.Parse("03-08-2018"), Fees = 27000 });
            hst.Add(new Course { Cid = 23, Cname = "PYTHON", startdate = DateTime.Parse("03-06-2014"), Fees = 28000 });
            hst.Add(new Course { Cid = 24, Cname = "PHP", startdate = DateTime.Parse("03-05-2012"), Fees = 20000 });

            foreach(Course t in hst)
            {
                Console.WriteLine("ID={0}\t name={1}\t startdate={2}\t Fees={3}", t.Cid, t.Cname, t.startdate, t.Fees);
            }

            Console.WriteLine();
            Console.WriteLine("The stack generic collections are as follows:");

            Stack<Course> stcr = new Stack<Course>();
            stcr.Push(new Course { Cid = 31, Cname = "HTML", startdate = DateTime.Today, Fees = 22000 });
            stcr.Push(new Course { Cid = 32, Cname = "CSS", startdate = DateTime.Parse("04-03-2013"), Fees = 24000 });
            stcr.Push(new Course { Cid = 33, Cname = "JAVASCRIPT", startdate = DateTime.Parse("22-01-2014"), Fees = 26000 });
            stcr.Push(new Course { Cid = 34, Cname = "JSQL", startdate = DateTime.Parse("08-06-2012"), Fees = 29000 });

            foreach(Course y in stcr)
            {
                Console.WriteLine("Id={0}\t name={1}\t startdate={2}\t Fees={3}", y.Cid, y.Cname, y.startdate, y.Fees);
            }

        }
    }
}
