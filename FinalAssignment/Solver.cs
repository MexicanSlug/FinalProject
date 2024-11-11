using Shapes3D;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace FinalAssignment
{
    public static class Solver
    {
        public static double CalculateArea(List<Shape> shapes, int multiplier)
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.SurfaceArea;
            }

            return totalArea * multiplier;
        }

        public static double CalculateVolume(List<Shape> shapes, int multiplier)
        {
            double totalVolume = 0;

            foreach (var shape in shapes)
            {
                totalVolume += shape.Volume;
            }

            return totalVolume * multiplier;
        }

        public static List<Shape> ParseShapes(string filePath)
        {
            List<Shape> shapes = new List<Shape>();

            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(',');

                if (parts[0] == "cube")
                {
                    shapes.Add(new Cube(double.Parse(parts[1], CultureInfo.InvariantCulture)));
                }
                else if (parts[0] == "cuboid")
                {
                    shapes.Add(new Cuboid(
                        double.Parse(parts[1], CultureInfo.InvariantCulture),
                        double.Parse(parts[2], CultureInfo.InvariantCulture),
                        double.Parse(parts[3], CultureInfo.InvariantCulture)
                    ));
                }
                else if (parts[0] == "sphere")
                {
                    shapes.Add(new Sphere(double.Parse(parts[1], CultureInfo.InvariantCulture)));
                }
                else if (parts[0] == "prism")
                {
                    shapes.Add(new Prism(
                        double.Parse(parts[1], CultureInfo.InvariantCulture),
                        int.Parse(parts[2]),
                        double.Parse(parts[3], CultureInfo.InvariantCulture)
                    ));
                }
                // Handle area/volume requests here as well
            }

            return shapes;
        }
    }
}
