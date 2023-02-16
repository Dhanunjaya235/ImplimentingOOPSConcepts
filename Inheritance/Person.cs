using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Person
    {
        static Person()
        {
            Console.WriteLine("Person Class Static Constructor");
        }
        public Person() { Console.WriteLine("Person Class Constructor"); }
        internal ulong AadharNumber;
        internal string? Name;
        internal string? NativeCity;

        internal void Breakfast()
        {
            Console.WriteLine("Having BreakFast");
        }

        internal void Lunch()
        {
            Console.WriteLine("Having Lunch");
        }

        internal void Dinner()
        {
            Console.WriteLine("Having Dinner");
        }
    }
}
