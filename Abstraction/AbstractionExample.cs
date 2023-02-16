using UtilityLibrary;
namespace Abstraction
{
    internal class AbstractionExample
    {
        static void Main(string[] args)
        {

            ISample nc=new NormalClass();
            ((Abs1)nc).Method1();
            nc.Method();
            Console.WriteLine(Environment.NewLine);

       
            //double length,height,width;
            //Console.WriteLine("Enter length height width");
            //length= Math.Abs( double.Parse(Console.ReadLine()));
            //height= Math.Abs( double.Parse(Console.ReadLine()));
            //width= Math.Abs(double.Parse(Console.ReadLine()));
            //Shapes3D shape;

            //if (length == width && width== height)
            //{
            //    shape = new Cube(length, height, width);
            //}
            //else
            //{
            //    shape = new Cuboid(length, height, width);
            //}

            //Console.WriteLine(shape.Volume());


            //Console.WriteLine("Hello, World!");
            //Shape s = new Square(37.89);
            //Console.WriteLine(s.Area());
            //Console.WriteLine(s.Perimeter());

            //Bank dhanunjay = new SBI();

            //dhanunjay.Deposit(1000);

            //try
            //{
            //    dhanunjay.Withdraw(2000);
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Calculator c = new NumberCalci();

            //Addition ad = new NumberCalci();

            //double result = c.Add(43325.23, 834572.234);

            //ad.Add(43325.23, 834572.234);

            //Console.WriteLine(result);
        }
    }
}