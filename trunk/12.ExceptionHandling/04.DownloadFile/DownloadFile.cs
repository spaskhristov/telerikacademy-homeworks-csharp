/*4.Write a program that downloads a file from Internet 
 * (e.g. www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
 * Find in Google how to download files in C#. Be sure to catch all exceptions
 * and to free any used resources in the finally block.*/
using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/logo.jpg";
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", desktop);
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The address is invalid.");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address can not be null");
            }
            catch (ProtocolViolationException exc)
            {
                Console.WriteLine("Protocol Error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                Console.WriteLine("URI Format Error: " + exc.Message);
            }
            catch (IOException exc)
            {
                Console.WriteLine("I/O Error: " + exc.Message);
            } 
        }
    }
}
