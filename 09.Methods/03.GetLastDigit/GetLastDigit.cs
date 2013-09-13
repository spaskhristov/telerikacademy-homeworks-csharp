/*3.Write a method that returns the last digit of given integer as an English word. 
Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".*/
using System;

class GetLastDigit
{
    static string GetEngNameNum(int number)
    {
        string engName;
        switch (number)
        {
            case 0:
                engName = "Zero";
                break;
            case 1:
                engName = "One";
                break;
            case 2:
                engName = "Two";
                break;
            case 3:
                engName = "Three";
                break;
            case 4:
                engName = "Four";
                break;
            case 5:
                engName = "Five";
                break;
            case 6:
                engName = "Six";
                break;
            case 7:
                engName = "Seven";
                break;
            case 8:
                engName = "Eight";
                break;
            case 9:
                engName = "Nine";
                break;
            default:
                Console.WriteLine("Invalid number");
                return null;
        }
        return engName;
    }
    static void SayEngNameNum(int number)
    {
        int result = Math.Abs(number % 10);
        Console.WriteLine(GetEngNameNum(result));
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        SayEngNameNum(number);
    }
}