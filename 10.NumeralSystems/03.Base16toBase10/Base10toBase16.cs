//3.Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Linq;
using System.Text;

class Base10toBase16
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int decNum = int.Parse(Console.ReadLine());
        StringBuilder hexNum = new StringBuilder();
        while (decNum > 0)
        {
            switch (decNum % 16)
            {
                case 10:
                    hexNum.Append('A');
                    break;
                case 11:
                    hexNum.Append('B');
                    break;
                case 12:
                    hexNum.Append('C');
                    break;
                case 13:
                    hexNum.Append('D');
                    break;
                case 14:
                    hexNum.Append('E');
                    break;
                case 15:
                    hexNum.Append('F');
                    break;
                default:
                    hexNum.Append(decNum % 16);
                    break;
            }
            decNum = decNum / 16;
        }
        string endNum = hexNum.ToString();
        Console.Write("Number in hexadecimal: ");
        for (int i = endNum.Length - 1; i > -1; i--)
        {
            Console.Write(endNum[i]);
        }
        Console.WriteLine();
    }
}
