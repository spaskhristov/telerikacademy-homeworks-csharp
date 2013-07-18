/*2. Which of the following values can be assigned to a variable of 
 * type float and which to a variable of type double: 34.567839023,
 * 12.345, 8923.1234857, 3456.091*/
using System;

class VarFloatAndDouble
{
    static void Main()
    { 
        float f1 = 12.345F;
        float f2 = 3456.091f;
        double d1 = 34.567839023D;
        double d2 = 8923.1234857d;
        Console.WriteLine(d1 + "; " + f1 + "; " + d2 + "; " + f2);
    }
}

