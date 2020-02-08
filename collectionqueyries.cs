using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Course
    {
        public int CID
        {
            get;set;
        }
        public string CName
        {
            get;set;
        }
        public DateTime StartDate
        {
            get;set;
        }
        public int Fees
        {
            get;set;
        }
        static void Main(string[] args)
        {
            List<Course> clst = new List<Course>()
            {
        new Course { CID = 1, CName = "Web Apps", Fees = 45000, StartDate = Convert.ToDateTime("05-05-2017")},
             new Course { CID = 2, CName = "C#", Fees = 48000, StartDate = Convert.ToDateTime("05-04-2018") },
             new Course { CID = 3, CName = "AI", Fees = 45000, StartDate = Convert.ToDateTime("05-05-2013") },
             new Course { CID = 4, CName = "ML", Fees = 43000, StartDate = Convert.ToDateTime("05-05-2016") }
            };
            Console.WriteLine();
            Console.WriteLine("The Whole data using query=");
            var query = from q in clst select q;
            foreach(var aq in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", aq.CID, aq.CName, aq.Fees, aq.StartDate.ToShortDateString());
            }


            Console.WriteLine();
            Console.WriteLine("The orderby keyword data query=");

            var query1 = from q1 in clst  orderby q1.Fees select q1;
            foreach(var aq1 in query1)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", aq1.CID, aq1.CName, aq1.Fees, aq1.StartDate.ToLongDateString());

            }


            Console.WriteLine();
            Console.WriteLine("The second data of query=");

            var query2 = from q2 in clst where q2.CID ==2 select q2;
            foreach(var aq2 in query2)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", aq2.CID, aq2.CName, aq2.Fees, aq2.StartDate.ToShortDateString());
            }

            


        }
    }
}
