//7.Write an expression that checks if given positive integer
//number n (n ≤ 100) is prime. E.g. 37 is prime.
using System;
class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 1 && number <= 100)
        {
            if (number == 2 || number == 3 || number == 5 || number == 7)
                Console.WriteLine("The number " + number + " is prime");
            else
            {
                if ((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 7 == 0))
                    Console.WriteLine("The number " + number + " is not prime");
                else
                    Console.WriteLine("The number " + number + " is prime");
            }
        }
        else
        {
            Console.WriteLine("Number is out of range");
        }
    }
}
