namespace Polymorphism
{
    public class Calculator
    {
        public int Add(int x, int y) => x + y;

        public double Add(double x, double y) => x + y;

        public string Add(string x, string y) => $"{x} {y}";
    }
}
