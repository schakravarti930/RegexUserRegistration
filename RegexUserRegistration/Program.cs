﻿using System;

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
            Console.WriteLine("Enter Your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateLastName(lastName));
            Console.WriteLine("Enter Your Email Address");
            string email = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateEmail(email));
        }
    }
}