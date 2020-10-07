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
            user.phoneNo();
            user.VerifiedEmailList();
            user.PassWordVerification();
            Console.WriteLine("\nName : " + user.FirstName + " " + user.LastName);
            Console.WriteLine("Email : " + user.emailId);
            Console.WriteLine("Ph. Number : " + user.PhoneNumber);
        }
    }
}
