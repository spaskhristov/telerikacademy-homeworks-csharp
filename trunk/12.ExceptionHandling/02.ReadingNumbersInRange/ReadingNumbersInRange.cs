/*2.Write a method ReadNumber(int start, int end) that enters an integer number in given range 
 * [start…end]. If an invalid number or non-number text is entered, the method should throw an 
 * exception. Using this method write a program that enters 10 numbers:
 *			a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/
using System;

class ReadingNumbersInRange
{
    static uint ReadNumber(uint start, uint end)
    {
        uint number = 0;
        try
        {
           number = uint.Parse(Console.ReadLine());
           if (number < start || number > end)
           {
               throw new ArgumentOutOfRangeException();
           }
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
        catch (OverflowException oe)
        {
            Console.Error.WriteLine(oe.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        return number;
    }
    static void Main()
    {
        uint min = 1, max = 100;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter number from {0} to {1}: ", min, max);
            uint number = min;
            number = ReadNumber(number, max);
            if ( min < number)
                min = number;
            if (min > number)
                break;
            if (max < number)
                break;
        }
    }
}