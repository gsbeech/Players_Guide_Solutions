using System;

namespace Catacombs_Of_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a suggested password to check for validity:");
                var userPassword = Console.ReadLine();
                string userPasswordValidity = PasswordValidator.IsValidPassword(userPassword) ? "Valid password." : "Invalid Password";
                Console.WriteLine(userPasswordValidity);
            }
        }
    }
}
