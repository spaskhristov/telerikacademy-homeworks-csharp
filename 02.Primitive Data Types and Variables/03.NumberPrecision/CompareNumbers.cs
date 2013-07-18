/*Write a program that safely compares floating-point numbers 
 * with precision of 0.000001. Examples:(5.3 ; 6.01) - false; 
 * (5.00000001 ; 5.00000003) -true)*/

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the two numbers");
        Console.Write("Enter the first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal result = Math.Abs(firstNumber - secondNumber);
        decimal precision = 0.000001m;
        Console.WriteLine("With acccuracy of {3}: {1} = {2} are {0}",
            result < precision ? true:false , firstNumber, secondNumber, precision);
    }
}