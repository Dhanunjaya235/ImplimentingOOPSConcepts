using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1
    {
        public static int x = 20;
        public int y = 40;


        public static  void Method()
        {
            Console.WriteLine("Static Method");
        }
    }

    internal class Class2 : Class1
    {
        
    }
}
