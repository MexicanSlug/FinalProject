using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes3D
{
    public class Cylinder : Shape
    {
        public double Radius { get; }
        public double Height { get; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double SurfaceArea => 2 * Math.PI * Radius * (Radius + Height);
        public override double Volume => Math.PI * Math.Pow(Radius, 2) * Height;
    }
}
