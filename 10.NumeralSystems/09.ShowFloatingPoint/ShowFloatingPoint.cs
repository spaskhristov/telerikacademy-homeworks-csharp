/*9.* Write a program that shows the internal binary representation of given 32-bit signed
 * floating-point number in IEEE 754 format (the C# type float). 
 * Example: -27,25-> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.*/
//explanations: www.youtube.com/watch?v=iQFG7sAa7i4
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string numbersString = Console.ReadLine();
        byte sign = 0;
        if (numbersString[0] == '-')
        {
            sign = 1;
        }
        numbersString = numbersString.Replace("-", " ");
        int[] numbers = ParseNumbersString(numbersString);
        int order = (BinaryInteger(numbers[0]).Count) - 1;
        float mantissa = (float)((numbers[1]) /(Math.Pow(10,(numbers[1].ToString().Length))));
        Console.WriteLine("sign = "+sign);
        int exponent = order + 127;
        Console.Write("exponent = ");
        for (int i = 0; i < BinaryInteger(exponent).Count; i++)
        {
            Console.Write("{0}", BinaryInteger(exponent)[i]);
        }
        Console.WriteLine();
        Console.Write("mantissa = ");
        for (int i = 1; i < BinaryInteger(numbers[0]).Count; i++)
        {
            Console.Write("{0}", BinaryInteger(numbers[0])[i]);
        }
        for (int i = 0; i < BinaryFraction(mantissa).Count; i++)
        {
            Console.Write("{0}", BinaryFraction(mantissa)[i]);
        }
        for (int i = (BinaryInteger(numbers[0]).Count + BinaryFraction(mantissa).Count); i < 24; i++)
        {
            Console.Write("{0}", "0");
        }
        Console.WriteLine();
    }
    static int[] ParseNumbersString(string numbersString)
    {
        string[] numberStrings = numbersString.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = numberStrings.Select(ns => int.Parse(ns)).ToArray();
        return numbers;
    }
    static List<int> BinaryInteger(int number)
    {
        List<int> inBinary = new List<int>();
        while (number > 0)
        {
            inBinary.Add(number % 2);
            number = number / 2;
        }
        inBinary.Reverse();
        return inBinary;
    }
    static List<int> BinaryFraction(float number)
    {
        List<int> inBinary = new List<int>();
        while (number > 0)
        {
            number = number * 2;
            if (number < 1)
            {
                inBinary.Add(0);
            }
            if (number >= 1)
            { 
                inBinary.Add(1);
                number--;
            }
        }
        return inBinary;
    }
}