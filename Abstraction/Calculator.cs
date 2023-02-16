using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface Calculator
    {

        double Sum(double x,double y);

        double Add(double x,double y);
    }

    public class Casio : Calculator
    {
        public double Add(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Sum(double x, double y)
        {
            throw new NotImplementedException();
        }
    }

    public class CasioV2 : Casio
    {
        public double Add(int x, int y)
        {
            return x + y;
        }
    }
    public class Class1
    {
        protected void Welcome()
        {
            Console.WriteLine("Welcome");
        }
    }

    public class Class2 : Class1,Calculator
    {
        public double Add(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Sum(double x, double y)
        {
            throw new NotImplementedException();
        }

        protected void Wish()
        {
            base.Welcome();
            Console.WriteLine("Happy Birthday");
        }
    }

    public class Class3 : Class2
    {
        protected void Congrats()
        {
            base.Welcome();
            base.Wish();
            Console.WriteLine("Congratulations");
        }
    }

}
