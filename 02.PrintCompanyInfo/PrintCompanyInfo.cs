using System;

class Program
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(companyName + 
            "\r\n" + companyAddress + 
            "\r\n" + phoneNumber + 
            "\r\n" + faxNumber + 
            "\r\n" + webSite + 
            "\r\n" + managerFirstName + 
            "\r\n" + managerLastName + 
            "\r\n" + managerAge + 
            "\r\n" + managerPhone);
    }
}

