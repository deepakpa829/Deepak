using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstConsoleApp
{
    class Program
    {
       static deepEntities3 mdb = new deepEntities3();
        static void Main(string[] args)
        {

            // AllCourses();

            InsertCourse();
            Show();


        }
        public static void InsertCourse()
        {
            
            Console.WriteLine("Enter the CourseId");
            int Courseid1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the CourseTital");
            string CourseTit = Console.ReadLine();
            Console.WriteLine("Enter the startdate");
            DateTime startdat = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fees");
           decimal fee = decimal.Parse(Console.ReadLine());
            var Course = new Course
            {
                Courseid = Courseid1,
             CourseTitle = CourseTit,
               StartDate = startdat,
                Fees = fee

            };
            mdb.Courses.Add(Course);
            mdb.SaveChanges();

        }
        public static void Show()
        {
             
            Console.WriteLine("All courses are...");
            var courses = mdb.Courses;
            foreach (var c in courses)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", c.Courseid, c.CourseTitle, c.StartDate, c.Fees);
            }

        }
       
}
}
