// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter user name : ");
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
    }
     static bool isValidName(string name)
    {
        string pattern = @"^[A-Z].{2,}$";
        return Regex.IsMatch(name, pattern);
    }
}