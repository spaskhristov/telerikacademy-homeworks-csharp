/*6.Write a program that reads a text file containing a list of strings,
 * sorts them and saves them to another text file. Example:
	Ivan			George
	Peter	-->		Ivan
	Maria			Maria
	George			Peter
*/
using System;
using System.IO;
using System.Collections.Generic;
    
class SortLines
{
    static void Main()
    {
        List<string> list = new List<string>();
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            string line = input.ReadLine();
            while (line != null)
            {
                list.Add(line);
                line = input.ReadLine();
            }
        }
        list.Sort();
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            foreach (string line in list)
                output.WriteLine(line);
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
