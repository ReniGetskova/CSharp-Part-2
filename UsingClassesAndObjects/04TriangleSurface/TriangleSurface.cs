//Write methods that calculate the surface of a triangle by given:
//   Side and an altitude to it;
//   Three sides;
//   Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurface
{
    static double SurfaceBySideAndAltitude(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        return surface;
    }

    static double SurfaceByThreeSides(double a, double b, double c)
    {
        double halfPerimeter = (a + b + c) / 2;
        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        return surface;
    }

    static double SurfaceByTwoSidesAndAngle(double a, double b, double angle)
    {
        double surface = (a * b * Math.Abs(Math.Sin(angle))) / 2;
        return surface;
    }

    static void Main()
    {
        Console.WriteLine("Triangle surface by given side and altitude to it");
        Console.Write("Insert side = ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Insert altitude = ");
        double altitude = double.Parse(Console.ReadLine());
        double surfaceByGivenSideAndAltitude = SurfaceBySideAndAltitude(side, altitude);
        Console.WriteLine("Triangle surface by given side and altitude to it is: {0:F2}", surfaceByGivenSideAndAltitude);

        Console.WriteLine();

        Console.WriteLine("Triangle surface by given three sides");
        Console.WriteLine("Insert sides");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double surfaceByGivenThreeSides = SurfaceByThreeSides(a, b, c);
        Console.WriteLine("Triangle surface by given three sides is: {0:F2}", surfaceByGivenThreeSides);

        Console.WriteLine();

        Console.WriteLine("Triangle surface by given two sides and angle between them");
        Console.Write("Inserd first side: a = ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Inserd second side: b = ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Inserd angle: alpha = ");
        double alpha = double.Parse(Console.ReadLine());
        double surfaceByGivenTwoSidesAndAngle = SurfaceByTwoSidesAndAngle(firstSide, secondSide, alpha);
        Console.WriteLine("Triangle surface by given two sides and angle between them is: {0:F2}", surfaceByGivenTwoSidesAndAngle);
    }
}
