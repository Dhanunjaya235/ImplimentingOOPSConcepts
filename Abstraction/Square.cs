using UtilityLibrary;
namespace Abstraction
{
    internal partial class Square : Shape
    {
        private readonly double length;

        public Square(double length)
        {
            this.length = length;
        }
        public override double Area()
        {
            return length * length;
        }

        public override double Perimeter()
        {
            return 4* length;
        }
    }

    public abstract class AbsClass1
    {
        public abstract void Method();
    }

    public abstract class AbsClass2 : AbsClass1
    {
        public abstract void Method2();

    }

    public class ClassCls : AbsClass2
    {
        public override void Method()
        {
            throw new NotImplementedException();
        }

        public override void Method2()
        {
            throw new NotImplementedException();
        }
    }
}
