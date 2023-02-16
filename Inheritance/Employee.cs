using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : Student
    {
        static Employee()
        {
            Console.WriteLine("Employee Class Static Constructor");
        }
        public Employee() { Console.WriteLine("Employee Class Constructor"); }
        internal string? CompanyName;

        internal ushort employeeid;

        internal string? CurrentArea;

        internal string? role;

        internal void OfficeTime()
        {
            Console.WriteLine("I am in office now");
        }
    }
}
