using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes3D
{
    public class Sphere : Shape
    {
        public double Radius { get; }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double SurfaceArea => 4 * Math.PI * Math.Pow(Radius, 2);
        public override double Volume => (4 / 3) * Math.PI * Math.Pow(Radius, 3);
    }
}
