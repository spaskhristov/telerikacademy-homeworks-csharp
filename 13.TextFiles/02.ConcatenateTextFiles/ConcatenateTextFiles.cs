//2.Write a program that concatenates two text files into another text file.
using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstFilePath = "../../test1.txt";
        string secondFilePath = "../../test2.txt";
        string str = ConcatenateText(firstFilePath, secondFilePath);
        string concatenatedFilePath = "../../test3.txt";
        StreamWriter concatenatedFile = new StreamWriter(concatenatedFilePath);
        concatenatedFile.Write(str);
        concatenatedFile.Close();
        using (StreamReader input = new StreamReader(concatenatedFilePath))
        {
            string content = input.ReadLine();
            int numOfLine = 0;
            while (content != null)
            {
                numOfLine++;
                Console.WriteLine(content);
                content = input.ReadLine();
            }
        }
    }
    static string ConcatenateText(string firstFilePath, string secondFilePath)
    {    
        StringBuilder sb = new StringBuilder();
        using (StreamReader input = new StreamReader(firstFilePath))
        {
            string content = input.ReadLine();
            int numOfLine = 0;
            while (content != null)
            {
                numOfLine++;
                sb.Append(content);
                sb.AppendLine();
                content = input.ReadLine();
            }
        }
        using (StreamReader input = new StreamReader(secondFilePath))
        {
            string content = input.ReadLine();
            int numOfLine = 0;
            while (content != null)
            {
                numOfLine++;
                sb.Append(content);
                sb.AppendLine();
                content = input.ReadLine();
            }
        }
        string str = sb.ToString();
        return str;
    }
}