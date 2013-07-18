//* 11.Write a program that converts a number in the range [0...999] to
//a text corresponding to its English pronunciation. 
using System;

class NumberToString
{
    static void Main()
    {
        Console.Write("Enter a digit in the range [0..999]:  ");
        int num = int.Parse(Console.ReadLine());
        int hundred = num / 100;
        int ten = num / 10 % 10;
        int one = num % 10;
        if ((num < 0) || (num > 999))
        {
            Console.WriteLine("Error!!!");
        }
        else
        {
            if (hundred >= 1)
            {
                switch (hundred)
                {
                    case 1: Console.Write("One hundred "); break;
                    case 2: Console.Write("Two hundred "); break;
                    case 3: Console.Write("Three hundred "); break;
                    case 4: Console.Write("Four hundred "); break;
                    case 5: Console.Write("Five hundred "); break;
                    case 6: Console.Write("Six hundred "); break;
                    case 7: Console.Write("Seven hundred "); break;
                    case 8: Console.Write("Eight hundred "); break;
                    case 9: Console.Write("Nine hundred "); break;
                }
                if (one != 0)
                {
                    Console.Write("and ");
                }
            }
            if (ten > 1)
            {
                switch (ten)
                {
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifity "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                }
            }
            if ((ten != 1) && (one != 0))
            {
                switch (one)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            if (ten == 1)
            {
                switch (one)
                {
                    case 0: Console.WriteLine("ten"); break;
                    case 1: Console.WriteLine("eleven"); break;
                    case 2: Console.WriteLine("twelve"); break;
                    case 3: Console.WriteLine("thirteen"); break;
                    case 4: Console.WriteLine("fourteen"); break;
                    case 5: Console.WriteLine("fifteen"); break;
                    case 6: Console.WriteLine("sixteen"); break;
                    case 7: Console.WriteLine("seventeen"); break;
                    case 8: Console.WriteLine("eighteen"); break;
                    case 9: Console.WriteLine("nineteen"); break;
                }
            }
            if ((hundred == 0) && (ten == 0) && (one == 0))
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
