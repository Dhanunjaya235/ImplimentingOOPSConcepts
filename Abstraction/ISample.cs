using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal interface ISample
    {
        void Method();
    }

    internal abstract class Abs1
    {
        public static double pi = 3.1416;
        public abstract void Method1();
    }

    internal class NormalClass : Abs1, ISample
    {
        public void Method()
        {
            Console.WriteLine("Interface method");
        }

        public override void Method1()
        {
            Console.WriteLine("Abstract class method");
        }
    }
}
