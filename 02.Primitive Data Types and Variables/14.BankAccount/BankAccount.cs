/* 14. A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit
 * card numbers associated with the account. Declare the variables needed to keep
 * the information for a single bank account using the appropriate data types and 
 * descriptive names.*/
using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Stamat";
        string middleName = "Stamatov";
        string lastName = "Stamatov";
        decimal moneyBalance = 2004.50m;
        string bankName = "NoiBank";
        string iban = "BG00120003390";
        string bic = "NBANK";
        string cc1 = "213456789";
        string cc2 = "234456777";
        string cc3 = "987643224";
        Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("{0} {1} {2}", bankName, iban, bic);
        Console.WriteLine("Credit card 1 : {0}", cc1);
        Console.WriteLine("Credit card 2 : {0}", cc2);
        Console.WriteLine("Credit card 3 : {0}", cc3);
        Console.WriteLine("Money balance= {0}", moneyBalance);
    }
}