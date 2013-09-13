/*12.Write a program that removes from a text file all words listed in given another
 * text file. Handle all possible exceptions in your methods.*/
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class DeleteGivenWordsFromTextFile
{
    static void Main()
    {
        try
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                string line = input.ReadLine();
                while (line != null)
                {
                    //output.WriteLine(Regex.Replace(line, @"\b(start|small|song)\b", ""));
                    output.WriteLine(Regex.Replace(line, @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b", ""));
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
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
