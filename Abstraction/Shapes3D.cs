using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Shapes3D
    {
        public double length,height,width;

        public Shapes3D(double length, double height, double width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public abstract double Volume();

        public abstract double SurfaceArea();
    }

    internal class Cube : Shapes3D
    {
        public Cube(double length,double height,double width): base(length, height, width)
        {
            
        }
        public override double SurfaceArea()
        {
            return 6 * length * length;
        }

        public override double Volume()
        {
            return length * height * width;
        }
    }

    internal class Cuboid : Shapes3D
    {
        public Cuboid(double length,double height,double width):base(length, height, width)
        {

        }

        public override double SurfaceArea()
        {
            return 2 * ((length * height) + (height * width) + (width * length));
        }

        public override double Volume()
        {
            return length * height * width;
        }
    }
}
