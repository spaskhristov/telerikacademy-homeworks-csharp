//Find online more information about ASCII (American Standard 
//Code for Information Interchange) and write a program that prints
//the entire ASCII table of characters on the console.

using System;

class PrintASCIICharacters
{
    static void Main()
    {
        for (int i = 1; i <= 255; i++)
        {
            char character = (char)i;
            Console.Write(character + "\t");
        }
    }
}