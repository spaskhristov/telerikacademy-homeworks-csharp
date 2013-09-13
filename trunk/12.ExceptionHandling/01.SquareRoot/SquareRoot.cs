/*1.Write a program that reads an integer number and calculates and prints its square root.
 * If the number is invalid or negative, print "Invalid number". In all cases
 * finally print "Good bye". Use try-catch-finally.*/
using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        try
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Its square root is " + Math.Sqrt(n));
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number ");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number ");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
