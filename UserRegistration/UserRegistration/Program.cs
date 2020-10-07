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

            User user = new User();
         
            user.verifyfirstName();
            user.verifylastName();
            Console.WriteLine("\nName : " + user.FirstName + " " + user.LastName);

        }
       
    }
}
