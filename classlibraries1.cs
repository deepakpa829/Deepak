using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibCalculation
{

    public class Calculation
    {
        public int NO1 { get; set; }
        public int NO2 { get; set; }


        public string Add()
        {
            return string.Format("Sum={0}", NO1 + NO2);
        }

        public string Sub()
        {
            return string.Format("Substraction={0}", NO1 - NO2);
        }

        public string Mult()
        {
            return string.Format("Product={0}", NO1 * NO2);
        }

        public string Div()
        {
            return string.Format("Division={0}", NO1 / NO2);
        }
    }
}
