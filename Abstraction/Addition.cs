using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface Addition
    {
        
        double Sum(double x,double y);

        void Add(double x,double y);

    }

    public class Circle
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public virtual double Area()
        {
            return Math.PI * radius*radius;
        }

        public virtual double SurfaceArea()
        {
            return 2*Math.PI * radius;
        }
    }

    public class Cylinder:Circle
    {
        public double height;

        public Cylinder(double height,double radius):base(radius)
        {
            
            this.height = height;
        }

        public override double SurfaceArea()
        {
            return base.SurfaceArea() * height;
        }

        public double TotalSurfaceArea()
        {
            return base.SurfaceArea()*(radius+height);
        }

        public override double Area()
        {
            return base.Area() * height;
        }
    }
}
