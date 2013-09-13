/*7.Write a program that encodes and decodes a string using given encryption
 * key (cipher). The key consists of a sequence of characters. The  
 * is done by performing XOR (exclusive or) operation over the first letter of the
 * string with the first of the key, the second – with the second, etc. When the last 
 * key character is reached, the next is the first.*/
using System;
using System.Text;

class XOREncryption
{
    static void Main()
    {
        string decodingStr = "Gogata Koraviq";
        string key = "kod";
        string encodingStr = "";
        StringBuilder sb = new StringBuilder();
        int j = 0;
        for (int i = 0; i < decodingStr.Length; i++, j++)
        {
            if (j == key.Length)
                j = 0;
            char chStr = decodingStr[i];
            char chKey = key[j];
            sb.Append((char)(chStr ^ chKey));
        }
        encodingStr = sb.ToString();
        Console.WriteLine(encodingStr);
    }
}
