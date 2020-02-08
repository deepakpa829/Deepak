using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Calculate
    {

        public string area(int side)
        {
            int ar = side * side;
            return string.Format("sqaure area={0}", ar);

        }

        public string area(int l, int b)
        {
            int ar = l * b;
            return string.Format("Reactangle area={0}", ar);
        }

        public string area(double r)
        {
            double ar = Math.PI * r * r;
            return string.Format("area of circle={0}", ar);
        }



    }
}
