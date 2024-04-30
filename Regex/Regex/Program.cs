// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first name : ");
        string name=Console.ReadLine();
        if(isValidName(name))
        {
            Console.WriteLine("Name is valid");
        }
        else
        {
            Console.WriteLine("Name not valid");
        }
        Console.WriteLine("Enter last name : ");
        string name1 = Console.ReadLine();
        if (isValidName(name1))
        {
            Console.WriteLine("Name is valid");
        }
        else
        {
            Console.WriteLine("Name not valid");
        }
        Console.WriteLine("Enter email id : ");
        string email = Console.ReadLine();
        if (isValidEmail(email))
        {
            Console.WriteLine("Email is valid");
        }
        else
        {
            Console.WriteLine("Email not valid");
        }
        Console.WriteLine("Enter phone number : ");
        string phone = Console.ReadLine();
        if (isValidPhone(phone))
        {
            Console.WriteLine("Phone is valid");
        }
        else
        {
            Console.WriteLine("Phone not valid");
        }
        Console.WriteLine("Enter password : ");
        string pass = Console.ReadLine();
        if (isValidPassword(pass))
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            Console.WriteLine("Password not valid");
        }
    }
     static bool isValidName(string name)
     {
        string pattern = @"^[A-Z].{2,}$";
        return Regex.IsMatch(name, pattern);
     }
    static bool isValidEmail(string emailid)
    {
        string pattern = @"^\b[a-zA-Z0-9.%+_-]+@[a-zA-Z0-9.-]+\.[A-Z|a-z]{2,}\b$";
        return Regex.IsMatch(emailid, pattern);
    }
    static bool isValidPhone(string phoneNumber)
    {
        string pattern = @"^\+\d{2}\s\d{10}$";
        return Regex.IsMatch(phoneNumber, pattern);
    }
    static bool isValidPassword(string password)
    {
        string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*()-_+=]).{8,}$";
        
        return Regex.IsMatch(password, pattern);
    }
}