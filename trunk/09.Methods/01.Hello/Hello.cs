/*1.Write a method that asks the user for his name and prints “Hello, <name>” 
 *(for example, “Hello, Peter!”). Write a program to test this method.*/
using System;
using System.Text.RegularExpressions;

class Hello
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        if (IsValidName(name))
        {
            PrintName(name);
        }
        else
        {
            Console.WriteLine("Error!!!");
        }
    }
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static bool IsValidName(string name)
    {
        string pattern = @"^[a-zA-Z]";
        return Regex.IsMatch(name, pattern);
    }
}