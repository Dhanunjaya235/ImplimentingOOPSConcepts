using UtilityLibrary;
namespace Polymorphism
{
    internal class PolymorphismExample
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[2];

            shapes[0] = new Circle(59.72);
            shapes[1] = new Rectangle(76.15, 92.84);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
                Console.WriteLine(shape.Perimeter());
            }

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(23.34, 106.1009));

            Console.WriteLine(calculator.Add("Dhanunjaya", "Andavarapu"));

            Console.WriteLine(calculator.Add(23, 178));
        }
    }
}