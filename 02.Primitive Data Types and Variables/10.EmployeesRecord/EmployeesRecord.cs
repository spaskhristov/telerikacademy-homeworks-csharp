/* 10. A marketing firm wants to keep record of its employees. Each record would have 
 * the following characteristics –  first name, family name, age, gender (m or f), ID number,
 * unique employee number (27560000 to 27569999). Declare the variables 
 * needed to keep the information for a single employee using appropriate
 * data types and descriptive names.*/
using System;

class EmployeesRecord
{
    static void Main()
    {
        string firstName = "Stamat";
        string lastName = "Stamatov";
        int age = 33;
        char gender= 'm';
        int idNumber = 123;
        ushort uniqueEmpNumber = 275;
        Console.WriteLine("Name: " + firstName + " " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("ID Number: " + idNumber);
        Console.WriteLine("Unique Employee Number: " + (27560000 + uniqueEmpNumber));
    }
}