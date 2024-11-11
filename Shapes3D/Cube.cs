using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes3D
{
    public class Cube : Cuboid
    {
        public Cube(double sideLength) : base(sideLength, sideLength, sideLength) { }
    }
}
