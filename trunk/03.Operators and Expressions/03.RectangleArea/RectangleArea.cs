//3.Write an expression that calculates rectangle’s area by given width and height.
using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter the strange A of the rectangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the strange B of the rectangle: ");
        double b = double.Parse(Console.ReadLine());
        double s = a * b;
        Console.WriteLine("Area of the rectangle is: " + s);
    }
}
