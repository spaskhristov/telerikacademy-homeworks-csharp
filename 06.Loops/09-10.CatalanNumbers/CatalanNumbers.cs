// 09.In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// (2*n)! / (n + 1)! * n!
// Write a program to calculate the Nth Catalan number by given N.
//10.Write a program to calculate the Nth Catalan number by given N.
using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        decimal CatalanN = 0;
        decimal factorialN = 1;
        decimal factorialM = 1;
        for (int i = (n + 2); i <= (n * 2); i++)
        {
            if (i <= 1)
            {
                break;
            }
            factorialM *= i;
        }
        while (true)
        {
            if (n <= 1)
            {
                break;
            }
            factorialN *= n;
            n--;
        }
        CatalanN = factorialM / factorialN;
        Console.WriteLine("Catalan Number = " + CatalanN);
    }
}