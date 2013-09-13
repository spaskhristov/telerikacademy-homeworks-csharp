/*11.Write a program that deletes from a text file all words that start with the 
 * prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.*/
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            string line = input.ReadLine();
            while (line != null)
            {
                output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                line = input.ReadLine();
            }
        }
        using (StreamReader output = new StreamReader("../../output.txt"))
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