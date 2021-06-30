using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";
            Console.Write("Target Row? ");
            var userRowInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column? ");
            var userColumnInput = Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Deploy to:");
            
            Console.WriteLine($"{userRowInput} , {userColumnInput-1}");
            Console.WriteLine($"{userColumnInput-1} , {userColumnInput}");
            Console.WriteLine($"{userRowInput} , {userColumnInput + 1}");
            Console.WriteLine($"{userRowInput + 1} , {userColumnInput}");

        }
    }
}
