/* 6.You are given a sequence of positive integer values written into a string,
 * separated by spaces. Write a function that reads these values from given 
 * string and calculates their sum.
 * Example: string = "43 68 9 23 318" -> result = 461*/
using System;
using System.Linq;

class ParseStringOfNumbers  
{
    static void Main()   
    {
        Console.Write("Enter string: ");
        string numbersString = Console.ReadLine();
        int[] numbers = ParseNumbersString(numbersString);
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("Sum = "+sum);
    }
    static int[] ParseNumbersString(string numbersString)
    {
        string[] numberStrings = numbersString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = numberStrings.Select(ns => int.Parse(ns)).ToArray();
        return numbers;
    }
}
