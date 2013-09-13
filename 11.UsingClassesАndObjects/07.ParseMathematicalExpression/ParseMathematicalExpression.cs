/*7.* Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
Real numbers, e.g. 5, 18.33, 3.14159, 12.6
Arithmetic operators: +, -, *, / (standard priorities)
Mathematical functions: ln(x), sqrt(x), pow(x,y)
Brackets (for changing the default priorities)
	Examples:
	(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) -> ~ 10.6
	pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) -> ~ 21.22
	Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

static class ParseMathematicalExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Calculate("(3+5.3) * 2.7 - ln(22)/pow(2.2, ~1.7)");
        Calculate("pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)");
        Calculate("(1 - -1) * pow(pow(1 + 1, pow(ln(2.71), 1 - 1)), 10)");
        Calculate("-(-1 + -2)");
    }
    static void Prints(this List<string> list)
    {
        Console.WriteLine(String.Join(" ", list));
    }
    static void Print(this List<Tuple<string, string>> list)
    {
        foreach (var item in list)
            Console.Write(item.Item1 + " ");
        Console.WriteLine();
    }
    static Dictionary<string, Tuple<int, bool>> precedence = new Dictionary<string, Tuple<int, bool>>() {
        { "~",
            new Tuple<int, bool>(5 , true)},
        { "pow",
            new Tuple<int, bool>(4 , true)},
        { "sqrt",
            new Tuple<int, bool>(4 , false)},
        { "ln",
            new Tuple<int, bool>(4 , false)},
        { "*",
            new Tuple<int, bool>(3 , false)},
        { "/",
            new Tuple<int, bool>(3 , false)},
        { "+",
            new Tuple<int, bool>(2 , false)},
        { "-",
            new Tuple<int, bool>(2 , false)},
        { "(",
            new Tuple<int, bool>(0 , false)},
        { ")",
            new Tuple<int, bool>(999 , false)}
    };
    static List<Tuple<string, string>> Tokenize(string s)
    {
        var tokens = new List<Tuple<string, string>>(); // Value, type
        Tuple<string, string> previous = null;
        for (int i = 0; i < s.Length; i++)
        {
            string value = String.Empty, type = null;
            if (s[i] == ' ') continue;
            else if (Char.IsDigit(s[i]))
            {
                type = "number";

                for (; i < s.Length && (Char.IsDigit(s[i]) || s[i] == '.' || s[i] == '-'); i++) value += s[i];
                i--;
            }
            else if (Char.IsLetter(s[i]))
            {
                type = "function";
                for (; i < s.Length && Char.IsLetter(s[i]); i++) value += s[i];
                i--;
            }
            else if (s[i] == ',')
            {
                type = "separator";

                value += s[i];
            }
            else
            {
                type = "operator";
                value += s[i];
                if (value == "-" && (previous == null || previous.Item1 == "(" || (previous.Item2 == "operator" && previous.Item1 != ")")))
                    value = "~";
            }
            previous = new Tuple<string, string>(value, type);
            tokens.Add(previous);
        }
        Print(tokens);
        return tokens;
    }
    static List<string> Parse(List<Tuple<string, string>> infix)
    {
        var postfix = new List<string>();
        var operators = new Stack<string>();
        foreach (var token in infix)
        {
            string value = token.Item1, type = token.Item2;
            if (type == "number")
                postfix.Add(value);
            else if (type == "function") 
                operators.Push(value);
            else if (type == "separator")
                while (operators.Peek() != "(") 
                    postfix.Add(operators.Pop());
            else if (value == "(")
                operators.Push(value);
            else if (value == ")")
                while ((value = operators.Pop()) != "(")
                    postfix.Add(value);
            else if (type == "operator")
            {
                while (operators.Count != 0)
                {
                    if (precedence[value].Item2 && (precedence[value].Item1 < precedence[operators.Peek()].Item1))
                        postfix.Add(operators.Pop());
                    else if (precedence[value].Item1 <= precedence[operators.Peek()].Item1)
                        postfix.Add(operators.Pop());
                    else break;
                }
                operators.Push(value);
            }
        }
        while (operators.Count != 0)
            postfix.Add(operators.Pop());
        Prints(postfix);
        return postfix;
    }
    static double Evaluate(List<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (var token in postfix)
            if (token == "+") stack.Push(stack.Pop() + stack.Pop());
            else if (token == "-") stack.Push(-stack.Pop() + stack.Pop());
            else if (token == "~") stack.Push(-stack.Pop());
            else if (token == "*") stack.Push(stack.Pop() * stack.Pop());
            else if (token == "/") stack.Push(1 / stack.Pop() * stack.Pop());
            else if (token == "ln") stack.Push(Math.Log(stack.Pop(), Math.E));
            else if (token == "sqrt") stack.Push(Math.Sqrt(stack.Pop()));
            else if (token == "pow") stack.Push(Math.Pow(y: stack.Pop(), x: stack.Pop()));
            else stack.Push(double.Parse(token));
        return stack.Pop();
    }
    static void Calculate(string expression)
    {
        Console.WriteLine(Evaluate(Parse(Tokenize(expression))));
        Console.WriteLine();
    }
}