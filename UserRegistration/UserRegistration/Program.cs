using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To The Registration Process");
            Console.WriteLine("=============================================");
            Regex regex = new Regex("^[A-Z]");
            Console.WriteLine("Enter The Name :");
            string name = Console.ReadLine();
            Match match = regex.Match(name);
            if (match.Success && name.Length>3)
            {
                Console.WriteLine("validation Suceesful");
            }
            else
            {
                Console.WriteLine("Not Matching");
            }

        }
    }
}
