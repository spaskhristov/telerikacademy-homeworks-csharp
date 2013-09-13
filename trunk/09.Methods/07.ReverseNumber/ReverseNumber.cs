//7.Write a method that reverses the digits of given decimal number. Example: 256 -> 652
using System;

class ReverseNumber
{
    static void Reverse(int num)
    {
        if (num < 10)
        {
            Console.Write(num);
        }
        else
        {
            for (int i = 1; ; i = i * 10)
            {
                int n = num / i % 10;
                if (num / i < 1)
                    break;
                Console.Write(n);
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Reverse(num);
    }
}