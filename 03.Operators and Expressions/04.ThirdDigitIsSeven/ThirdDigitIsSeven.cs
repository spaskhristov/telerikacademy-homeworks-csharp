//4.Write an expression that checks for given integer if
//its third digit (right-to-left) is 7. E. g. 1732  true.
using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter an integer number to check if his third digit from right to left is 7: ");
        int i = int.Parse(Console.ReadLine());
        if ((i/100) % 10 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
