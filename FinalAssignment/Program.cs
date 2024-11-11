using System;
using System.Collections.Generic;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || !System.IO.File.Exists(args[0]))
            {
                Console.WriteLine("Please provide a valid CSV file.");
                return;
            }

            var shapes = Solver.ParseShapes(args[0]);

            // Example: Calculate total area with a multiplier of 3
            double totalArea = Solver.CalculateArea(shapes, 3);
            Console.WriteLine($"Total Area: {totalArea:F2}");

            // Example: Calculate total volume with a multiplier of 1
            double totalVolume = Solver.CalculateVolume(shapes, 1);
            Console.WriteLine($"Total Volume: {totalVolume:F2}");
        }
    }
}
