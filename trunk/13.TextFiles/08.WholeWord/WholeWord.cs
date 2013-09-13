//8.Modify the solution of the previous problem to replace only whole words (not substrings).
using System;
using System.IO;
using System.Text.RegularExpressions;

class WholeWord
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            string line = input.ReadLine();
            while (line != null)
            {
                output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
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
