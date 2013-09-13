/*7.Write a program that replaces all occurrences of the substring "start" with 
 * the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).*/
using System;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            string line = input.ReadLine();
            while (line != null)
            {
                output.WriteLine(line.Replace("start", "finish"));
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
