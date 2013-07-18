/*2.Write a boolean expression that checks for given integer if
 * it can be divided (without remainder) by 7 and 5 in the same time.*/
using System;

class DividedSevenAndFiveOrNo
{
    static void Main()
    {
        Console.Write("Enter an integer number to check whether it is \n divided by 7 and 5 in the same time: ");
        int i = int.Parse(Console.ReadLine());
        if (i % (5 * 7) == 0)
        {
            Console.WriteLine("The number " + i + " divided by 7 and 5");
        }
        else
        {
            Console.WriteLine("The number " + i + " not divided by 7 and 5");
        }
    }
}
