using System;

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
            user.verifyEmail();
            Console.WriteLine("\nName : " + user.FirstName + " " + user.LastName);
        }
    }
}
