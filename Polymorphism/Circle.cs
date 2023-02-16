using UtilityLibrary;
namespace Polymorphism
{
    internal class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * radius;
        }
    }
}
