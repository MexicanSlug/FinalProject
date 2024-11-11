using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes3D
{
    public abstract class Shape
    {
        public abstract double SurfaceArea { get; }
        public abstract double Volume { get; }
    }
}
