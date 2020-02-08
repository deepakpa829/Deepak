using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Student
    {

        string firstname;
        string lastname;
        int idno;
        string course;


        public Student()
        {

        }

        public string Firstname
        {

            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {

            get { return lastname; }
            set { lastname = value; }
        }

        public int Idno
        {
            get { return idno; }
            set { idno = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }

        }


    }
}
