// 6.Write a program that reads the coefficients a, b and c of a quadratic 
// equation ax2+bx+c=0 and solves it (prints its real roots).
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("a.x2 + b.x + c = 0");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(a + ".x2 + " + b + ".x + " + c + " = 0");
        double d = (b * b) - (4 * a* c);
        if (d < 0)
        {
            Console.WriteLine("Equation do not have real roots");
        }
        if (d == 0)
        {
            double x = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Equation have 1 real root X = " + x);
        }
        if (d > 0)
        {
            double x1 = ((-b + Math.Sqrt(d)) / 2 * a);
            double x2 = ((-b - Math.Sqrt(d)) / 2 * a);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}