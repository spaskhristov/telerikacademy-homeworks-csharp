//1.Write an expression that checks if given integer is odd or even.
using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter an integer number to check whether it is odd or even: ");
        int i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.WriteLine("The number " + i + " is odd");
        }
        else
        {
            Console.WriteLine("The number " + i + " is even");
        }
    }
}
