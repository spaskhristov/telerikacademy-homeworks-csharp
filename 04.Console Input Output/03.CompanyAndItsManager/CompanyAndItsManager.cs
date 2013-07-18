/* 3.A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. Write a 
 * program that reads the information about a company and its manager and 
 * prints them on the console.
 */

using System;

class CompanyAndItsManager
{
    static void Main()
    {
        Console.Write("Eter name of the company: ");
        string company = Console.ReadLine();
        Console.Write("Enter address of the company: ");
        string address = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter company FAX number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Enter web site of the company: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter how old is manager: ");
        string age = Console.ReadLine();
        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("Company: {0} \nAddress: {1} \nPhone number: {2}     FAX: {3} \nweb site: {4}",
            company, address, companyPhone, companyFax, webSite);
        Console.WriteLine("Manager: {0} {1} - {2} age \nPhone number: {3}",
            firstName, lastName, age, managerPhone);
    }
}