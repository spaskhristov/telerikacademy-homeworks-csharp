//1.Write an if statement that examines two integer variables and exchanges
//their values if the first one is greater than the second one.
using System;

class ExchangeValue
{
    static void Main()
    {
        Console.Write("Enter value for A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for B: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("First number: " + a);
            Console.WriteLine("Second number: " + b);
        }
        else
        {
            Console.WriteLine("First number: " + a);
            Console.WriteLine("Second number: " + b);
        }
    }
}
