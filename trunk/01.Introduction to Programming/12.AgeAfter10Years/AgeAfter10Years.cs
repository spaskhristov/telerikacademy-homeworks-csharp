/*12. Write a program to read your age from the console 
and print how old you will be after 10 years.*/
using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int Age = int.Parse(Console.ReadLine());
        int AgeAfterTenYears = Age + DateTime.Now.AddYears(10).Year - DateTime.Now.Year;
        Console.WriteLine("Your age after ten years is: {0}", AgeAfterTenYears);
    }
}