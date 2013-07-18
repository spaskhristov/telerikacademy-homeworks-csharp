//9.Write an expression that checks for given point (x, y) if it
//is within the circle K( (1,1), 3) and out of the rectangle 
//R(top=1, left=-1, width=6, height=2).

using System;

class WithinCircleOutRectangle
{
    static void Main()
    {
        Console.Write("Enter point X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point Y: ");
        double y = double.Parse(Console.ReadLine());
        int radius = 3;
        int centerX = 1;
        int centerY = 1;
        bool outRetangle = (x < -1 || y > 1 || x > 5 || y < -1) ? true : false;
        bool inCircle = ((x - centerX) * (x - centerX)) + 
            ((y - centerY) * (y - centerY)) <= (radius * radius) ? true : false;
        Console.WriteLine("Point with coordinates x: {0} and y: {1}", x, y);
        Console.WriteLine("is within the circle K((1,1),3) - {0} and out rectangle - {1}", inCircle, outRetangle);
    }
}
