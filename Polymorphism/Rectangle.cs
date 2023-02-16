using UtilityLibrary;
namespace Polymorphism
{
    internal class Rectangle : Shape
    {
        private readonly double length, breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override double Area()
        {
            return length * breadth;
        }

        public override double Perimeter()
        {
            return 2 * (length + breadth);
        }
    }
}
