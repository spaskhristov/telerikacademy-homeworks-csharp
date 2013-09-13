/*4.Write a program that compares two text files line by line and prints 
 * the number of lines that are the same and the number of lines that 
 * are different. Assume the files have equal number of lines.*/
using System;
using System.IO;
using System.Text;

class CompareTwoFilesLineByLine
{
    static void Main()
    {
        string firstFilePath = "../../test1.txt";
        string secondFilePath = "../../test2.txt";
        int linesSame = CompareText(firstFilePath, secondFilePath)[0];
        int linesDiff = CompareText(firstFilePath, secondFilePath)[1];
        Console.WriteLine("Number of lines that are the same is {0}", linesSame);
        Console.WriteLine("Number of lines that are the different is {0}", linesDiff);
    }
    static int[] CompareText(string firstFilePath, string secondFilePath)
    {
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        int[] result = new int[2];
        int linesSame = 0;
        int linesDiff = 0;
        using (StreamReader input1 = new StreamReader(firstFilePath))
        using (StreamReader input2 = new StreamReader(secondFilePath))
        {
            string content1 = input1.ReadLine();
            string content2 = input2.ReadLine();
            string line1 = "";
            string line2 = "";
            while (content1 != null)
            {
                sb1.Append(content1);
                line1 = sb1.ToString();
                sb2.Append(content2);
                line2 = sb2.ToString();
                if (line1 == line2)
                    linesSame++;
                if (line1 != line2)
                    linesDiff++;
                content1 = input1.ReadLine();
                content2 = input2.ReadLine();
                sb1.Clear();
                line1 = "";
                sb2.Clear();
                line2 = "";
            }
        }
        result[0] = linesSame;
        result[1] = linesDiff;
        return result;
    }
}