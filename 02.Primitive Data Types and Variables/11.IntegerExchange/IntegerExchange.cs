// 11. Declare  two integer variables and assign them with 5 and 10
//and after that exchange their values.
using System;

class IntegerExchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Original Value: a = {0} and b = {1};", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("New Value: a = {0} and b = {1};", a, b);
    }
}