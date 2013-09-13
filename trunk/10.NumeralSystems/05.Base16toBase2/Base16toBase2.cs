//5.Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Text;

class Base16toBase2
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        string binary = "";
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            switch (hexadecimal[i])
            {
                case '0': sb.Append("0000"); break;
                case '1': sb.Append("0001"); break;
                case '2': sb.Append("0010"); break;
                case '3': sb.Append("0011"); break;
                case '4': sb.Append("0100"); break;
                case '5': sb.Append("0101"); break;
                case '6': sb.Append("0110"); break;
                case '7': sb.Append("0111"); break;
                case '8': sb.Append("1000"); break;
                case '9': sb.Append("1001"); break;
                case 'A': sb.Append("1010"); break;
                case 'B': sb.Append("1011"); break;
                case 'C': sb.Append("1100"); break;
                case 'D': sb.Append("1101"); break;
                case 'E': sb.Append("1110"); break;
                case 'F': sb.Append("1111"); break;
                default: sb.Append(""); break;
            }
        }
        binary = sb.ToString();
        Console.Write("Number in binary: ");
        Console.WriteLine(binary);
    }
}
