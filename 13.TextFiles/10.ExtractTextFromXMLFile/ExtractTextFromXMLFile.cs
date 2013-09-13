/*10.Write a program that extracts from given XML file all the text without the tags. Example:
 * <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> 
 * Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>*/
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "../../input.txt";
        using (StreamReader input = new StreamReader(filePath))
        {
            string line = input.ReadLine();
            while (line != null)
            {
                string pattern = ">[^<]*</";
                string edited;
                int length;
                foreach (Match match in Regex.Matches(line, pattern))
                {
                    edited = match.Value.ToString();
                    length = edited.Length;
                    edited = edited.Remove(length - 2, 2); //remove </
                    edited = edited.Remove(0, 1); //remove >
                    if (edited != null)
                    {
                        Console.WriteLine(edited);
                    }
                }
                line = input.ReadLine();
            }
        }
    }
}