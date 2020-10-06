using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regexValidation = new RegexValidation();
            Console.WriteLine("Enter Your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(firstName));
        }
    }
}
