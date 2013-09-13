/*4.Write a program that finds how many times a substring is contained in a 
 * given text (perform case insensitive search).
 * Example: The target substring is "in". The text is as follows:
 *  We are living in an yellow submarine. We don't have 
 *  anything else. Inside the submarine is very tight. So 
 *  we are drinking all the day. We will move out of it in 5 days.
 *  The result is: 9.*/
using System;

class CountOccurrencesOfRepeatingSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        text = text.ToLower();
        string searchStr = "in";
        int counterSearchStr = 0;
        int startIndex = 0;
        while (true)
        {
            if (text.IndexOf(searchStr, startIndex) != -1)
            {
                counterSearchStr++;
                startIndex = text.IndexOf(searchStr, startIndex) + 1;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("\"{0}\" repeated {1} times", searchStr, counterSearchStr);
    }
}
