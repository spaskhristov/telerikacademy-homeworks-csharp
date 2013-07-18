//2.Write a program that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time.
using System;

class Num1toNnotDiv3and7
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (!(i % 21 == 0))
            {
                Console.Write("{0}; ", i);
            }
        }
        Console.WriteLine();
    }
}
