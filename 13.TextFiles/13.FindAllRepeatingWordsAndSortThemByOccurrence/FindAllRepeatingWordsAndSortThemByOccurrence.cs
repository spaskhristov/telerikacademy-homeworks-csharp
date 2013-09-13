/*13.Write a program that reads a list of words from a file words.txt and finds how many
 * times each of the words is contained in another file test.txt. The result should be 
 * written in the file result.txt and the words should be sorted by the number of their 
 * occurrences in descending order. Handle all possible exceptions in your methods.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Security;
    
class FindAllRepeatingWordsAndSortThemByOccurrence
    {
    static void Main()
    {
        string fileSourcePath = "../../test.txt";
        string fileResultPath = "../../result.txt";
        string fileDictionaryPath = "../../words.txt";
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        try
        {
            using (StreamReader input = new StreamReader(fileDictionaryPath))
            {
                while (!input.EndOfStream)
                {
                    string word = input.ReadLine();
                    dictionary.Add(word, 0);
                }
            }
            using (StreamReader input = new StreamReader(fileSourcePath))
            {
                string line = input.ReadLine();
                while (line != null)
                {
                    List<string> wordList = new List<string>(dictionary.Keys);
                    foreach (string word in wordList)
                    {
                        string regex = String.Format("\\b{0}\\b", word);
                        MatchCollection matches = Regex.Matches(line, regex);
                        dictionary[word] += matches.Count;
                    }
                    line = input.ReadLine();
                }
            }
            using (StreamWriter output = new StreamWriter(fileResultPath))
            {
                foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                {
                    output.Write(wordCounter.Key);
                    output.Write("-");
                    output.WriteLine(wordCounter.Value);
                }
            }
            using (StreamReader output = new StreamReader(fileResultPath))
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
