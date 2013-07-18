//6.Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
using System;

class PointWithinCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        if ((Math.Sqrt((x * x) + (y * y))) <= 5)
        {
            Console.WriteLine("The point ({0}, {1}) is within a circle K(O, 5)", x, y);
        }
        else
        {
            Console.WriteLine("The point ({0}, {1}) is not within the circle", x, y);
        }
    }
}
