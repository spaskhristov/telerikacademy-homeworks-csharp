//9.Write a program that deletes from given text file all odd lines. The result should be in the same file.
using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        List<string> list = new List<string>();
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            string line = input.ReadLine();
            int numOfLine = 0;
            while (line != null)
            {
                numOfLine++;
                if (numOfLine % 2 == 0)
                {
                    list.Add(line);
                }
                line = input.ReadLine();
            }
        }
        using (StreamWriter output = new StreamWriter("../../input.txt"))
            foreach (string line in list)
                output.WriteLine(line);
        using (StreamReader output = new StreamReader("../../input.txt"))
        {
            string line = output.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = output.ReadLine();
            }
        }
    }
}
