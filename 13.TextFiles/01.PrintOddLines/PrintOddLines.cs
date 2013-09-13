//1.Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../test.txt"))
        {
            string line = input.ReadLine();
            int numOfLine = 0;
            while (line != null)
            {
                numOfLine++;
                if (numOfLine % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                line = input.ReadLine();
            }
        }
    }
}
