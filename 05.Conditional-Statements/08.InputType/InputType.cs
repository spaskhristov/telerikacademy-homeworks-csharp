/*8.Write a program that, depending on the user's choice inputs int, 
 * double or string variable. If the variable is integer or double, 
 * increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement.*/
using System;

class InputType
{
    static void Main()
    {
        Console.Write("Enter : 0 for Int, 1 for Double, 2 for String :");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 0:
                Console.Write("Enter Int : ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", (i + 1));
                break;
            case 1:
                Console.Write("Enter Double : ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}", (d + 1));
                break;
            case 2:
                Console.Write("Enter String : ");
                string s = Console.ReadLine();
                Console.WriteLine("{0}", s + "*");
                break;
            default: 
                Console.WriteLine("Error!!!");
                break;
        }
    }
}