using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class NumberCalci : Calculator, Addition
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sum(double x,double y)
        {
            return x + y;
        }

        void Addition.Add(double x, double y)
        {
            Console.WriteLine(x+y);
        }
    }
}
