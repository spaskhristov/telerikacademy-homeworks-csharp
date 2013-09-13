/*11-12.Write a method that adds two polynomials. Represent them as
 * arrays of their coefficients as in the example below:
 * x2 + 5 = 1x2 + 0x + 5 -> 5 0 1*/
using System;

class Polynomials
{
    static void Main()
    {
        decimal[] firstPolinomial = { 4, -1, 5, 5, 8 };
        Console.Write("First polinomial: ");
        PrintPolinomial(firstPolinomial);
        decimal[] secondPolinomial = { 11, -5, -9, 6, 4, 6 };
        Console.Write("Second polinomial: ");
        PrintPolinomial(secondPolinomial);
        Console.Write("Sum polinomials: ");
        PrintPolinomial(SumPolinomials(firstPolinomial,secondPolinomial));
        Console.Write("Substract polinomials: ");
        PrintPolinomial(SubstractPolinomials(firstPolinomial, secondPolinomial));
        Console.Write("Multiply polinomials: ");
        PrintPolinomial(MultiplyPolynomials(firstPolinomial, secondPolinomial));
    }
    static decimal[] SumPolinomials(decimal[] A, decimal[] B)
    {
        int n = Math.Max(A.Length,B.Length);
        decimal[] result = new decimal[n];
        for (int i = 0; i < n; i++)
        {
            if (i < A.Length && i < B.Length)
                result[i] = A[i] + B[i];
            if (i >= A.Length && i < B.Length)
                result[i] = B[i];
            if (i < A.Length && i >= B.Length)
                result[i] = A[i];
        }
        return result;
    }
    static decimal[] SubstractPolinomials(decimal[] A, decimal[] B)
    {
        int n = Math.Max(A.Length, B.Length);
        decimal[] result = new decimal[n];
        for (int i = 0; i < n; i++)
        {
            if (i < A.Length && i < B.Length)
                result[i] = A[i] - B[i];
            if (i >= A.Length && i < B.Length)
                result[i] = (B[i]) * (-1);
            if (i < A.Length && i >= B.Length)
                result[i] = A[i];
        }
        return result;
    }
    static decimal[] MultiplyPolynomials(decimal[] A, decimal[] B)
    {
        int n = A.Length + B.Length - 1;
        decimal[] result = new decimal[n];
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < B.Length; j++)
            {
                result[i + j] += A[i] * B[j];
            }
        }
        return result;
    }
    static void PrintPolinomial(decimal[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0}+", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0}", i, polinomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }
        Console.WriteLine();
    }
}
