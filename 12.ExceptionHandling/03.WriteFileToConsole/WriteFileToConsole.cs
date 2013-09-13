/*3.Write a program that enters file name along with its full file path
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
 * Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all 
 * possible exceptions and print user-friendly error messages.*/
using System;
using System.IO;
    
class WriteFileToConsole  
{ 
    static void Main()    
    {
        Console.Write("Enter file name:");
        try
        {
            Console.WriteLine(File.ReadAllText(Console.ReadLine()));
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception cought!\n{0}:{1}", e.GetType().Name, e.Message);
        }
    }
}
