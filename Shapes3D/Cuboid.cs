using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes3D
{
    public class Cuboid : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }

        public Cuboid(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public override double SurfaceArea => 2 * (Width * Height + Width * Depth + Height * Depth);
        public override double Volume => Width * Height * Depth;
    }
}
