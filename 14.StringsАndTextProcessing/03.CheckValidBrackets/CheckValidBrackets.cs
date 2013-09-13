/*3.Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).*/
using System;

class CheckValidBrackets
{
    static void Main()
    {
        string str = Console.ReadLine();
        int countBrackets = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                countBrackets++;
            }
            if (str[i] == ')')
            {
                countBrackets--;
            }
            if (countBrackets < 0)
            {
                break;
            }
        }
        if(countBrackets == 0)
            Console.WriteLine("{0} is correct expression!!!", str);
        if (countBrackets != 0)
            Console.WriteLine("{0} is incorrect expression!!!", str);
    }
}
