//6.Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Text;

class Base2toBase16
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        string hexadecimal = "";
        StringBuilder sb = new StringBuilder();
        StringBuilder sb1 = new StringBuilder();
        if (binary.Length < 4)
        {
            switch (binary)
            {
                case "0": sb.Append("0"); break;
                case "1": sb.Append("1"); break;
                case "10": sb.Append("2"); break;
                case "11": sb.Append("3"); break;
                case "100": sb.Append("4"); break;
                case "101": sb.Append("5"); break;
                case "110": sb.Append("6"); break;
                case "111": sb.Append("7"); break;
            }
        }
        else
        {
            for (int i = binary.Length-1; i >= 0; i -= 4)
            {
                for (int j = i; j >= i-3; j--)
                {
                    sb1.Append(binary[j]);
                    if (j == 0)
                        break;
                }
                string res = sb1.ToString();
                sb1.Clear();
                switch (res)
                {
                    case "0": sb.Append("0"); break;
                    case "1": sb.Append("1"); break;
                    case "01": sb.Append("2"); break;
                    case "11": sb.Append("3"); break;
                    case "001": sb.Append("4"); break;
                    case "101": sb.Append("5"); break;
                    case "011": sb.Append("6"); break;
                    case "111": sb.Append("7"); break;
                    case "0000": sb.Append("0"); break;
                    case "1000": sb.Append("1"); break;
                    case "0100": sb.Append("2"); break;
                    case "1100": sb.Append("3"); break;
                    case "0010": sb.Append("4"); break;
                    case "1010": sb.Append("5"); break;
                    case "0110": sb.Append("6"); break;
                    case "1110": sb.Append("7"); break;
                    case "0001": sb.Append("8"); break;
                    case "1001": sb.Append("9"); break;
                    case "0101": sb.Append("A"); break;
                    case "1101": sb.Append("B"); break;
                    case "0011": sb.Append("C"); break;
                    case "1011": sb.Append("D"); break;
                    case "0111": sb.Append("E"); break;
                    case "1111": sb.Append("F"); break;
                    default: sb.Append(""); break;
                }
            }
        }
        hexadecimal = sb.ToString();
        Console.Write("Number in hexadecimal: ");
        for (int i = hexadecimal.Length - 1; i >= 0; i--)
        {
            Console.Write(hexadecimal[i]);
        }
        Console.WriteLine();
    }
}