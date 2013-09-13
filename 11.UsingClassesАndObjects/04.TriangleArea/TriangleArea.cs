/*4.Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/
using System;
  
class TriangleArea
{
    static void Main()
    {
        Console.WriteLine("Select methods to calculate the surface of a triangle");
        Console.WriteLine("1 - Side and an altitude to it; 2 - Three sides; 3 - Two sides and an angle between them");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1: Console.Write("Enter side A: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude to it h: ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(GetAreaWithAltitude(a, h));
                break;
            case 2: Console.Write("Enter side A: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Enter side C: ");
                double z = double.Parse(Console.ReadLine());
                Console.WriteLine(GetAreaWithHeron(x, y, z));
                break;
            case 3: Console.Write("Enter side A: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Enter angle between them: ");
                double alpha = double.Parse(Console.ReadLine());
                Console.WriteLine(GetAreaWithAngle(b, c, alpha));
                break;
            default: Console.Write("Error!!!");
                break;
        }
    }
    static double GetAreaWithAltitude(double a, double h)
    {
        return (a * h) / 2;
    }
    static double GetAreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static double GetAreaWithAngle(double a, double b, double alpha)
    {
        return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
    }
}
