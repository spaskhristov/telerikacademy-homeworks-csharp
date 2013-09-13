//3.Write a program that reads a text file and inserts line numbers in front of each 
//of its lines. The result should be written to another text file.
using System;
using System.IO;
using System.Text;
    
class InsertLineNumbers  
{   
    static void Main()    
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader input = new StreamReader("../../test.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            string content = input.ReadLine();
            int numOfLine = 0;
            while (content != null)
            {
                numOfLine++;
                sb.Append(numOfLine + "." + content);
                sb.AppendLine();
                content = input.ReadLine();
            }
            output.Write(sb);
            output.Close();
        }
        using (StreamReader input = new StreamReader("../../output.txt"))
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
}
