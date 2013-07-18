//2.Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius of circle: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * r * Math.PI;
        double area = r * r * Math.PI;
        Console.WriteLine("Perimeter = {0:0.00}", perimeter);
        Console.WriteLine("Area = {0:0.00}", area);
    }
}