// 13. Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal
//to them and see the result.
using System;

class NullVar
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("int = {0}; double = {1}", i, d);
        i += null;
        d += 7.89;
        Console.WriteLine("int = {0}; double = {1}", i, d);
    }
}