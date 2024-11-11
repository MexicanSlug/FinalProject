using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes3D
{
    public class Prism : Shape
    {
        public double SideLength { get; }
        public int Faces { get; }
        public double Height { get; }

        public Prism(double sideLength, int faces, double height)
        {
            SideLength = sideLength;
            Faces = faces;
            Height = height;
        }

        public override double SurfaceArea => Faces * SideLength * Height + 2 * Math.Pow(SideLength, 2) * Math.Tan(Math.PI / Faces);
        public override double Volume => (Faces * Math.Pow(SideLength, 2) * Height) / (4 * Math.Tan(Math.PI / Faces));
    }
}
